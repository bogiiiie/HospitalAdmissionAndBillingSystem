# 🏥 Hospital Admission and Billing System

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

A Windows Forms application for hospital patient admission and billing. Currently implements the **Login module** with role-based navigation for **Admin** and **Hospital Staff**. Built on a properly separated 4-project solution: **Model → BusinessLogic → DB → UI**.

---

## ✨ Current Features

- **Login** — Authenticate users with username and password (SHA256-hashed passwords)
- **Role-Based Navigation** — Main Menu shows only the modules the logged-in role can access
- **Admin Menu** — Access to all hospital management modules
- **Hospital Staff Menu** — Day-to-day patient-facing modules
- **Logout** — Returns to the login screen with cleared fields
- **Auto Database Setup** — SQLite database is created and seeded on first run

Data is persisted in a local SQLite file (`HospitalDB.db`), auto-created on first run and seeded with **2 test accounts**.

---

## 🎬 Demo

### Login and Role-Based Main Menu

<p align="center">
  <img src="assets/LoginDemo.gif" alt="Login Demo" width="900">
</p>

---

## 🗂️ Solution Structure

```
HospitalAdmissionAndBillingSystem/         (4 projects)
│
├── Model/                                 Class Library
│   └── User.cs
│
├── BusinessLogic/                         Class Library
│   ├── Controller/
│   │   └── LoginController.cs
│   └── Repository/
│       ├── UserRepository.cs
│       └── DatabaseInitializer.cs
│
├── DB/                                    Class Library (scripts only)
│   ├── Table/
│   │   └── Users.sql
│   ├── PostScript/
│   │   └── SeedUsers.sql
│   ├── View/                              (empty for now)
│   └── StoredProc/                        (empty — SQLite has no stored procs)
│
└── UI/                                    Windows Forms Application
    ├── LoginPage.cs
    ├── AdminMenuForm.cs
    ├── HospitalStaffMenuForm.cs
    ├── Program.cs
    ├── App.config
    ├── packages.config
    └── App_Data/                          (auto-created at runtime)
        └── HospitalDB.db
```

---

## 📁 Purpose of Each Folder

| Folder | Purpose |
|--------|---------|
| `Model/` | Holds plain data classes ("blueprints") that describe the entities of the system. Contains no logic — just properties. Example: `User.cs`. |
| `BusinessLogic/` | Contains the application logic — the "brain" of the app. |
| `BusinessLogic/Controller/` | Contains controllers that validate input and coordinate between UI and Repository. |
| `BusinessLogic/Repository/` | Contains repositories that talk directly to the database. Also holds `DatabaseInitializer.cs`. |
| `DB/` | Documentation-only project holding SQL scripts. No compiled code. |
| `DB/Table/` | Contains `CREATE TABLE` scripts documenting the schema. |
| `DB/PostScript/` | Contains seed scripts (`INSERT INTO ...`) that populate tables. |
| `DB/View/` | Reserved for SQL view definitions (currently empty). |
| `DB/StoredProc/` | Reserved for stored procedure scripts (empty — SQLite doesn't support them). |
| `UI/` | The Windows Forms application — the visible interface users interact with. |
| `UI/App_Data/` | Created automatically at runtime. Stores the SQLite database file. |

---

## 🏛️ Architecture Overview

```
┌──────────────────────────────────────────────┐
│                    UI                        │
│           Windows Forms Application          │
│  (LoginPage, AdminMenuForm,                  │
│   HospitalStaffMenuForm, Program.cs)         │
└────────────────────┬─────────────────────────┘
                     │ calls
                     ▼
┌──────────────────────────────────────────────┐
│              BusinessLogic                   │
│                                              │
│  ┌──────────────────┐  ┌─────────────────┐  │
│  │   Controller     │─▶│   Repository    │  │
│  │ (LoginController)│  │ (UserRepository,│  │
│  │  Validation      │  │  DatabaseInit.) │  │
│  └──────────────────┘  └────────┬────────┘  │
└─────────────────────────────────┼───────────┘
                                  │
                     ┌────────────┴────────────┐
                     ▼                         ▼
              ┌─────────────┐          ┌─────────────┐
              │    Model    │          │   SQLite    │
              │  (User.cs)  │          │ HospitalDB  │
              └─────────────┘          └─────────────┘

   ┌──────────────────────────────┐
   │         DB Project           │
   │ (SQL scripts — documentation │
   │  only; schema and seed data) │
   └──────────────────────────────┘
```

---

## 📦 Required References

| Project | Project References | Assembly References | NuGet Package |
|---------|-------------------|--------------------|-----|
| **Model** | — | defaults only | — |
| **BusinessLogic** | `Model` | `System.Configuration`, `System.Data` | `System.Data.SQLite.Core` |
| **DB** | — | — | — |
| **UI** | `BusinessLogic`, `Model` | `System.Configuration`, `System.Windows.Forms`, `System.Drawing` | `System.Data.SQLite.Core` |

---

## 📥 NuGet Packages

| Package | Version | Project(s) | Purpose |
|---------|---------|------------|---------|
| `System.Data.SQLite.Core` | 1.0.119 | `BusinessLogic`, `UI` | Provides `SQLiteConnection`, `SQLiteCommand`, `SQLiteDataReader`, plus the native `SQLite.Interop.dll` |

> ⚠️ **Do NOT install** `Microsoft.Data.Sqlite`, `System.Data.SQLite` (without "Core"), or any `SQLitePCLRaw.*` package — those target other runtimes and cause DLL loading errors on .NET Framework 4.7.2.

**Recommended platform target:** `x64` for both `BusinessLogic` and `UI`.

---

## 📄 File-by-File Reference

### `Model/User.cs`

- **Purpose:** Blueprint for a single user account.
- **Namespace:** `Model`
- **Class:** `public class User`

| Type | Name | Description |
|------|------|-------------|
| `int` | `UserID` | Unique ID (auto-assigned by DB) |
| `string` | `Username` | Login name |
| `string` | `PasswordHash` | SHA256 hash of the user's password |
| `string` | `Role` | `"Admin"` or `"Hospital Staff"` |
| `bool` | `IsActive` | Whether the account is enabled |
| `DateTime` | `CreatedAt` | Timestamp of account creation |

### `BusinessLogic/Repository/DatabaseInitializer.cs`

- **Purpose:** Runs once at startup. Creates the SQLite file and the `Users` table if missing, then seeds the two test accounts if the table is empty.
- **Namespace:** `BusinessLogic.Repository`
- **Class:** `public static class DatabaseInitializer`
- **Method:** `public static void EnsureDatabase()`
- **Called by:** `UI/Program.cs` at startup.

### `BusinessLogic/Repository/UserRepository.cs`

- **Purpose:** The only class that talks to SQLite for user data.
- **Namespace:** `BusinessLogic.Repository`
- **Class:** `public class UserRepository`

| Method | Returns | SQL |
|--------|---------|-----|
| `GetUserByUsername(string)` | `User` or `null` | `SELECT ... FROM Users WHERE Username = @Username LIMIT 1` |

- **Pattern:** Uses `using` blocks to auto-close the connection, and `cmd.Parameters.AddWithValue(...)` to prevent SQL injection.

### `BusinessLogic/Controller/LoginController.cs`

- **Purpose:** Validates login credentials and returns `"Admin"`, `"Hospital Staff"`, or an error message.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class LoginController`

| Method | Purpose |
|--------|---------|
| `Login(string username, string password)` | Validate fields → fetch user → check active → hash & compare passwords → return role |
| `HashPassword(string password)` (static) | Convert plain-text password to SHA256 hash (uppercase hex) |

### `DB/Table/Users.sql`

```sql
CREATE TABLE IF NOT EXISTS Users (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    Role TEXT NOT NULL,
    IsActive INTEGER NOT NULL DEFAULT 1,
    CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
);
```

### `DB/PostScript/SeedUsers.sql`

Inserts two test accounts (`admin01` and `areyes`) with SHA256-hashed passwords. Not executed at runtime — mirrored inside `DatabaseInitializer.cs`.

### `UI/LoginPage.cs`

- **Purpose:** Login screen. Takes username + password, calls `LoginController`, opens the correct menu based on the returned role.
- **Namespace:** `UI`
- **Class:** `public partial class LoginPage : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `btnLogin_Click` | Login button clicked | Calls `controller.Login(...)` → opens `AdminMenuForm` or `HospitalStaffMenuForm` |
| `OnVisibleChanged` | Form becomes visible | Clears textboxes so previous credentials don't linger |
| `lblForgotPassword_LinkClicked_1` | Forgot Password clicked | Shows "contact administrator" message |

### `UI/AdminMenuForm.cs`

- **Purpose:** Menu shown to Admin users.
- **Namespace:** `UI`
- **Class:** `public partial class AdminMenuForm : Form`
- **Constructor:** Takes `LoginPage`, `username`, `role` — uses them for the header bar and logout.
- **Methods:** `AdminMenuForm_Load_1` (sets user info label), `llblLogout_LinkClicked` (returns to login).

### `UI/HospitalStaffMenuForm.cs`

- **Purpose:** Menu shown to Hospital Staff users.
- **Namespace:** `UI`
- **Class:** `public partial class HospitalStaffMenuForm : Form`
- **Constructor:** Same as `AdminMenuForm`.
- **Methods:** Same as `AdminMenuForm`.

### `UI/Program.cs`

- **Purpose:** Application entry point.
- **Namespace:** `UI`
- **Class:** `internal static class Program`
- **Flow:** Enables visual styles → `DatabaseInitializer.EnsureDatabase()` → opens `LoginPage`.

### `UI/App.config`

```xml
<connectionStrings>
    <add name="HospitalDB"
         connectionString="Data Source=|DataDirectory|\App_Data\HospitalDB.db;Version=3;"
         providerName="System.Data.SQLite" />
</connectionStrings>
```

- **Key:** `HospitalDB` — must match the string used in `UserRepository` and `DatabaseInitializer`.

### `UI/packages.config`

- **Purpose:** Records which NuGet packages the project uses, so VS can restore them on build.

---

## 🗄️ Database Schema

**Table:** `Users`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `UserID` | INTEGER | PRIMARY KEY AUTOINCREMENT | Auto-assigned ID |
| `Username` | TEXT | NOT NULL, UNIQUE | Login name |
| `PasswordHash` | TEXT | NOT NULL | SHA256 hash |
| `Role` | TEXT | NOT NULL | `'Admin'` or `'Hospital Staff'` |
| `IsActive` | INTEGER | NOT NULL, DEFAULT 1 | 0 = disabled, 1 = active |
| `CreatedAt` | TEXT | NOT NULL, DEFAULT `datetime('now')` | Timestamp |

**Location at runtime:** `UI/bin/Debug/App_Data/HospitalDB.db`

---

## 🔄 Data Flow

```
User                UI                Controller           Repository          SQLite
 │                  │                     │                    │                 │
 │  enters creds ──►│                     │                    │                 │
 │                  │  Login(...) ───────►│                    │                 │
 │                  │                     │  validate empty ──► error           │
 │                  │                     │  GetUserByUsername►│                 │
 │                  │                     │                    │  SELECT ──────►│
 │                  │                     │                    │◄── User ──────│
 │                  │                     │  hash + compare    │                 │
 │                  │◄─── "Admin" ────────│                    │                 │
 │  sees menu ◄─────│                     │                    │                 │
```

---

## 👥 Team Roles

| Member | GitHub | Role(s) |
|--------|--------|---------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Product Owner + Reviewer + Database Developer + Backend Developer |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UX/UI Designer + Frontend Developer |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Backend Developer |
| Neil Jerson Manalo | (pending collaborator) | Backend Developer |

---

## ✅ Progress Tracker

### Done
- **US-001 Role-Based Navigation** — Main Menu shows different tiles for Admin and Hospital Staff.
- **US-002 Login** — SHA256 password hashing with SQLite database, automatically created on first run.

### In Progress
- *(nothing currently)*

### Not Started
- **US-003a / US-003b** — Room Management
- **US-004a / US-004b** — Patient Information Maintenance
- **US-005** — Patient Info Search
- **US-006** — Patient Room Search
- **US-007a / US-007b** — Admission
- **US-008** — Admission Log History (Optional)
- **US-009** — Treatment/Billing Breakdown
- **US-010** — Doctor/Nurse Assignment (Optional)
- **US-011a / US-011b** — Billing
- **US-012** — Discharge
- **US-013** — Discharge Summary

---

## 📋 Kanban Board

Track the project's tasks and progress:
### [🔗 View Group 4 Kanban Board](https://github.com/users/bogiiiie/projects/3)

---

## 🔑 Test Accounts

| Role | Username | Password |
|------|----------|----------|
| Admin | `admin01` | `admin123` |
| Hospital Staff | `areyes` | `staff123` |

Passwords are stored as **SHA256 hashes**, never in plain text.

---

## 🚀 How to Run

### Prerequisites
- Visual Studio with the **.NET desktop development** workload
- .NET Framework **4.7.2** (or higher)

### Steps
1. **Clone** the repository
2. **Open** `HospitalAdmissionAndBillingSystem.slnx` in Visual Studio
3. **Restore NuGet packages** — right-click solution → **Restore NuGet Packages**
4. **Set `UI` as Startup Project** — right-click `UI` → Set as Startup Project
5. Set **Platform target** to **x64** for `UI` and `BusinessLogic`
6. Press **`F5`** to build and run
7. On first run, `DatabaseInitializer.EnsureDatabase()` creates `HospitalDB.db` and seeds 2 users
8. Login with one of the demo accounts

### Optional — Inspect the database
Install **DB Browser for SQLite** from https://sqlitebrowser.org/. Open:
```
HospitalAdmissionAndBillingSystem/UI/bin/Debug/App_Data/HospitalDB.db
```

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/User.cs` | Blueprint of a user account |
| `BusinessLogic/Repository/DatabaseInitializer.cs` | Creates DB and seeds users on first run |
| `BusinessLogic/Repository/UserRepository.cs` | Reads user data from SQLite |
| `BusinessLogic/Controller/LoginController.cs` | Validates login, hashes passwords |
| `DB/Table/Users.sql` | Documents the Users table schema |
| `DB/PostScript/SeedUsers.sql` | Documents the seed data |
| `UI/LoginPage.cs` | Login form |
| `UI/AdminMenuForm.cs` | Admin menu |
| `UI/HospitalStaffMenuForm.cs` | Hospital Staff menu |
| `UI/Program.cs` | Entry point |
| `UI/App.config` | SQLite connection string |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.
