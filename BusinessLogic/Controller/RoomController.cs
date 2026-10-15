using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class RoomController
	{
		private readonly RoomRepository repository = new RoomRepository();

		// ==========================================
		// READ — Get all rooms (passthrough)
		// ==========================================
		public List<Room> GetAllRooms()
		{
			return repository.GetAllRooms();
		}

		// ==========================================
		// READ — Get one room (passthrough)
		// ==========================================
		public Room GetRoomByNumber(string roomNumber)
		{
			return repository.GetRoomByNumber(roomNumber);
		}

		// ==========================================
		// CREATE — Add with validation
		// Returns "OK" on success, or an error message
		// ==========================================
		public string AddRoom(string number, string type, decimal rate, string status)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			if (string.IsNullOrWhiteSpace(type))
				return "Room type is required.";

			if (rate <= 0)
				return "Rate must be greater than zero.";

			if (string.IsNullOrWhiteSpace(status))
				return "Status is required.";

			// Check for duplicate room number
			Room existing = repository.GetRoomByNumber(number);
			if (existing != null)
				return "Room number already exists.";

			Room room = new Room
			{
				RoomNumber = number,
				RoomType = type,
				Rate = rate,
				Status = status
			};

			repository.AddRoom(room);
			return "OK";
		}

		// ==========================================
		// UPDATE — Edit with validation
		// Added a check so an occupied room cannot be edited.
		// ==========================================
		public string UpdateRoom(string number, string type, decimal rate, string status)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			if (string.IsNullOrWhiteSpace(type))
				return "Room type is required.";

			if (rate <= 0)
				return "Rate must be greater than zero.";

			if (string.IsNullOrWhiteSpace(status))
				return "Status is required.";

			// Room must exist
			Room existing = repository.GetRoomByNumber(number);
			if (existing == null)
				return "Room not found.";

			// Occupied rooms are locked — the patient must be discharged first
			if (existing.Status == "Occupied")
				return "Cannot edit an occupied room. Discharge the patient first.";

			Room room = new Room
			{
				RoomNumber = number,
				RoomType = type,
				Rate = rate,
				Status = status
			};

			int rows = repository.UpdateRoom(room);

			// Safety net — if the DB guard also blocked it (0 rows updated)
			if (rows == 0)
				return "Cannot edit an occupied room. Discharge the patient first.";

			return "OK";
		}

		// ==========================================
		// DELETE — Remove with validation
		// ==========================================
		public string DeleteRoom(string number)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			Room existing = repository.GetRoomByNumber(number);
			if (existing == null)
				return "Room not found.";

			if (existing.Status == "Occupied")
				return "Cannot delete an occupied room.";

			if (existing.Status == "Deleted")
				return "Room is already deleted.";

			int rows = repository.DeleteRoom(number);

			// Same idea — if the DB-level guard rejected the change
			if (rows == 0)
				return "Cannot delete an occupied room.";

			return "OK";
		}

		// ==========================================
		// SEARCH — Find rooms by keyword
		// ==========================================
		public List<Room> SearchRooms(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
				return repository.GetAllRooms();   // empty keyword = show all

			return repository.SearchRooms(keyword);
		}

		// ==========================================
		// REACTIVATE — Restore a Deleted room to Available
		// ==========================================
		public string ReactivateRoom(string number)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			Room existing = repository.GetRoomByNumber(number);
			if (existing == null)
				return "Room not found.";

			if (existing.Status != "Deleted")
				return "Room is not deleted.";

			int rows = repository.ReactivateRoom(number);
			if (rows == 0)
				return "Failed to reactivate room.";

			return "OK";
		}
	}
}