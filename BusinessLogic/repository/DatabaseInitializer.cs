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
		public static void EnsureDatabase()
		{
			// Step 1: Get the connection string from App.config
			string connectionString = ConfigurationManager
				.ConnectionStrings["HospitalDB"].ConnectionString;

			// Step 2: Resolve |DataDirectory| so we can create the folder if missing
			string dataDirectory = AppDomain.CurrentDomain
				.GetData("DataDirectory")?.ToString()
				?? AppDomain.CurrentDomain.BaseDirectory;

			string resolvedConnectionString = connectionString
				.Replace("|DataDirectory|", dataDirectory);

			// Step 3: Find the .db file path and make sure its folder exists
			var builder = new SQLiteConnectionStringBuilder(resolvedConnectionString);
			string dbPath = builder.DataSource;
			string directory = Path.GetDirectoryName(dbPath);
			if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			// Step 4: Open (or create) the SQLite DB and set up tables + seed data
			using (var conn = new SQLiteConnection(connectionString))
			{
				conn.Open();

				// --------------------------------------------------------
				// USERS
				// --------------------------------------------------------
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
					cmd.ExecuteNonQuery();

				long userCount = 0;
				using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users;", conn))
					userCount = (long)cmd.ExecuteScalar();

				if (userCount == 0)
				{
					RunSqlScript(conn, "SeedUsers.sql");
				}

				// --------------------------------------------------------
				// ROOMS
				// --------------------------------------------------------
				string createRoomsTable = @"
					CREATE TABLE IF NOT EXISTS Rooms (
						RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
						RoomNumber TEXT NOT NULL UNIQUE,
						RoomType TEXT NOT NULL,
						Rate REAL NOT NULL,
						Status TEXT NOT NULL DEFAULT 'Available'
					);";

				using (var cmd = new SQLiteCommand(createRoomsTable, conn))
					cmd.ExecuteNonQuery();

				long roomCount = 0;
				using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Rooms;", conn))
					roomCount = (long)cmd.ExecuteScalar();

				if (roomCount == 0)
				{
					RunSqlScript(conn, "SeedRooms.sql");
				}

				// --------------------------------------------------------
				// PATIENTS
				// Added guardian fields per the professor's feedback.
				// IsActive = 0 means "deactivated" (soft removed) — kept
				// so admission/billing history stays intact.
				// --------------------------------------------------------
				string createPatientsTable = @"
					CREATE TABLE IF NOT EXISTS Patients (
						PatientID INTEGER PRIMARY KEY AUTOINCREMENT,
						PatientCode TEXT NOT NULL UNIQUE,
						FirstName TEXT NOT NULL,
						MiddleName TEXT,
						LastName TEXT NOT NULL,
						DateOfBirth TEXT NOT NULL,
						Gender TEXT NOT NULL,
						ContactNumber TEXT NOT NULL,
						Address TEXT,
						CivilStatus TEXT,
						Occupation TEXT,
						GuardianName TEXT,
						GuardianRelationship TEXT,
						GuardianContact TEXT,
						GuardianAddress TEXT,
						GuardianPresent INTEGER NOT NULL DEFAULT 0,
						EmergencyContactName TEXT,
						EmergencyContactNumber TEXT,
						IsActive INTEGER NOT NULL DEFAULT 1,
						CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
					);";

				using (var cmd = new SQLiteCommand(createPatientsTable, conn))
					cmd.ExecuteNonQuery();

				long patientCount = 0;
				using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Patients;", conn))
					patientCount = (long)cmd.ExecuteScalar();

				if (patientCount == 0)
				{
					RunSqlScript(conn, "SeedPatients.sql");
				}

				// --------------------------------------------------------
				// ADMISSIONS
				// Created by the Admission module (US-007).
				// Stores one row per hospital stay.
				// LockedRate captures the room's rate at admission time
				// so later rate changes don't affect this stay's bill.
				// --------------------------------------------------------
				string createAdmissionsTable = @"
					CREATE TABLE IF NOT EXISTS Admissions (
						AdmissionID     INTEGER PRIMARY KEY AUTOINCREMENT,
						AdmissionCode   TEXT NOT NULL UNIQUE,
						PatientCode     TEXT NOT NULL,
						RoomNumber      TEXT NOT NULL,
						AdmissionDate   TEXT NOT NULL,
						Diagnosis       TEXT NOT NULL,
						LockedRate      REAL NOT NULL,
						Status          TEXT NOT NULL DEFAULT 'Admitted',
						AdmittedBy      TEXT NOT NULL,
						DischargeDate   TEXT,
						DischargeNotes  TEXT,
						CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
					);";

				using (var cmd = new SQLiteCommand(createAdmissionsTable, conn))
				{
					cmd.ExecuteNonQuery();
				}

				// --------------------------------------------------------
				// ADMISSION ROOM HISTORY
				// Tracks each room period within an admission so billing
				// can split charges when a patient moves between rooms.
				// The row with EndDate = NULL is the currently active period.
				// --------------------------------------------------------
				string createHistoryTable = @"
					CREATE TABLE IF NOT EXISTS AdmissionRoomHistory (
						HistoryID       INTEGER PRIMARY KEY AUTOINCREMENT,
						AdmissionCode   TEXT NOT NULL,
						RoomNumber      TEXT NOT NULL,
						RoomType        TEXT NOT NULL,
						Rate            REAL NOT NULL,
						StartDate       TEXT NOT NULL,
						EndDate         TEXT,
						CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
					);";

				using (var cmd = new SQLiteCommand(createHistoryTable, conn))
				{
					cmd.ExecuteNonQuery();
				}
			}
		}

		// ------------------------------------------------------------
		// RunSqlScript
		// Reads a .sql file from the PostScript folder next to the .exe
		// and runs it against the given connection.
		//
		// The .sql files are linked from the DB project into the UI
		// project with "Copy if newer", so at runtime they live at
		// <exe folder>/PostScript/<filename>.
		// ------------------------------------------------------------
		private static void RunSqlScript(SQLiteConnection conn, string fileName)
		{
			string baseDir = AppDomain.CurrentDomain.BaseDirectory;
			string path = Path.Combine(baseDir, "PostScript", fileName);

			if (!File.Exists(path))
			{
				throw new FileNotFoundException(
					"SQL seed file not found: " + path +
					"\nMake sure " + fileName +
					" is linked into the UI project and set to 'Copy if newer'.");
			}

			string sql = File.ReadAllText(path);

			using (var cmd = new SQLiteCommand(sql, conn))
			{
				cmd.ExecuteNonQuery();
			}
		}
	}
}