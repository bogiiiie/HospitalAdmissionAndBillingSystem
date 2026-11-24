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
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Capacity, Status FROM Rooms;";

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
							Capacity = Convert.ToInt32(reader["Capacity"]), // NEW
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
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Capacity, Status " +
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
								Capacity = Convert.ToInt32(reader["Capacity"]), // NEW
								Status = reader["Status"].ToString()
							};
						}
					}
				}
			}

			return room;
		}

		// ==========================================
		// CREATE — Add a new room and generate beds
		// ==========================================
		public void AddRoom(Room room)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				using (var trans = conn.BeginTransaction())
				{
					try
					{
						string sql = "INSERT INTO Rooms (RoomNumber, RoomType, Rate, Capacity, Status) " +
									 "VALUES (@RoomNumber, @RoomType, @Rate, @Capacity, @Status);";

						using (var cmd = new SQLiteCommand(sql, conn))
						{
							cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
							cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
							cmd.Parameters.AddWithValue("@Rate", room.Rate);
							cmd.Parameters.AddWithValue("@Capacity", room.Capacity); // NEW
							cmd.Parameters.AddWithValue("@Status", room.Status);
							cmd.ExecuteNonQuery();
						}

						// Generate the beds automatically
						GenerateBeds(conn, room.RoomNumber, room.Capacity);

						trans.Commit();
					}
					catch
					{
						trans.Rollback();
						throw;
					}
				}
			}
		}

		// ==========================================
		// UPDATE — Edit an existing room
		// ==========================================
		public int UpdateRoom(Room room)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				using (var trans = conn.BeginTransaction())
				{
					try
					{
						// Get the old capacity to calculate if we need to add/remove beds
						int oldCapacity = 0;
						using (var cmd = new SQLiteCommand("SELECT Capacity FROM Rooms WHERE RoomNumber = @Room", conn))
						{
							cmd.Parameters.AddWithValue("@Room", room.RoomNumber);
							oldCapacity = Convert.ToInt32(cmd.ExecuteScalar());
						}

						string sql = "UPDATE Rooms SET RoomType = @RoomType, Rate = @Rate, " +
									 "Capacity = @Capacity, Status = @Status " +
									 "WHERE RoomNumber = @RoomNumber AND Status <> 'Occupied';";

						int rows = 0;
						using (var cmd = new SQLiteCommand(sql, conn))
						{
							cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
							cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
							cmd.Parameters.AddWithValue("@Rate", room.Rate);
							cmd.Parameters.AddWithValue("@Capacity", room.Capacity); // NEW
							cmd.Parameters.AddWithValue("@Status", room.Status);

							rows = cmd.ExecuteNonQuery();
						}

						if (rows > 0)
						{
							// Adjust beds if capacity changed
							if (room.Capacity > oldCapacity)
							{
								AddBeds(conn, room.RoomNumber, oldCapacity, room.Capacity);
							}
							else if (room.Capacity < oldCapacity)
							{
								RemoveBeds(conn, room.RoomNumber, room.Capacity);
							}
						}

						trans.Commit();
						return rows;
					}
					catch
					{
						trans.Rollback();
						throw;
					}
				}
			}
		}

		// ==========================================
		// UPDATE STATUS ONLY
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
		// DELETE — Soft delete
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
		// SEARCH
		// ==========================================
		public List<Room> SearchRooms(string keyword)
		{
			List<Room> rooms = new List<Room>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT RoomID, RoomNumber, RoomType, Rate, Capacity, Status FROM Rooms " +
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
								Capacity = Convert.ToInt32(reader["Capacity"]), // NEW
								Status = reader["Status"].ToString()
							});
						}
					}
				}
			}

			return rooms;
		}

		// ==========================================
		// REACTIVATE
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

		// ==========================================
		// HELPERS FOR BED GENERATION
		// ==========================================
		private void GenerateBeds(SQLiteConnection conn, string roomNumber, int capacity)
		{
			for (int i = 0; i < capacity; i++)
			{
				char bedLetter = (char)('A' + i);
				string sql = "INSERT INTO Beds (RoomNumber, BedName, Status) VALUES (@Room, @Bed, 'Available');";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					cmd.Parameters.AddWithValue("@Bed", bedLetter.ToString());
					cmd.ExecuteNonQuery();
				}
			}
		}

		private void AddBeds(SQLiteConnection conn, string roomNumber, int currentCap, int newCap)
		{
			for (int i = currentCap; i < newCap; i++)
			{
				char bedLetter = (char)('A' + i);
				string sql = "INSERT INTO Beds (RoomNumber, BedName, Status) VALUES (@Room, @Bed, 'Available');";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					cmd.Parameters.AddWithValue("@Bed", bedLetter.ToString());
					cmd.ExecuteNonQuery();
				}
			}
		}

		private void RemoveBeds(SQLiteConnection conn, string roomNumber, int newCap)
		{
			// Delete beds with letters greater than the new capacity
			char maxLetter = (char)('A' + newCap - 1);
			string sql = "DELETE FROM Beds WHERE RoomNumber = @Room AND BedName > @MaxBed AND Status = 'Available';";
			using (var cmd = new SQLiteCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Room", roomNumber);
				cmd.Parameters.AddWithValue("@MaxBed", maxLetter.ToString());
				cmd.ExecuteNonQuery();
			}
		}
	}
}