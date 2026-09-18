// ============================================================
// DatabaseInitializer.cs
// Purpose: Create the SQLite database file and set up its tables
//          the first time the application runs.
//
// Why we need this:
//   - SQLite stores everything in a single .db file.
//   - That file doesn't exist until something creates it.
//   - This class checks if the file exists; if not, it creates
//     the Users table and seeds the two test accounts.
//
// Safe to call every time the app starts:
//   - Uses CREATE TABLE IF NOT EXISTS (won't recreate)
//   - Only seeds users if the table is empty
// ============================================================

using System.Configuration;         // For ConfigurationManager (reads App.config)
using System.Data.SQLite;           // For SQLiteConnection, SQLiteCommand
using System.IO;                    // For File, Directory, Path

namespace BusinessLogic.Repository
{
	/// <summary>
	/// Ensures the SQLite database and required tables exist.
	/// Called once at application startup from Program.cs.
	/// </summary>
	public static class DatabaseInitializer
	{
		// ------------------------------------------------------------
		// EnsureDatabase
		// Public method that Program.cs calls at startup.
		// 1. Reads the connection string from App.config
		// 2. Makes sure the App_Data folder exists
		// 3. Opens the .db file (creating it if it doesn't exist)
		// 4. Creates the Users table if missing
		// 5. Seeds admin01 and areyes if the table is empty
		// ------------------------------------------------------------
		public static void EnsureDatabase()
		{
			// Step 1: Get the connection string that was set in App.config.
			// Example value:
			//   Data Source=|DataDirectory|\App_Data\HospitalDB.db;Version=3;
			string connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;

			// Step 2: Figure out the actual file path on disk.
			// SQLiteConnectionStringBuilder parses the connection string
			// and lets us read the "Data Source" (the .db file path).
			var builder = new SQLiteConnectionStringBuilder(connectionString);
			string dbPath = builder.DataSource;

			// Step 3: Make sure the folder that holds the .db file exists.
			// If App_Data doesn't exist yet, the app can't create the .db file.
			// So we create the folder here.
			string directory = Path.GetDirectoryName(dbPath);
			if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			// Step 4: Open (or create) the SQLite database file.
			// If HospitalDB.db already exists, this just opens it.
			// If it doesn't exist, SQLite creates an empty one.
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();

				// ---- Step 4a: Create the Users table if it doesn't exist ----
				// This SQL matches what's inside DB/Table/Users.sql.
				// It's duplicated here so the app can self-initialize
				// without needing the .sql files at runtime.
				string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        PasswordHash TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        IsActive INTEGER NOT NULL DEFAULT 1,
                        CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
                    );";

				using (var cmd = new SQLiteCommand(createUsersTable, conn))
				{
					cmd.ExecuteNonQuery();  // ExecuteNonQuery for CREATE/INSERT/UPDATE/DELETE
				}

				// ---- Step 4b: Seed the two test accounts if the table is empty ----
				// We only want to insert seed data if the table has no rows.
				// Otherwise we'd duplicate users every time the app starts.
				string countSql = "SELECT COUNT(*) FROM Users;";
				long userCount = 0;

				using (var cmd = new SQLiteCommand(countSql, conn))
				{
					// ExecuteScalar returns the first column of the first row
					// as a single object. We cast it to long (SQLite's integer type).
					userCount = (long)cmd.ExecuteScalar();
				}

				// Only insert if the table is currently empty.
				if (userCount == 0)
				{
					// These hashes match the ones in DB/PostScript/SeedUsers.sql.
					//   admin01  -> admin123
					//   areyes   -> staff123
					string seedUsers = @"
                        INSERT INTO Users (Username, PasswordHash, Role, IsActive) VALUES
                        ('admin01',
                         '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9',
                         'Admin',
                         1),
                        ('areyes',
                         '10176E7B7B24D317ACFCF8D2064CFD2F24E154F7B5A96603077D5EF813D6A6B6',
                         'Hospital Staff',
                         1);";

					using (var cmd = new SQLiteCommand(seedUsers, conn))
					{
						cmd.ExecuteNonQuery();
					}
				}

				// Connection closes automatically when 'using' ends.
			}
		}
	}
}