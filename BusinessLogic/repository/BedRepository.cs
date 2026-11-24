using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class BedRepository
	{
		private readonly string connectionString;

		public BedRepository()
		{
			connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		// ==========================================
		// READ — Get all available beds (for Admission Picker)
		// ==========================================
		public List<Bed> GetAvailableBeds()
		{
			List<Bed> beds = new List<Bed>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"SELECT b.BedID, b.RoomNumber, b.BedName, b.Status 
							   FROM Beds b
							   INNER JOIN Rooms r ON b.RoomNumber = r.RoomNumber
							   WHERE b.Status = 'Available' AND r.Status NOT IN ('Maintenance', 'Deleted')
							   ORDER BY b.RoomNumber, b.BedName;";

				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						beds.Add(new Bed
						{
							BedID = Convert.ToInt32(reader["BedID"]),
							RoomNumber = reader["RoomNumber"].ToString(),
							BedName = reader["BedName"].ToString(),
							Status = reader["Status"].ToString()
						});
					}
				}
			}

			return beds;
		}

		// ==========================================
		// QUERY — Check if a specific bed is available
		// ==========================================
		public bool IsBedAvailable(string roomNumber, string bedName)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT COUNT(*) FROM Beds WHERE RoomNumber = @Room AND BedName = @Bed AND Status = 'Available';";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					cmd.Parameters.AddWithValue("@Bed", bedName);
					long count = (long)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}

		// ==========================================
		// UPDATE — Change a bed's status
		// ==========================================
		public void UpdateBedStatus(string roomNumber, string bedName, string status)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Beds SET Status = @Status WHERE RoomNumber = @Room AND BedName = @Bed;";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Status", status);
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					cmd.Parameters.AddWithValue("@Bed", bedName);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// QUERY — Count how many beds in a room are occupied
		// ==========================================
		public int GetOccupiedBedCount(string roomNumber)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT COUNT(*) FROM Beds WHERE RoomNumber = @Room AND Status = 'Occupied';";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		// ==========================================
		// QUERY — Count how many beds in a room are available
		// ==========================================
		public int GetAvailableBedCount(string roomNumber)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT COUNT(*) FROM Beds WHERE RoomNumber = @Room AND Status = 'Available';";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		// ==========================================
		// READ — Get all beds in a specific room
		// ==========================================
		public List<Bed> GetBedsByRoom(string roomNumber)
		{
			List<Bed> beds = new List<Bed>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT BedID, RoomNumber, BedName, Status FROM Beds WHERE RoomNumber = @Room ORDER BY BedName;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							beds.Add(new Bed
							{
								BedID = Convert.ToInt32(reader["BedID"]),
								RoomNumber = reader["RoomNumber"].ToString(),
								BedName = reader["BedName"].ToString(),
								Status = reader["Status"].ToString()
							});
						}
					}
				}
			}

			return beds;
		}

		// ==========================================
		// READ — Get ALL beds (for search)
		// ==========================================
		public List<Bed> GetAllBeds()
		{
			List<Bed> beds = new List<Bed>();
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT BedID, RoomNumber, BedName, Status FROM Beds ORDER BY RoomNumber, BedName;";
				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						beds.Add(new Bed
						{
							BedID = Convert.ToInt32(reader["BedID"]),
							RoomNumber = reader["RoomNumber"].ToString(),
							BedName = reader["BedName"].ToString(),
							Status = reader["Status"].ToString()
						});
					}
				}
			}
			return beds;
		}
	}
}