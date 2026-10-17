using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class StaffAssignmentController
	{
		private readonly StaffAssignmentRepository repository = new StaffAssignmentRepository();
		private readonly AdmissionRepository admissionRepo = new AdmissionRepository();

		public string UpdateAssignment(string admissionCode, string newDoctor, string newNurse, string reason)
		{
			if (string.IsNullOrWhiteSpace(admissionCode))
				return "Please select an active admission.";

			if (string.IsNullOrWhiteSpace(newDoctor) && string.IsNullOrWhiteSpace(newNurse) && string.IsNullOrWhiteSpace(reason))
				return "Please enter a new doctor, nurse, or reason.";

			Admission adm = admissionRepo.GetAdmissionByCode(admissionCode);
			if (adm == null) return "Admission not found.";
			if (adm.Status != "Admitted") return "Cannot reassign staff on a discharged admission.";

			string currentDoctor = adm.AttendingDoctor;
			string currentNurse = adm.AssignedNurse;

			// Process Doctor change
			if (!string.IsNullOrWhiteSpace(newDoctor) && newDoctor != currentDoctor)
			{
				admissionRepo.UpdateStaffAssignment(admissionCode, newDoctor, currentNurse);
				repository.AddHistory(admissionCode, "Doctor", newDoctor, reason);
				currentDoctor = newDoctor;
			}

			// Process Nurse change
			if (!string.IsNullOrWhiteSpace(newNurse) && newNurse != currentNurse)
			{
				admissionRepo.UpdateStaffAssignment(admissionCode, currentDoctor, newNurse);
				repository.AddHistory(admissionCode, "Nurse", newNurse, reason);
			}

			return "OK";
		}

		public List<StaffAssignment> GetHistory(string admissionCode)
		{
			return repository.GetHistoryByAdmission(admissionCode);
		}
	}
}