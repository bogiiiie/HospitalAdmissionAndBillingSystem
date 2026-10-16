using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class AdmissionController
	{
		private readonly AdmissionRepository repository = new AdmissionRepository();
		private readonly PatientRepository patientRepo = new PatientRepository();
		private readonly RoomRepository roomRepo = new RoomRepository();

		// ==========================================
		// READ
		// ==========================================
		public List<Admission> GetAllAdmissions()
		{
			return repository.GetAllAdmissions();
		}

		public List<Admission> GetActiveAdmissions()
		{
			return repository.GetActiveAdmissions();
		}

		public Admission GetAdmissionByCode(string admissionCode)
		{
			return repository.GetAdmissionByCode(admissionCode);
		}

		// ==========================================
		// CREATE — Admit a patient
		// Full validation chain runs in order.
		// Returns "OK" on success, or an error message.
		// ==========================================
		public string AddAdmission(string patientCode, string roomNumber,
								   string diagnosis, string admittedBy)
		{
			// 1. Patient must be selected
			if (string.IsNullOrWhiteSpace(patientCode))
				return "Please select a patient.";

			// 2. Patient must still exist
			Patient patient = patientRepo.GetPatientByCode(patientCode);
			if (patient == null)
				return "Patient not found. Please reselect.";

			// 3. Patient must be active (not deactivated)
			if (!patient.IsActive)
				return "Patient is inactive and cannot be admitted.";

			// 4. Patient must not already have an active admission
			if (repository.HasActiveAdmission(patientCode))
				return "This patient already has an active admission.";

			// 5. Room must be selected
			if (string.IsNullOrWhiteSpace(roomNumber))
				return "Please select a room.";

			// 6. Room must still exist
			Room room = roomRepo.GetRoomByNumber(roomNumber);
			if (room == null)
				return "Room not found. Please reselect.";

			// 7. Room must be Available
			if (room.Status != "Available")
				return "Selected room is unavailable. Please choose another room.";

			// 8. Diagnosis must not be empty
			if (string.IsNullOrWhiteSpace(diagnosis))
				return "Diagnosis is required.";

			// ---- All checks passed — build the admission row ----
			Admission adm = new Admission
			{
				AdmissionCode = repository.GenerateNextAdmissionCode(),
				PatientCode = patientCode,
				RoomNumber = roomNumber,
				AdmissionDate = DateTime.Now,
				Diagnosis = diagnosis.Trim(),
				LockedRate = room.Rate,      // ← snapshot the rate
				Status = "Admitted",
				AdmittedBy = admittedBy
			};

			// Insert the admission
			repository.AddAdmission(adm);

			// Open the first room-history period
			repository.AddRoomHistory(
				adm.AdmissionCode,
				room.RoomNumber,
				room.RoomType,
				room.Rate,
				adm.AdmissionDate);

			// Flip the room to Occupied
			roomRepo.UpdateRoomStatus(roomNumber, "Occupied");

			return "OK";
		}

		// ==========================================
		// UPDATE — Admin override: change room + diagnosis
		// Returns "OK" or an error message.
		// ==========================================
		public string UpdateAdmission(string admissionCode, string newRoomNumber, string diagnosis)
		{
			if (string.IsNullOrWhiteSpace(admissionCode))
				return "Admission code is required.";

			Admission existing = repository.GetAdmissionByCode(admissionCode);
			if (existing == null)
				return "Admission not found.";

			if (existing.Status != "Admitted")
				return "Cannot edit a discharged admission.";

			if (string.IsNullOrWhiteSpace(newRoomNumber))
				return "Please select a new room.";

			if (string.IsNullOrWhiteSpace(diagnosis))
				return "Diagnosis is required.";

			// If the room is unchanged, only update diagnosis
			bool roomChanged = !string.Equals(existing.RoomNumber, newRoomNumber,
											 StringComparison.OrdinalIgnoreCase);

			if (roomChanged)
			{
				// New room must exist and be Available
				Room newRoom = roomRepo.GetRoomByNumber(newRoomNumber);
				if (newRoom == null)
					return "Selected room not found.";
				if (newRoom.Status != "Available")
					return "Selected room is unavailable.";

				// Close the current room-history period
				repository.CloseCurrentRoomHistory(existing.AdmissionCode, DateTime.Now);

				// Open a new room-history period for the new room
				repository.AddRoomHistory(
					existing.AdmissionCode,
					newRoom.RoomNumber,
					newRoom.RoomType,
					newRoom.Rate,
					DateTime.Now);

				// Free the old room
				roomRepo.UpdateRoomStatus(existing.RoomNumber, "Available");

				// Occupy the new room
				roomRepo.UpdateRoomStatus(newRoomNumber, "Occupied");

				// Update the admission row (current room + diagnosis + current rate)
				existing.RoomNumber = newRoomNumber;
				existing.Diagnosis = diagnosis.Trim();
				existing.LockedRate = newRoom.Rate;   // current rate (kept for display)
			}
			else
			{
				existing.Diagnosis = diagnosis.Trim();
			}

			repository.UpdateAdmission(existing);
			return "OK";
		}

		// ==========================================
		// QUERY — Get admission status for a patient
		// Returns "Admitted" / "Discharged" / "Not Admitted"
		// ==========================================
		public string GetPatientStatus(string patientCode)
		{
			if (repository.HasActiveAdmission(patientCode))
				return "Admitted";

			if (repository.HasAnyAdmission(patientCode))
				return "Discharged";

			return "Not Admitted";
		}

		// ==========================================
		// QUERY — Get the name of the patient in a room
		// Returns full name, or "—" if the room is empty.
		// ==========================================
		public string GetOccupantName(string roomNumber)
		{
			string patientCode = repository.GetOccupant(roomNumber);
			if (string.IsNullOrEmpty(patientCode))
				return "—";

			Patient p = patientRepo.GetPatientByCode(patientCode);
			if (p == null)
				return "—";

			return p.FullName;
		}

		// ==========================================
		// BILLING HELPER — Total room charges for an admission
		// Sums rate × days for each room period.
		// Uses DateTime.Now for the currently-open period.
		// ==========================================
		public decimal CalculateRoomCharges(string admissionCode, DateTime asOf)
		{
			decimal total = 0m;

			List<AdmissionRoomHistory> history = repository.GetRoomHistory(admissionCode);

			foreach (AdmissionRoomHistory h in history)
			{
				DateTime end = h.EndDate ?? asOf;
				double days = Math.Ceiling((end - h.StartDate).TotalDays);
				if (days < 1) days = 1;   // at least 1 day charge

				total += h.Rate * (decimal)days;
			}

			return total;
		}
	}
}