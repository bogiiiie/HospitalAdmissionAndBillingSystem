using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class PaymentRepository
	{
		private readonly string connectionString;

		public PaymentRepository()
		{
			connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		public void AddPayment(Payment p)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO Payments (AdmissionCode, AmountPaid, PaymentDate, ProcessedBy) 
							   VALUES (@AdmissionCode, @AmountPaid, @PaymentDate, @ProcessedBy);";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@AdmissionCode", p.AdmissionCode);
					cmd.Parameters.AddWithValue("@AmountPaid", p.AmountPaid);
					cmd.Parameters.AddWithValue("@PaymentDate", p.PaymentDate.ToString("yyyy-MM-dd HH:mm:ss"));
					cmd.Parameters.AddWithValue("@ProcessedBy", p.ProcessedBy);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public List<Payment> GetPaymentsByAdmission(string admissionCode)
		{
			List<Payment> list = new List<Payment>();
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Payments WHERE AdmissionCode = @Code ORDER BY PaymentID ASC;";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new Payment
							{
								PaymentID = Convert.ToInt32(reader["PaymentID"]),
								AdmissionCode = reader["AdmissionCode"].ToString(),
								AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
								PaymentDate = DateTime.Parse(reader["PaymentDate"].ToString()),
								ProcessedBy = reader["ProcessedBy"].ToString()
							});
						}
					}
				}
			}
			return list;
		}
	}
}