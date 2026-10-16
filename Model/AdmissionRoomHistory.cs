using System;

namespace Model
{
	public class AdmissionRoomHistory
	{
		public int HistoryID { get; set; }              // internal auto-increment
		public string AdmissionCode { get; set; }        // FK → Admissions.AdmissionCode
		public string RoomNumber { get; set; }           // FK → Rooms.RoomNumber
		public string RoomType { get; set; }             // snapshot for display
		public decimal Rate { get; set; }                // snapshot of rate for this period
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }           // NULL = current period
		public DateTime CreatedAt { get; set; }
	}
}