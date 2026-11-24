using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class RoomController
	{
		private readonly RoomRepository repository = new RoomRepository();
		private readonly BedRepository bedRepo = new BedRepository();

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
		// ==========================================
		public string AddRoom(string number, string type, decimal rate, int capacity, string status)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			if (string.IsNullOrWhiteSpace(type))
				return "Room type is required.";

			if (rate <= 0)
				return "Rate must be greater than zero.";

			if (capacity < 1)
				return "Capacity must be at least 1 bed."; // NEW

			if (string.IsNullOrWhiteSpace(status))
				return "Status is required.";

			Room existing = repository.GetRoomByNumber(number);
			if (existing != null)
				return "Room number already exists.";

			Room room = new Room
			{
				RoomNumber = number,
				RoomType = type,
				Rate = rate,
				Capacity = capacity, // NEW
				Status = status
			};

			repository.AddRoom(room);
			return "OK";
		}

		// ==========================================
		// UPDATE — Edit with validation
		// ==========================================
		public string UpdateRoom(string number, string type, decimal rate, int capacity, string status)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			if (string.IsNullOrWhiteSpace(type))
				return "Room type is required.";

			if (rate <= 0)
				return "Rate must be greater than zero.";

			if (capacity < 1)
				return "Capacity must be at least 1 bed.";

			if (string.IsNullOrWhiteSpace(status))
				return "Status is required.";

			Room existing = repository.GetRoomByNumber(number);
			if (existing == null)
				return "Room not found.";

			// NEW: Block editing if ANY bed is currently occupied
			int occupiedBeds = bedRepo.GetOccupiedBedCount(number);
			if (occupiedBeds > 0)
				return "Cannot edit a room that has occupied beds. Discharge the patients first.";

			Room room = new Room
			{
				RoomNumber = number,
				RoomType = type,
				Rate = rate,
				Capacity = capacity, // NEW
				Status = status
			};

			int rows = repository.UpdateRoom(room);

			if (rows == 0)
				return "Cannot edit this room. It may be occupied.";

			return "OK";
		}

		// ==========================================
		// UPDATE STATUS ONLY
		// ==========================================
		public int UpdateRoomStatus(string roomNumber, string status)
		{
			return repository.UpdateRoomStatus(roomNumber, status);
		}

		// ==========================================
		// DELETE
		// ==========================================
		public string DeleteRoom(string number)
		{
			if (string.IsNullOrWhiteSpace(number))
				return "Room number is required.";

			Room existing = repository.GetRoomByNumber(number);
			if (existing == null)
				return "Room not found.";

			int occupiedBeds = bedRepo.GetOccupiedBedCount(number);
			if (occupiedBeds > 0)
				return "Cannot delete a room that has occupied beds.";

			if (existing.Status == "Deleted")
				return "Room is already deleted.";

			int rows = repository.DeleteRoom(number);
			if (rows == 0)
				return "Cannot delete an occupied room.";

			return "OK";
		}

		// ==========================================
		// SEARCH
		// ==========================================
		public List<Room> SearchRooms(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
				return repository.GetAllRooms();

			return repository.SearchRooms(keyword);
		}

		// ==========================================
		// REACTIVATE
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