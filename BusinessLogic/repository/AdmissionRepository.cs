using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class AdmissionRepository
	{
		private readonly string connectionString;

		public AdmissionRepository()
		{
			connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		// ==========================================
		// READ — Get all admissions (all statuses)
		// ==========================================
		public List<Admission> GetAllAdmissions()
		{
			List<Admission> list = new List<Admission>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Admissions ORDER BY AdmissionID DESC;";

				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
						list.Add(MapReaderToAdmission(reader));
				}
			}

			return list;
		}

		// ==========================================
		// READ — Get only active admissions (Status = 'Admitted')
		// ==========================================
		public List<Admission> GetActiveAdmissions()
		{
			List<Admission> list = new List<Admission>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Admissions WHERE Status = 'Admitted' " +
							 "ORDER BY AdmissionID DESC;";

				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
						list.Add(MapReaderToAdmission(reader));
				}
			}

			return list;
		}

		// ==========================================
		// READ — Get one admission by display code
		// ==========================================
		public Admission GetAdmissionByCode(string admissionCode)
		{
			Admission adm = null;

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Admissions WHERE AdmissionCode = @Code LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);

					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
							adm = MapReaderToAdmission(reader);
					}
				}
			}

			return adm;
		}

		// ==========================================
		// READ — Generate next admission code (ADM-0001, ADM-0002, ...)
		// ==========================================
		public string GenerateNextAdmissionCode()
		{
			string code = "ADM-0001";

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT AdmissionCode FROM Admissions " +
							 "ORDER BY AdmissionID DESC LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					object result = cmd.ExecuteScalar();

					if (result != null && result != DBNull.Value)
					{
						string last = result.ToString();          // e.g. "ADM-0007"
						string numeric = last.Replace("ADM-", "");
						int next = int.Parse(numeric) + 1;
						code = "ADM-" + next.ToString("D4");      // "ADM-0008"
					}
				}
			}

			return code;
		}

		// ==========================================
		// CREATE — Add a new admission
		// ==========================================
		public void AddAdmission(Admission adm)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO Admissions
					(AdmissionCode, PatientCode, RoomNumber, AdmissionDate,
					 Diagnosis, LockedRate, Status, AdmittedBy)
					VALUES
					(@AdmissionCode, @PatientCode, @RoomNumber, @AdmissionDate,
					 @Diagnosis, @LockedRate, @Status, @AdmittedBy);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@AdmissionCode", adm.AdmissionCode);
					cmd.Parameters.AddWithValue("@PatientCode", adm.PatientCode);
					cmd.Parameters.AddWithValue("@RoomNumber", adm.RoomNumber);
					cmd.Parameters.AddWithValue("@AdmissionDate", adm.AdmissionDate.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("@Diagnosis", adm.Diagnosis);
					cmd.Parameters.AddWithValue("@LockedRate", adm.LockedRate);
					cmd.Parameters.AddWithValue("@Status", adm.Status);
					cmd.Parameters.AddWithValue("@AdmittedBy", adm.AdmittedBy);

					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// UPDATE — Edit an existing admission (Admin override)
		// Used to change room assignment and/or diagnosis.
		// ==========================================
		public void UpdateAdmission(Admission adm)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"UPDATE Admissions SET
						RoomNumber  = @RoomNumber,
						Diagnosis   = @Diagnosis,
						LockedRate  = @LockedRate
					WHERE AdmissionCode = @AdmissionCode;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@AdmissionCode", adm.AdmissionCode);
					cmd.Parameters.AddWithValue("@RoomNumber", adm.RoomNumber);
					cmd.Parameters.AddWithValue("@Diagnosis", adm.Diagnosis);
					cmd.Parameters.AddWithValue("@LockedRate", adm.LockedRate);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public void UpdateStaffAssignment(string admissionCode, string doctor, string nurse)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Admissions SET AttendingDoctor = @Doc, AssignedNurse = @Nurse WHERE AdmissionCode = @Code;";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					cmd.Parameters.AddWithValue("@Doc", (object)doctor ?? DBNull.Value);
					cmd.Parameters.AddWithValue("@Nurse", (object)nurse ?? DBNull.Value);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// QUERY — Does this patient have an active admission?
		// ==========================================
		public bool HasActiveAdmission(string patientCode)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT COUNT(*) FROM Admissions " +
							 "WHERE PatientCode = @Code AND Status = 'Admitted';";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					long count = (long)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}

		// ==========================================
		// QUERY — Has this patient EVER been admitted?
		// ==========================================
		public bool HasAnyAdmission(string patientCode)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT COUNT(*) FROM Admissions WHERE PatientCode = @Code;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					long count = (long)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}

		// ==========================================
		// QUERY — Get who is currently in a room (patient code or null)
		// ==========================================
		public string GetOccupant(string roomNumber)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT PatientCode FROM Admissions " +
							 "WHERE RoomNumber = @Room AND Status = 'Admitted' LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Room", roomNumber);
					object result = cmd.ExecuteScalar();

					if (result == null || result == DBNull.Value)
						return null;

					return result.ToString();
				}
			}
		}

		// ==========================================
		// HELPERS
		// ==========================================
		private Admission MapReaderToAdmission(SQLiteDataReader reader)
		{
			return new Admission
			{
				AdmissionID = Convert.ToInt32(reader["AdmissionID"]),
				AdmissionCode = reader["AdmissionCode"].ToString(),
				PatientCode = reader["PatientCode"].ToString(),
				RoomNumber = reader["RoomNumber"].ToString(),
				AdmissionDate = DateTime.Parse(reader["AdmissionDate"].ToString()),
				Diagnosis = reader["Diagnosis"].ToString(),
				LockedRate = Convert.ToDecimal(reader["LockedRate"]),
				Status = reader["Status"].ToString(),
				AdmittedBy = reader["AdmittedBy"].ToString(),
				AttendingDoctor = reader["AttendingDoctor"] == DBNull.Value ? null : reader["AttendingDoctor"].ToString(),
				AssignedNurse = reader["AssignedNurse"] == DBNull.Value ? null : reader["AssignedNurse"].ToString(),
				DischargeDate = reader["DischargeDate"] == DBNull.Value
					? (DateTime?)null
					: DateTime.Parse(reader["DischargeDate"].ToString()),
				DischargeNotes = reader["DischargeNotes"] == DBNull.Value
					? null
					: reader["DischargeNotes"].ToString(),
				CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
			};
		}

		// ==========================================
		// HISTORY — Insert a new room period
		// ==========================================
		public void AddRoomHistory(string admissionCode, string roomNumber,
								   string roomType, decimal rate, DateTime startDate)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO AdmissionRoomHistory
					(AdmissionCode, RoomNumber, RoomType, Rate, StartDate)
					VALUES
					(@AdmissionCode, @RoomNumber, @RoomType, @Rate, @StartDate);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@AdmissionCode", admissionCode);
					cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
					cmd.Parameters.AddWithValue("@RoomType", roomType);
					cmd.Parameters.AddWithValue("@Rate", rate);
					cmd.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// HISTORY — Close the currently-open room period
		// (the one with EndDate IS NULL)
		// ==========================================
		public void CloseCurrentRoomHistory(string admissionCode, DateTime endDate)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"UPDATE AdmissionRoomHistory SET EndDate = @EndDate
							   WHERE AdmissionCode = @Code AND EndDate IS NULL;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					cmd.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// HISTORY — Get all room periods for an admission
		// ==========================================
		public List<AdmissionRoomHistory> GetRoomHistory(string admissionCode)
		{
			List<AdmissionRoomHistory> list = new List<AdmissionRoomHistory>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM AdmissionRoomHistory " +
							 "WHERE AdmissionCode = @Code ORDER BY HistoryID;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
							list.Add(MapReaderToHistory(reader));
					}
				}
			}

			return list;
		}

		// ==========================================
		// HELPERS
		// ==========================================
		private AdmissionRoomHistory MapReaderToHistory(SQLiteDataReader reader)
		{
			return new AdmissionRoomHistory
			{
				HistoryID = Convert.ToInt32(reader["HistoryID"]),
				AdmissionCode = reader["AdmissionCode"].ToString(),
				RoomNumber = reader["RoomNumber"].ToString(),
				RoomType = reader["RoomType"].ToString(),
				Rate = Convert.ToDecimal(reader["Rate"]),
				StartDate = DateTime.Parse(reader["StartDate"].ToString()),
				EndDate = reader["EndDate"] == DBNull.Value
					? (DateTime?)null
					: DateTime.Parse(reader["EndDate"].ToString()),
				CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
			};
		}

		// ==========================================
		// UPDATE — Discharge the patient
		// Updates admission, closes room history, frees the room.
		// ==========================================
		public void DischargePatient(string admissionCode, string roomNumber, DateTime dischargeDate, string notes)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				using (var trans = conn.BeginTransaction())
				{
					try
					{
						// 1. Update Admission
						string sqlAdm = @"UPDATE Admissions SET 
											Status = 'Discharged', 
											DischargeDate = @Date, 
											DischargeNotes = @Notes 
										  WHERE AdmissionCode = @Code;";
						using (var cmd = new SQLiteCommand(sqlAdm, conn))
						{
							cmd.Parameters.AddWithValue("@Code", admissionCode);
							cmd.Parameters.AddWithValue("@Date", dischargeDate.ToString("yyyy-MM-dd HH:mm:ss"));
							cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
							cmd.ExecuteNonQuery();
						}

						// 2. Close Room History
						string sqlHist = @"UPDATE AdmissionRoomHistory SET EndDate = @Date 
										   WHERE AdmissionCode = @Code AND EndDate IS NULL;";
						using (var cmd = new SQLiteCommand(sqlHist, conn))
						{
							cmd.Parameters.AddWithValue("@Code", admissionCode);
							cmd.Parameters.AddWithValue("@Date", dischargeDate.ToString("yyyy-MM-dd HH:mm:ss"));
							cmd.ExecuteNonQuery();
						}

						// 3. Free the Room
						string sqlRoom = "UPDATE Rooms SET Status = 'Available' WHERE RoomNumber = @Room;";
						using (var cmd = new SQLiteCommand(sqlRoom, conn))
						{
							cmd.Parameters.AddWithValue("@Room", roomNumber);
							cmd.ExecuteNonQuery();
						}

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
		// GET — Get the list of discharged admissions
		// ==========================================
		public List<Admission> GetDischargedAdmissions()
		{
			List<Admission> list = new List<Admission>();
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Admissions WHERE Status = 'Discharged' ORDER BY AdmissionID DESC;";
				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
						list.Add(MapReaderToAdmission(reader));
				}
			}
			return list;
		}
	}
}