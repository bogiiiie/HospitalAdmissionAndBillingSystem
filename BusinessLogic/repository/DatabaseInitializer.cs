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

using System;                       // For AppDomain
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
		// 2. Resolves |DataDirectory| to a real path
		// 3. Makes sure the App_Data folder exists
		// 4. Opens the .db file (creating it if it doesn't exist)
		// 5. Creates the Users table if missing
		// 6. Seeds admin01 and areyes if the table is empty
		// ------------------------------------------------------------
		public static void EnsureDatabase()
		{
			// Step 1: Get the connection string that was set in App.config.
			// Example value:
			//   Data Source=|DataDirectory|\App_Data\HospitalDB.db;Version=3;
			string connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;

			// Step 2: Resolve |DataDirectory| manually.
			// .NET replaces this placeholder only when OPENING a connection.
			// Since we need the actual file path (to create the folder),
			// we resolve it here ourselves.
			//
			// If |DataDirectory| isn't set (unusual), fall back to the
			// application's base directory.
			string dataDirectory = AppDomain.CurrentDomain
				.GetData("DataDirectory")?.ToString()
				?? AppDomain.CurrentDomain.BaseDirectory;

			string resolvedConnectionString = connectionString
				.Replace("|DataDirectory|", dataDirectory);

			// Step 3: Parse the RESOLVED connection string to get the file path.
			// The unresolved version still has "|DataDirectory|" which
			// Path.GetDirectoryName can't handle.
			var builder = new SQLiteConnectionStringBuilder(resolvedConnectionString);
			string dbPath = builder.DataSource;

			// Step 4: Make sure the folder that holds the .db file exists.
			// If App_Data doesn't exist yet, the app can't create the .db file.
			string directory = Path.GetDirectoryName(dbPath);
			if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			// Step 5: Open (or create) the SQLite database file.
			// We use the ORIGINAL connection string here because SQLite
			// knows how to resolve |DataDirectory| on its own.
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();

				// ---- 5a: Create the Users table if it doesn't exist ----
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
					cmd.ExecuteNonQuery();
				}

				// ---- 5b: Seed the two test accounts if the table is empty ----
				long userCount = 0;
				string countSql = "SELECT COUNT(*) FROM Users;";

				using (var cmd = new SQLiteCommand(countSql, conn))
				{
					userCount = (long)cmd.ExecuteScalar();
				}

				if (userCount == 0)
				{
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
			}
		}
	}
}