using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Model;

namespace BusinessLogic.Repository
{
	public class PatientRepository
	{
		private readonly string connectionString;

		public PatientRepository()
		{
			connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		// ==========================================
		// READ — Get all patients (optionally filtered)
		// filter: "All" / "Active" / "Inactive"
		// ==========================================
		public List<Patient> GetAllPatients(string filter = "Active")
		{
			List<Patient> patients = new List<Patient>();

			string sql = "SELECT * FROM Patients";

			if (filter == "Active")
				sql += " WHERE IsActive = 1";
			else if (filter == "Inactive")
				sql += " WHERE IsActive = 0";

			sql += " ORDER BY PatientCode;";

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SQLiteCommand(sql, conn))
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
						patients.Add(MapReaderToPatient(reader));
				}
			}

			return patients;
		}

		// ==========================================
		// READ — Get one patient by display code (P-0001)
		// ==========================================
		public Patient GetPatientByCode(string patientCode)
		{
			Patient patient = null;

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT * FROM Patients WHERE PatientCode = @Code LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
							patient = MapReaderToPatient(reader);
					}
				}
			}

			return patient;
		}

		// ==========================================
		// READ — Generate next patient code (P-0001, P-0002, ...)
		// ==========================================
		public string GenerateNextPatientCode()
		{
			string code = "P-0001";

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "SELECT PatientCode FROM Patients ORDER BY PatientID DESC LIMIT 1;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					object result = cmd.ExecuteScalar();

					if (result != null && result != DBNull.Value)
					{
						string last = result.ToString();      // e.g. "P-0007"
						string numeric = last.Replace("P-", "");
						int next = int.Parse(numeric) + 1;
						code = "P-" + next.ToString("D4");    // → "P-0008"
					}
				}
			}

			return code;
		}

		// ==========================================
		// CREATE — Add a new patient
		// ==========================================
		public void AddPatient(Patient p)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"INSERT INTO Patients
					(PatientCode, FirstName, MiddleName, LastName, DateOfBirth, Gender,
					 ContactNumber, Address, CivilStatus, Occupation,
					 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress, GuardianPresent,
					 EmergencyContactName, EmergencyContactNumber, IsActive)
					VALUES
					(@PatientCode, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Gender,
					 @ContactNumber, @Address, @CivilStatus, @Occupation,
					 @GuardianName, @GuardianRelationship, @GuardianContact, @GuardianAddress, @GuardianPresent,
					 @EmergencyContactName, @EmergencyContactNumber, 1);";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					AddCommonParameters(cmd, p);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// UPDATE — Edit an existing patient
		// ==========================================
		public void UpdatePatient(Patient p)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = @"UPDATE Patients SET
						FirstName = @FirstName,
						MiddleName = @MiddleName,
						LastName = @LastName,
						DateOfBirth = @DateOfBirth,
						Gender = @Gender,
						ContactNumber = @ContactNumber,
						Address = @Address,
						CivilStatus = @CivilStatus,
						Occupation = @Occupation,
						GuardianName = @GuardianName,
						GuardianRelationship = @GuardianRelationship,
						GuardianContact = @GuardianContact,
						GuardianAddress = @GuardianAddress,
						GuardianPresent = @GuardianPresent,
						EmergencyContactName = @EmergencyContactName,
						EmergencyContactNumber = @EmergencyContactNumber
					WHERE PatientCode = @PatientCode;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					AddCommonParameters(cmd, p);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// DEACTIVATE — Set IsActive = 0 (soft remove)
		// ==========================================
		public void DeactivatePatient(string patientCode)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Patients SET IsActive = 0 WHERE PatientCode = @Code;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// REACTIVATE — Set IsActive = 1 (Admin only)
		// ==========================================
		public void ReactivatePatient(string patientCode)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "UPDATE Patients SET IsActive = 1 WHERE PatientCode = @Code;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// DELETE — Hard delete (only if no history)
		// Returns rows affected.
		// ==========================================
		public int DeletePatient(string patientCode)
		{
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				string sql = "DELETE FROM Patients WHERE PatientCode = @Code;";

				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Code", patientCode);
					return cmd.ExecuteNonQuery();
				}
			}
		}

		// ==========================================
		// HAS HISTORY — Check for admission/billing links
		// ==========================================
		public bool HasAdmissionHistory(string patientCode)
		{
			// Backed by the real Admissions table.
			// Admin permanent-delete will be blocked whenever this returns true.
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
		// SEARCH — Find patients by ID / name / contact
		// ==========================================
		public List<Patient> SearchPatients(string keyword, string filter = "Active")
		{
			List<Patient> patients = new List<Patient>();

			string sql = @"SELECT * FROM Patients
						   WHERE (PatientCode LIKE @K
							  OR FirstName LIKE @K
							  OR LastName LIKE @K
							  OR MiddleName LIKE @K
							  OR ContactNumber LIKE @K)";

			if (filter == "Active")
				sql += " AND IsActive = 1";
			else if (filter == "Inactive")
				sql += " AND IsActive = 0";

			sql += " ORDER BY PatientCode;";

			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@K", "%" + keyword + "%");

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
							patients.Add(MapReaderToPatient(reader));
					}
				}
			}

			return patients;
		}

		// ==========================================
		// HELPERS
		// ==========================================
		private Patient MapReaderToPatient(SQLiteDataReader reader)
		{
			return new Patient
			{
				PatientID = Convert.ToInt32(reader["PatientID"]),
				PatientCode = reader["PatientCode"].ToString(),
				FirstName = reader["FirstName"].ToString(),
				MiddleName = reader["MiddleName"] == DBNull.Value ? "" : reader["MiddleName"].ToString(),
				LastName = reader["LastName"].ToString(),
				DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
				Gender = reader["Gender"].ToString(),
				ContactNumber = reader["ContactNumber"].ToString(),
				Address = reader["Address"] == DBNull.Value ? "" : reader["Address"].ToString(),
				CivilStatus = reader["CivilStatus"] == DBNull.Value ? "" : reader["CivilStatus"].ToString(),
				Occupation = reader["Occupation"] == DBNull.Value ? "" : reader["Occupation"].ToString(),

				GuardianName = reader["GuardianName"] == DBNull.Value ? "" : reader["GuardianName"].ToString(),
				GuardianRelationship = reader["GuardianRelationship"] == DBNull.Value ? "" : reader["GuardianRelationship"].ToString(),
				GuardianContact = reader["GuardianContact"] == DBNull.Value ? "" : reader["GuardianContact"].ToString(),
				GuardianAddress = reader["GuardianAddress"] == DBNull.Value ? "" : reader["GuardianAddress"].ToString(),
				GuardianPresent = Convert.ToInt32(reader["GuardianPresent"]) == 1,

				EmergencyContactName = reader["EmergencyContactName"] == DBNull.Value ? "" : reader["EmergencyContactName"].ToString(),
				EmergencyContactNumber = reader["EmergencyContactNumber"] == DBNull.Value ? "" : reader["EmergencyContactNumber"].ToString(),

				IsActive = Convert.ToInt32(reader["IsActive"]) == 1,
				CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
			};
		}

		private void AddCommonParameters(SQLiteCommand cmd, Patient p)
		{
			cmd.Parameters.AddWithValue("@PatientCode", p.PatientCode);
			cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
			cmd.Parameters.AddWithValue("@MiddleName", (object)p.MiddleName ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@LastName", p.LastName);
			cmd.Parameters.AddWithValue("@DateOfBirth", p.DateOfBirth.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@Gender", p.Gender);
			cmd.Parameters.AddWithValue("@ContactNumber", p.ContactNumber);
			cmd.Parameters.AddWithValue("@Address", (object)p.Address ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@CivilStatus", (object)p.CivilStatus ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@Occupation", (object)p.Occupation ?? DBNull.Value);

			cmd.Parameters.AddWithValue("@GuardianName", (object)p.GuardianName ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@GuardianRelationship", (object)p.GuardianRelationship ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@GuardianContact", (object)p.GuardianContact ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@GuardianAddress", (object)p.GuardianAddress ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@GuardianPresent", p.GuardianPresent ? 1 : 0);

			cmd.Parameters.AddWithValue("@EmergencyContactName", (object)p.EmergencyContactName ?? DBNull.Value);
			cmd.Parameters.AddWithValue("@EmergencyContactNumber", (object)p.EmergencyContactNumber ?? DBNull.Value);
		}
	}
}