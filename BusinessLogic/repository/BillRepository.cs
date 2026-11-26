using System;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class BillRepository
	{
		private readonly string connectionString;

		public BillRepository()
		{
			connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		public string GenerateNextBillCode()
		{
			string code = "BILL-0001";
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT BillCode FROM Bills ORDER BY BillID DESC LIMIT 1;";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					object result = cmd.ExecuteScalar();
					if (result != null && result != DBNull.Value)
					{
						string last = result.ToString();
						int next = int.Parse(last.Replace("BILL-", "")) + 1;
						code = "BILL-" + next.ToString("D4");
					}
				}
			}
			return code;
		}

		public Bill GetBillByAdmission(string admissionCode)
		{
			Bill bill = null;
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Bills WHERE AdmissionCode = @Code LIMIT 1;";
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", admissionCode);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							bill = new Bill
							{
								BillID = Convert.ToInt32(reader["BillID"]),
								BillCode = reader["BillCode"].ToString(),
								AdmissionCode = reader["AdmissionCode"].ToString(),
								RoomCharges = Convert.ToDecimal(reader["RoomCharges"]),
								TreatmentCharges = Convert.ToDecimal(reader["TreatmentCharges"]),
								DiscountType = reader["DiscountType"] == DBNull.Value ? "" : reader["DiscountType"].ToString(),
								DiscountValue = Convert.ToDecimal(reader["DiscountValue"]),
								DiscountReason = reader["DiscountReason"] == DBNull.Value ? "" : reader["DiscountReason"].ToString(),
								DiscountComputed = Convert.ToDecimal(reader["DiscountComputed"]),
								TotalDue = Convert.ToDecimal(reader["TotalDue"]),
								AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
								Change = Convert.ToDecimal(reader["Change"]),
								Balance = Convert.ToDecimal(reader["Balance"]), // NEW: Read the remaining balance
								Status = reader["Status"].ToString(),
								ProcessedBy = reader["ProcessedBy"].ToString(),
								CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
							};
						}
					}
				}
			}
			return bill;
		}

		public void SaveBill(Bill b, bool isUpdate)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql;

				if (isUpdate)
				{
					// NEW: Added Balance = @Balance to the UPDATE statement
					sql = @"UPDATE Bills SET 
								RoomCharges = @Room, TreatmentCharges = @Treat,
								DiscountType = @DType, DiscountValue = @DVal, DiscountReason = @DReason, DiscountComputed = @DComp,
								TotalDue = @Total, AmountPaid = @Paid, Change = @Change, Balance = @Balance,
								Status = @Status, ProcessedBy = @By
							WHERE BillCode = @Code;";
				}
				else
				{
					// NEW: Added Balance to the INSERT statement
					sql = @"INSERT INTO Bills 
								(BillCode, AdmissionCode, RoomCharges, TreatmentCharges, 
								 DiscountType, DiscountValue, DiscountReason, DiscountComputed,
								 TotalDue, AmountPaid, Change, Balance, Status, ProcessedBy)
							VALUES 
								(@Code, @Admission, @Room, @Treat,
								 @DType, @DVal, @DReason, @DComp,
								 @Total, @Paid, @Change, @Balance, @Status, @By);";
				}

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", b.BillCode);
					if (!isUpdate) cmd.Parameters.AddWithValue("@Admission", b.AdmissionCode);

					cmd.Parameters.AddWithValue("@Room", b.RoomCharges);
					cmd.Parameters.AddWithValue("@Treat", b.TreatmentCharges);
					cmd.Parameters.AddWithValue("@DType", (object)b.DiscountType ?? DBNull.Value);
					cmd.Parameters.AddWithValue("@DVal", b.DiscountValue);
					cmd.Parameters.AddWithValue("@DReason", (object)b.DiscountReason ?? DBNull.Value);
					cmd.Parameters.AddWithValue("@DComp", b.DiscountComputed);
					cmd.Parameters.AddWithValue("@Total", b.TotalDue);
					cmd.Parameters.AddWithValue("@Paid", b.AmountPaid);
					cmd.Parameters.AddWithValue("@Change", b.Change);
					cmd.Parameters.AddWithValue("@Balance", b.Balance); // NEW: Bind the balance parameter
					cmd.Parameters.AddWithValue("@Status", b.Status);
					cmd.Parameters.AddWithValue("@By", b.ProcessedBy);

					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}