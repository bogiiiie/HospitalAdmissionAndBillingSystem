using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class RoomRepository
	{
		private readonly string connectionString;

		public RoomRepository()
		{
			connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		// ==========================================
		// READ — Get all rooms
		// ==========================================
		public List<Room> GetAllRooms()
		{
			List<Room> rooms = new List<Room>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Status FROM Rooms;";

				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						rooms.Add(new Room
						{
							RoomID = Convert.ToInt32(reader["RoomID"]),
							RoomNumber = reader["RoomNumber"].ToString(),
							RoomType = reader["RoomType"].ToString(),
							Rate = Convert.ToDecimal(reader["Rate"]),
							Status = reader["Status"].ToString()
						});
					}
				}
			}

			return rooms;
		}

		// ==========================================
		// READ — Get one room by number
		// ==========================================
		public Room GetRoomByNumber(string roomNumber)
		{
			Room room = null;

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Status " +
							 "FROM Rooms WHERE RoomNumber = @RoomNumber LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							room = new Room
							{
								RoomID = Convert.ToInt32(reader["RoomID"]),
								RoomNumber = reader["RoomNumber"].ToString(),
								RoomType = reader["RoomType"].ToString(),
								Rate = Convert.ToDecimal(reader["Rate"]),
								Status = reader["Status"].ToString()
							};
						}
					}
				}
			}

			return room;
		}

		// ==========================================
		// CREATE — Add a new room
		// ==========================================
		public void AddRoom(Room room)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "INSERT INTO Rooms (RoomNumber, RoomType, Rate, Status) " +
							 "VALUES (@RoomNumber, @RoomType, @Rate, @Status);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
					cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
					cmd.Parameters.AddWithValue("@Rate", room.Rate);
					cmd.Parameters.AddWithValue("@Status", room.Status);

					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// UPDATE — Edit an existing room
		// Added a WHERE guard so an occupied room can't be edited
		// even if something calls this method directly.
		// Returns the number of rows affected so we can detect a blocked update.
		// ==========================================
		public int UpdateRoom(Room room)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Rooms SET RoomType = @RoomType, Rate = @Rate, " +
							 "Status = @Status " +
							 "WHERE RoomNumber = @RoomNumber AND Status <> 'Occupied';";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
					cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
					cmd.Parameters.AddWithValue("@Rate", room.Rate);
					cmd.Parameters.AddWithValue("@Status", room.Status);

					return cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// UPDATE STATUS ONLY — used by Admission / Discharge
		// Bypasses the occupied-room guard because it is only
		// ever called by trusted internal logic (admission → Occupied,
		// discharge → Available).
		// ==========================================
		public int UpdateRoomStatus(string roomNumber, string status)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Rooms SET Status = @Status " +
							 "WHERE RoomNumber = @RoomNumber;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
					cmd.Parameters.AddWithValue("@Status", status);
					return cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// DELETE — Soft delete (mark Status as 'Deleted')
		// Same guard as UpdateRoom so an occupied room
		// can never be soft-deleted from here.
		// ==========================================
		public int DeleteRoom(string roomNumber)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Rooms SET Status = 'Deleted' " +
							 "WHERE RoomNumber = @RoomNumber AND Status <> 'Occupied';";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
					return cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// SEARCH — Find rooms by keyword
		// ==========================================
		public List<Room> SearchRooms(string keyword)
		{
			List<Room> rooms = new List<Room>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Status FROM Rooms " +
							 "WHERE RoomNumber LIKE @Keyword OR RoomType LIKE @Keyword;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							rooms.Add(new Room
							{
								RoomID = Convert.ToInt32(reader["RoomID"]),
								RoomNumber = reader["RoomNumber"].ToString(),
								RoomType = reader["RoomType"].ToString(),
								Rate = Convert.ToDecimal(reader["Rate"]),
								Status = reader["Status"].ToString()
							});
						}
					}
				}
			}

			return rooms;
		}

		// ==========================================
		// REACTIVATE — Set status back to Available
		// Used to restore a room that was previously
		// soft-deleted by mistake. Returns rows affected.
		// ==========================================
		public int ReactivateRoom(string roomNumber)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Rooms SET Status = 'Available' " +
							 "WHERE RoomNumber = @RoomNumber AND Status = 'Deleted';";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
					return cmd.ExecuteNonQuery();
				}
			}
		}
	}
}