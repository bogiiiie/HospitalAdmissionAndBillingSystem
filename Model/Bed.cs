using System;

namespace Model
{
	public class Bed
	{
		public int BedID { get; set; }
		public string RoomNumber { get; set; }
		public string BedName { get; set; } // e.g., "A", "B", "1", "2"
		public string Status { get; set; }  // "Available", "Occupied"
	}
}