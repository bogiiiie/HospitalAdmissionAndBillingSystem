using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class StaffAssignmentRepository
	{
		private readonly string connectionString;

		public StaffAssignmentRepository()
		{
			connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		public void AddHistory(string admissionCode, string role, string staffName, string reason)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO StaffAssignmentHistory 
					(AdmissionCode, Role, StaffName, AssignedDate, Reason)
					VALUES (@Code, @Role, @Name, @Date, @Reason);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					cmd.Parameters.AddWithValue("@Role", role);
					cmd.Parameters.AddWithValue("@Name", staffName);
					cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("@Reason", (object)reason ?? DBNull.Value);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public List<StaffAssignment> GetHistoryByAdmission(string admissionCode)
		{
			List<StaffAssignment> list = new List<StaffAssignment>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM StaffAssignmentHistory WHERE AdmissionCode = @Code ORDER BY AssignedDate DESC;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new StaffAssignment
							{
								HistoryID = Convert.ToInt32(reader["HistoryID"]),
								AdmissionCode = reader["AdmissionCode"].ToString(),
								Role = reader["Role"].ToString(),
								StaffName = reader["StaffName"].ToString(),
								AssignedDate = DateTime.Parse(reader["AssignedDate"].ToString()),
								Reason = reader["Reason"] == DBNull.Value ? "" : reader["Reason"].ToString(),
								CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
							});
						}
					}
				}
			}
			return list;
		}
	}
}