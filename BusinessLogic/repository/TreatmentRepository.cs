using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class TreatmentRepository
	{
		private readonly string connectionString;

		public TreatmentRepository()
		{
			connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		public void AddTreatment(Treatment t)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO Treatments 
					(AdmissionCode, ServiceName, TreatmentDate, Quantity, UnitCost, TotalCost, RecordedBy)
					VALUES (@AdmissionCode, @ServiceName, @TreatmentDate, @Quantity, @UnitCost, @TotalCost, @RecordedBy);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@AdmissionCode", t.AdmissionCode);
					cmd.Parameters.AddWithValue("@ServiceName", t.ServiceName);
					cmd.Parameters.AddWithValue("@TreatmentDate", t.TreatmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("@Quantity", t.Quantity);
					cmd.Parameters.AddWithValue("@UnitCost", t.UnitCost);
					cmd.Parameters.AddWithValue("@TotalCost", t.TotalCost);
					cmd.Parameters.AddWithValue("@RecordedBy", t.RecordedBy);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public List<Treatment> GetTreatmentsByAdmission(string admissionCode)
		{
			List<Treatment> list = new List<Treatment>();

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Treatments WHERE AdmissionCode = @Code ORDER BY TreatmentID DESC;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new Treatment
							{
								TreatmentID = Convert.ToInt32(reader["TreatmentID"]),
								AdmissionCode = reader["AdmissionCode"].ToString(),
								ServiceName = reader["ServiceName"].ToString(),
								TreatmentDate = DateTime.Parse(reader["TreatmentDate"].ToString()),
								Quantity = Convert.ToInt32(reader["Quantity"]),
								UnitCost = Convert.ToDecimal(reader["UnitCost"]),
								TotalCost = Convert.ToDecimal(reader["TotalCost"]),
								RecordedBy = reader["RecordedBy"].ToString(),
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