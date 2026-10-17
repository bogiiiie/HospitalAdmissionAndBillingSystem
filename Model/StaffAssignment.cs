using System;

namespace Model
{
	public class StaffAssignment
	{
		public int HistoryID { get; set; }
		public string AdmissionCode { get; set; }
		public string Role { get; set; } // "Doctor" or "Nurse"
		public string StaffName { get; set; }
		public DateTime AssignedDate { get; set; }
		public string Reason { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}