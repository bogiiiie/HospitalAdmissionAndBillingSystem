using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class PatientController
	{
		private readonly PatientRepository repository = new PatientRepository();

		// ==========================================
		// READ — Get all patients
		// ==========================================
		public List<Patient> GetAllPatients(string filter = "Active")
		{
			return repository.GetAllPatients(filter);
		}

		// ==========================================
		// READ — Get one patient by code
		// ==========================================
		public Patient GetPatientByCode(string patientCode)
		{
			return repository.GetPatientByCode(patientCode);
		}

		// ==========================================
		// SEARCH — Find by ID / name / contact
		// ==========================================
		public List<Patient> SearchPatients(string keyword, string filter = "Active")
		{
			if (string.IsNullOrWhiteSpace(keyword))
				return repository.GetAllPatients(filter);

			return repository.SearchPatients(keyword, filter);
		}

		// ==========================================
		// CREATE — Add with validation
		// ==========================================
		public string AddPatient(Patient p)
		{
			string validation = ValidatePatient(p);
			if (validation != "OK") return validation;

			p.PatientCode = repository.GenerateNextPatientCode();
			repository.AddPatient(p);
			return "OK";
		}

		// ==========================================
		// UPDATE — Edit with validation
		// ==========================================
		public string UpdatePatient(Patient p)
		{
			string validation = ValidatePatient(p);
			if (validation != "OK") return validation;

			Patient existing = repository.GetPatientByCode(p.PatientCode);
			if (existing == null) return "Patient not found.";

			repository.UpdatePatient(p);
			return "OK";
		}

		// ==========================================
		// DEACTIVATE — Staff + Admin can do this
		// ==========================================
		public string DeactivatePatient(string patientCode)
		{
			Patient existing = repository.GetPatientByCode(patientCode);
			if (existing == null) return "Patient not found.";
			if (!existing.IsActive) return "Patient is already inactive.";

			repository.DeactivatePatient(patientCode);
			return "OK";
		}

		// ==========================================
		// REACTIVATE — Admin only
		// ==========================================
		public string ReactivatePatient(string patientCode)
		{
			Patient existing = repository.GetPatientByCode(patientCode);
			if (existing == null) return "Patient not found.";
			if (existing.IsActive) return "Patient is already active.";

			repository.ReactivatePatient(patientCode);
			return "OK";
		}

		// ==========================================
		// DELETE — Admin only, only if no history
		// Returns "OK" or an error message
		// ==========================================
		public string DeletePatient(string patientCode)
		{
			Patient existing = repository.GetPatientByCode(patientCode);
			if (existing == null) return "Patient not found.";

			// Block permanent delete if the patient has any admission/billing history
			if (repository.HasAdmissionHistory(patientCode))
				return "Cannot permanently delete this patient — they have admission/billing history. Mark as inactive instead.";

			int rows = repository.DeletePatient(patientCode);
			if (rows == 0) return "Failed to delete patient.";

			return "OK";
		}

		// ==========================================
		// VALIDATION — shared between Add and Update
		// ==========================================
		private string ValidatePatient(Patient p)
		{
			if (string.IsNullOrWhiteSpace(p.FirstName))
				return "First name is required.";

			if (string.IsNullOrWhiteSpace(p.LastName))
				return "Last name is required.";

			if (p.DateOfBirth == default(DateTime))
				return "Date of birth is required.";

			// DOB cannot be in the future
			if (p.DateOfBirth.Date > DateTime.Today)
				return "Date of birth cannot be a future date.";

			if (string.IsNullOrWhiteSpace(p.Gender))
				return "Gender is required.";

			if (string.IsNullOrWhiteSpace(p.ContactNumber))
				return "Contact number is required.";

			// Contact number must contain at least 7 digits
			int digits = 0;
			foreach (char c in p.ContactNumber)
				if (char.IsDigit(c)) digits++;

			if (digits < 7)
				return "Contact number must contain at least 7 digits.";

			// Guardian is mandatory for minors
			bool isMinor = p.Age < 18;

			if (isMinor)
			{
				if (string.IsNullOrWhiteSpace(p.GuardianName) ||
					p.GuardianName == "Self — Patient arrived alone")
					return "Minor patients require a parent or legal guardian.";

				if (string.IsNullOrWhiteSpace(p.GuardianRelationship) ||
					p.GuardianRelationship == "Self")
					return "Minor patients require a parent or legal guardian (relationship cannot be Self).";

				if (string.IsNullOrWhiteSpace(p.GuardianContact))
					return "Guardian contact number is required for minor patients.";
			}

			// If a guardian name is given, contact must also be given
			if (!string.IsNullOrWhiteSpace(p.GuardianName) &&
				string.IsNullOrWhiteSpace(p.GuardianContact) &&
				p.GuardianName != "Self — Patient arrived alone")
				return "Guardian contact number is required when a guardian is specified.";

			return "OK";
		}
	}
}