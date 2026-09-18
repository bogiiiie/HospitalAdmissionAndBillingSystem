// ============================================================
// UserRepository.cs
// Purpose: Handles all database operations for the Users table.
// This is the ONLY file in the app that talks to SQLite for user data.
// No other class should open the database directly.
// ============================================================

using System;                       // Gives us Convert, DateTime, etc.
using System.Configuration;         // Gives us ConfigurationManager (reads App.config)
using System.Data.SQLite;           // Gives us SQLiteConnection, SQLiteCommand, SQLiteDataReader
using Model;                        // Gives us the User class from the Model project

namespace BusinessLogic.Repository
{
	/// <summary>
	/// Repository class for the Users table.
	/// Its single job: fetch user data from the SQLite database.
	/// </summary>
	public class UserRepository
	{
		// The connection string is the "address" of the database file.
		// It's read once (in the constructor) and reused for all methods.
		// 'readonly' means: set once, never changed after.
		private readonly string connectionString;

		// ------------------------------------------------------------
		// CONSTRUCTOR
		// Runs automatically when someone writes: new UserRepository()
		// ------------------------------------------------------------
		public UserRepository()
		{
			// Reads the entry named "HospitalDB" from the <connectionStrings>
			// section of App.config and stores its value here.
			// Example value:
			//   Data Source=|DataDirectory|\App_Data\HospitalDB.db;Version=3;
			connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
		}

		// ------------------------------------------------------------
		// GetUserByUsername
		// Input:  a username (e.g., "admin01")
		// Output: a filled User object if found, or null if not found
		// Purpose: Look up a user in the Users table by their username.
		//          Used by LoginController during login.
		// ------------------------------------------------------------
		public User GetUserByUsername(string username)
		{
			// We start with 'null'. If we find a user, we'll replace it.
			// If we never find one, we return null to the caller.
			User user = null;

			// 'using' ensures the connection is closed/disposed automatically
			// when we exit this block, even if an error occurs.
			using (var conn = new SQLiteConnection(connectionString))
			{
				// Open the connection to the HospitalDB.db file.
				// Nothing works until this line runs.
				conn.Open();

				// The SQL query:
				//   - Select all the columns we need from Users
				//   - Match the row where Username equals our parameter
				//   - LIMIT 1: only return the first match (usernames are unique)
				//
				// Why '@Username' and not the literal value?
				//   To prevent SQL injection. The parameter is treated as
				//   text, not code. This is the safe way to write SQL in C#.
				string sql = "SELECT UserID, Username, PasswordHash, Role, IsActive, CreatedAt " +
							 "FROM Users WHERE Username = @Username LIMIT 1;";

				// Create a command object that will carry this SQL to SQLite.
				// 'conn' tells it which database to run against.
				// 'using' cleans it up when done.
				using (var cmd = new SQLiteCommand(sql, conn))
				{
					// Fill in the @Username placeholder with the actual value.
					// After this line, SQLite will see: WHERE Username = 'admin01'
					cmd.Parameters.AddWithValue("@Username", username);

					// ExecuteReader runs the query and gives us a cursor (reader)
					// pointing just before the first result row.
					using (var reader = cmd.ExecuteReader())
					{
						// Move the cursor to the first row.
						// Read() returns:
						//   true  -> a matching row exists
						//   false -> no matching rows found
						if (reader.Read())
						{
							// Build a User object and fill it from the row's columns.
							user = new User
							{
								// reader["ColumnName"] gets the value of that column
								// from the current row. We convert each to the
								// correct C# type.

								// UserID is an INTEGER in the DB -> convert to int
								UserID = Convert.ToInt32(reader["UserID"]),

								// Text columns -> convert to string
								Username = reader["Username"].ToString(),
								PasswordHash = reader["PasswordHash"].ToString(),
								Role = reader["Role"].ToString(),

								// SQLite stores booleans as 0 (false) or 1 (true).
								// We convert 1 -> true, anything else -> false.
								IsActive = Convert.ToInt32(reader["IsActive"]) == 1,

								// CreatedAt is stored as text (e.g., "2026-09-18 10:00:00").
								// Parse it into a real DateTime object.
								CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
							};
						}
						// If reader.Read() returns false, 'user' stays null.
						// That's fine — the caller can check for null.
					}
				}
				// When this 'using' block ends, the connection closes automatically.
			}

			// Return either the filled User object or null if not found.
			return user;
		}

		// ------------------------------------------------------------
		// FUTURE METHODS (for reference - not yet implemented)
		// ------------------------------------------------------------
		// public void AddUser(User user)          { /* INSERT INTO Users ... */ }
		// public void UpdateUser(User user)       { /* UPDATE Users SET ... */ }
		// public void DeactivateUser(int userId)  { /* UPDATE Users SET IsActive = 0 ... */ }
		// public bool UsernameExists(string u)    { /* SELECT COUNT(*) FROM Users ... */ }
	}
}