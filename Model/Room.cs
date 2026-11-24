using System;

namespace Model
{
	public class Room
	{
		public int RoomID { get; set; }
		public string RoomNumber { get; set; }
		public string RoomType { get; set; }
		public decimal Rate { get; set; }
		public int Capacity { get; set; } // NEW
		public string Status { get; set; }
	}
}