using System;

namespace Model
{
	public class Admission
	{
		public int AdmissionID { get; set; }              // internal DB id (auto-increment)
		public string AdmissionCode { get; set; }         // display ID like "ADM-0001"
		public string PatientCode { get; set; }           // FK → Patients.PatientCode
		public string RoomNumber { get; set; }            // FK → Rooms.RoomNumber
		public string BedName { get; set; }
		public DateTime AdmissionDate { get; set; }
		public string Diagnosis { get; set; }
		public decimal LockedRate { get; set; }           // room rate snapshot at admission time
		public string Status { get; set; }                // "Admitted" or "Discharged"
		public string AdmittedBy { get; set; }            // username of staff who admitted
		public DateTime? DischargeDate { get; set; }      // NULL until discharged
		public string DischargeNotes { get; set; }        // NULL until discharged
		public DateTime CreatedAt { get; set; }
		public string AttendingDoctor { get; set; }
		public string AssignedNurse { get; set; }

		// =========================================================
		// NEW FIELDS: For Partial Payments and Admin Override
		// =========================================================

		// Stores the reason for overriding (e.g., "Promissory Note")
		public string DischargeReason { get; set; }

		// Stores the frequency of payment (e.g., "Weekly", "Monthly")
		public string PaymentFrequency { get; set; }

		// Stores the next expected payment date
		public DateTime? FollowUpDate { get; set; }
		public string InstallmentType { get; set; }  // "Fixed" or "Percentage"
		public decimal InstallmentValue { get; set; } // e.g., 1000 or 20
	}
}