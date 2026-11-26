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
		private readonly BedRepository bedRepo = new BedRepository(); // NEW

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
		// Added bedName to the parameters.
		// ==========================================
		public string AddAdmission(string patientCode, string roomNumber, string bedName,
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

			// 5. Room and Bed must be selected
			if (string.IsNullOrWhiteSpace(roomNumber) || string.IsNullOrWhiteSpace(bedName))
				return "Please select a room and bed.";

			// 6. Room must still exist
			Room room = roomRepo.GetRoomByNumber(roomNumber);
			if (room == null)
				return "Room not found. Please reselect.";

			// 7. Room must be Available
			if (room.Status != "Available")
				return "Selected room is unavailable. Please choose another room.";

			// 8. Bed must be Available (NEW)
			if (!bedRepo.IsBedAvailable(roomNumber, bedName))
				return "Selected bed is no longer available.";

			// 9. Diagnosis must not be empty
			if (string.IsNullOrWhiteSpace(diagnosis))
				return "Diagnosis is required.";

			// ---- All checks passed — build the admission row ----
			Admission adm = new Admission
			{
				AdmissionCode = repository.GenerateNextAdmissionCode(),
				PatientCode = patientCode,
				RoomNumber = roomNumber,
				BedName = bedName, // NEW
				AdmissionDate = DateTime.Now,
				Diagnosis = diagnosis.Trim(),
				LockedRate = room.Rate,
				Status = "Admitted",
				AdmittedBy = admittedBy
			};

			// Insert the admission
			repository.AddAdmission(adm);

			// Open the first room-history period
			repository.AddRoomHistory(
				adm.AdmissionCode,
				room.RoomNumber,
				adm.BedName, // NEW
				room.RoomType,
				room.Rate,
				adm.AdmissionDate);

			// Flip the bed to Occupied
			bedRepo.UpdateBedStatus(roomNumber, bedName, "Occupied");

			// Check if the room is now full
			int occupiedBeds = bedRepo.GetOccupiedBedCount(roomNumber);
			if (occupiedBeds >= room.Capacity)
			{
				// All beds are full, room becomes Occupied
				roomRepo.UpdateRoomStatus(roomNumber, "Occupied");
			}
			else
			{
				// Still has empty beds, room remains Available
				roomRepo.UpdateRoomStatus(roomNumber, "Available");
			}

			return "OK";
		}

		// ==========================================
		// UPDATE — Admin override: change room/bed + diagnosis
		// ==========================================
		public string UpdateAdmission(string admissionCode, string newRoomNumber, string newBedName, string diagnosis)
		{
			if (string.IsNullOrWhiteSpace(admissionCode))
				return "Admission code is required.";

			Admission existing = repository.GetAdmissionByCode(admissionCode);
			if (existing == null)
				return "Admission not found.";

			if (existing.Status != "Admitted")
				return "Cannot edit a discharged admission.";

			if (string.IsNullOrWhiteSpace(newRoomNumber) || string.IsNullOrWhiteSpace(newBedName))
				return "Please select a new room and bed.";

			if (string.IsNullOrWhiteSpace(diagnosis))
				return "Diagnosis is required.";

			// If the bed is unchanged, only update diagnosis
			bool bedChanged = !string.Equals(existing.RoomNumber, newRoomNumber, StringComparison.OrdinalIgnoreCase) ||
							  !string.Equals(existing.BedName, newBedName, StringComparison.OrdinalIgnoreCase);

			if (bedChanged)
			{
				// New room must exist and be Available
				Room newRoom = roomRepo.GetRoomByNumber(newRoomNumber);
				if (newRoom == null)
					return "Selected room not found.";
				if (newRoom.Status != "Available")
					return "Selected room is unavailable.";
				if (!bedRepo.IsBedAvailable(newRoomNumber, newBedName))
					return "Selected bed is unavailable."; // NEW

				// Close the current room-history period
				repository.CloseCurrentRoomHistory(existing.AdmissionCode, DateTime.Now);

				// Open a new room-history period for the new room/bed
				repository.AddRoomHistory(
					existing.AdmissionCode,
					newRoom.RoomNumber,
					newBedName, // NEW
					newRoom.RoomType,
					newRoom.Rate,
					DateTime.Now);

				// Free the old bed
				bedRepo.UpdateBedStatus(existing.RoomNumber, existing.BedName, "Available");

				// Check if the old room is now fully empty
				if (bedRepo.GetOccupiedBedCount(existing.RoomNumber) == 0)
				{
					roomRepo.UpdateRoomStatus(existing.RoomNumber, "Available");
				}

				// Occupy the new bed
				bedRepo.UpdateBedStatus(newRoomNumber, newBedName, "Occupied");

				// Occupy the new room
				roomRepo.UpdateRoomStatus(newRoomNumber, "Occupied");

				// Update the admission row
				existing.RoomNumber = newRoomNumber;
				existing.BedName = newBedName; // NEW
				existing.Diagnosis = diagnosis.Trim();
				existing.LockedRate = newRoom.Rate;
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
		// QUERY — Get the name of the patient in a bed
		// ==========================================
		public string GetOccupantName(string roomNumber, string bedName) // NEW
		{
			string patientCode = repository.GetOccupant(roomNumber, bedName);
			if (string.IsNullOrEmpty(patientCode))
				return "—";

			Patient p = patientRepo.GetPatientByCode(patientCode);
			if (p == null)
				return "—";

			return p.FullName;
		}

		// ==========================================
		// QUERY — Get all room periods for an admission
		// ==========================================
		public List<AdmissionRoomHistory> GetRoomHistory(string admissionCode)
		{
			return repository.GetRoomHistory(admissionCode);
		}

		// ==========================================
		// BILLING HELPER — Total room charges for an admission
		// ==========================================
		public decimal CalculateRoomCharges(string admissionCode, DateTime asOf)
		{
			decimal total = 0m;

			List<AdmissionRoomHistory> history = repository.GetRoomHistory(admissionCode);

			foreach (AdmissionRoomHistory h in history)
			{
				DateTime end = h.EndDate ?? asOf;
				double days = Math.Ceiling((end - h.StartDate).TotalDays);
				if (days < 1) days = 1;

				total += h.Rate * (decimal)days;
			}

			return total;
		}

		// ==========================================
		// DISCHARGE — Validate and process discharge
		// NEW: Handles Partial Payment rules and Admin Override.
		// ==========================================
		public string DischargePatient(string admissionCode, DateTime dischargeDate, string notes,
									   bool isAdminOverride, string reason, string frequency, DateTime? followUpDate)
		{
			if (string.IsNullOrWhiteSpace(admissionCode))
				return "Please select an admission.";

			Admission adm = repository.GetAdmissionByCode(admissionCode);
			if (adm == null)
				return "Admission not found.";
			if (adm.Status == "Discharged")
				return "This patient is already discharged.";

			// Check Billing Status
			BillController billController = new BillController();
			Bill bill = billController.GetBill(admissionCode);

			if (bill == null)
				return "No bill generated yet. Please generate a bill first.";

			// If there is a balance, enforce the rules
			if (bill.Balance > 0)
			{
				// Staff are strictly blocked from discharging with a balance
				if (!isAdminOverride)
				{
					return "Patient must have no outstanding balance before discharge. Ask an Admin to override.";
				}

				// If Admin Override is true but no reason was provided
				if (string.IsNullOrWhiteSpace(reason))
				{
					return "A reason (Promissory Note) is required for Admin Override.";
				}
			}

			// Process Discharge (passing the override fields to the repository)
			repository.DischargePatient(admissionCode, adm.RoomNumber, adm.BedName, dischargeDate, notes,
										reason, frequency, followUpDate);
			return "OK";
		}

		// ==========================================
		// Display all discharged admissions (for reporting)
		// ==========================================
		public List<Admission> GetDischargedAdmissions()
		{
			return repository.GetDischargedAdmissions();
		}

		// NEW: Used by Billing to find Active patients OR Discharged patients with a Balance > 0
		public List<Admission> GetBillableAdmissions()
		{
			return repository.GetBillableAdmissions();
		}
	}
}