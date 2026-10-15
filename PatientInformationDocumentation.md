# 🏥 Patient Information Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Patient Information** module is the entry point of the Hospital Admission and Billing System. Every other module — Admission, Treatment, Billing, Discharge, and both search modules — depends on patients existing here first. It provides full CRUD functionality with role-based access: Admin has full add/edit/delete rights, Hospital Staff has add/edit plus deactivate rights. Built on the same layered architecture as the Login and Room Management modules: **Model → BusinessLogic → DB → UI**.

---

## ✨ Features

- **Create** — Both roles can add a new patient with auto-generated Patient ID (`P-0001`, `P-0002`, ...)
- **Read** — View all patients in a grid (both roles)
- **Update** — Both roles can edit patient details
- **Deactivate** — Staff and Admin can soft-delete a patient (record is hidden but history is preserved)
- **Reactivate** — Admin can bring back a deactivated patient
- **Permanent Delete** — Admin only, and only if the patient has no admission or billing history
- **Live Search** — Filter by Patient ID, name, or contact number as you type
- **Active/Inactive/All Filter** — Dropdown to show only active, only inactive, or all patients
- **Guardian / Emergency Contact** — Separate section with relationship, contact number, and a "present with patient" checkbox
- **Guardian Rules** — Guardian is mandatory for minors and patients unable to provide information
- **Role-Based UI** — Admin sees Edit + Delete; Staff sees Edit + Deactivate. Both see a role-specific note under the grid.
- **Validation** — Required fields, valid DOB (not future), numeric contact of at least 7 digits, guardian rules for minors

Data is persisted in a local SQLite file (`HospitalDB.db`), auto-created on first run and seeded with **50 sample patients** covering every guardian scenario.

---

## 🗂️ Solution Structure (Patient Information Files)

```
HospitalAdmissionAndBillingSystem/
│
├── Model/
│   ├── User.cs
│   ├── Room.cs
│   └── Patient.cs                           ← Patient blueprint
│
├── BusinessLogic/
│   ├── Controller/
│   │   ├── LoginController.cs
│   │   ├── RoomController.cs
│   │   └── PatientController.cs             ← Patient business logic
│   └── Repository/
│       ├── UserRepository.cs
│       ├── RoomRepository.cs
│       ├── PatientRepository.cs             ← Patient data access
│       └── DatabaseInitializer.cs           ← updated for Patients table
│
├── DB/
│   ├── Table/
│   │   ├── Users.sql
│   │   ├── Rooms.sql
│   │   └── Patients.sql                     ← Patients schema
│   └── PostScript/
│       ├── SeedUsers.sql
│       ├── SeedRooms.sql
│       └── SeedPatients.sql                 ← 50 sample patients
│
└── UI/
    ├── LoginPage.cs
    ├── AdminMenuForm.cs
    ├── HospitalStaffMenuForm.cs
    ├── RoomManagementForm.cs
    ├── PatientInformationForm.cs            ← Main list view
    ├── PatientInformationForm.Designer.cs
    ├── AddEditPatientForm.cs                ← Add/Edit dialog
    ├── AddEditPatientForm.Designer.cs
    ├── PostScript/                          ← Linked seed SQL files (copied to bin)
    ├── Program.cs
    └── App.config
```

---

## 📁 Purpose of Each Folder

| Folder | Purpose |
|--------|---------|
| `Model/` | Holds plain data classes. `Patient.cs` defines the patient blueprint plus helper properties (`FullName`, `Age`). |
| `BusinessLogic/Controller/` | Contains `PatientController.cs` — validation and orchestration. |
| `BusinessLogic/Repository/` | Contains `PatientRepository.cs` — runs SQL against SQLite. |
| `DB/Table/` | Contains `Patients.sql` — documents the Patients table schema. |
| `DB/PostScript/` | Contains `SeedPatients.sql` — documents the 50 seed patients. |
| `UI/` | Contains the Windows Forms for Patient Information. |
| `UI/PostScript/` | Linked copies of the seed SQL files, copied to the output folder on build. |
| `UI/App_Data/` | Auto-created at runtime. Stores the SQLite database file. |

---

## 🏛️ Architecture Overview

```
┌──────────────────────────────────────────────┐
│                    UI                        │
│  PatientInformationForm + AddEditPatientForm │
└────────────────────┬─────────────────────────┘
                     │ calls
                     ▼
┌──────────────────────────────────────────────┐
│              BusinessLogic                   │
│                                              │
│  ┌─────────────────────┐  ┌───────────────┐ │
│  │    Controller       │─▶│  Repository   │ │
│  │ (PatientController) │  │(PatientRepo,  │ │
│  │  Validation +       │  │ DatabaseInit.)│ │
│  │  guardian rules     │  └───────┬───────┘ │
│  └─────────────────────┘          │         │
└───────────────────────────────────┼─────────┘
                                    │
                     ┌──────────────┴──────────────┐
                     ▼                             ▼
              ┌─────────────┐              ┌─────────────┐
              │    Model    │              │   SQLite    │
              │ (Patient.cs)│              │   Patients  │
              └─────────────┘              └─────────────┘
```

---

## 📄 File-by-File Reference

### `Model/Patient.cs`

- **Purpose:** Blueprint for a single patient record, plus convenience properties.
- **Namespace:** `Model`
- **Class:** `public class Patient`

| Type | Name | Description |
|------|------|-------------|
| `int` | `PatientID` | Internal auto-increment ID |
| `string` | `PatientCode` | Display ID like `P-0001` |
| `string` | `FirstName` | Patient's first name |
| `string` | `MiddleName` | Optional middle name |
| `string` | `LastName` | Patient's last name |
| `DateTime` | `DateOfBirth` | Date of birth |
| `string` | `Gender` | Male / Female / Other |
| `string` | `ContactNumber` | Primary contact |
| `string` | `Address` | Optional |
| `string` | `CivilStatus` | Optional |
| `string` | `Occupation` | Optional |
| `string` | `GuardianName` | Guardian / emergency contact |
| `string` | `GuardianRelationship` | Self / Parent / Spouse / etc. |
| `string` | `GuardianContact` | Guardian's phone |
| `string` | `GuardianAddress` | Optional |
| `bool` | `GuardianPresent` | Is the guardian with the patient |
| `string` | `EmergencyContactName` | Secondary emergency contact |
| `string` | `EmergencyContactNumber` | Same |
| `bool` | `IsActive` | `true` = active, `false` = deactivated |
| `DateTime` | `CreatedAt` | Row creation timestamp |
| *property* | `FullName` | Computed: `"Last, First Middle"` |
| *property* | `Age` | Computed from `DateOfBirth` |

### `BusinessLogic/Repository/PatientRepository.cs`

- **Purpose:** The only class that talks to SQLite for patient data.
- **Namespace:** `BusinessLogic.Repository`
- **Class:** `public class PatientRepository`

| Method | Returns | SQL |
|--------|---------|-----|
| `GetAllPatients(filter)` | `List<Patient>` | `SELECT * FROM Patients` (+ `WHERE IsActive = 1/0`) |
| `GetPatientByCode(code)` | `Patient` or `null` | `SELECT ... WHERE PatientCode = @Code LIMIT 1` |
| `GenerateNextPatientCode()` | `string` | `SELECT PatientCode FROM Patients ORDER BY PatientID DESC LIMIT 1` → computes next |
| `AddPatient(Patient)` | `void` | `INSERT INTO Patients ...` |
| `UpdatePatient(Patient)` | `void` | `UPDATE Patients SET ... WHERE PatientCode = @Code` |
| `DeactivatePatient(code)` | `void` | `UPDATE Patients SET IsActive = 0 WHERE PatientCode = @Code` |
| `ReactivatePatient(code)` | `void` | `UPDATE Patients SET IsActive = 1 WHERE PatientCode = @Code` |
| `DeletePatient(code)` | `int` | `DELETE FROM Patients WHERE PatientCode = @Code` |
| `HasAdmissionHistory(code)` | `bool` | **Stub for now** — returns `false`. Will check the Admissions table later. |
| `SearchPatients(keyword, filter)` | `List<Patient>` | `SELECT ... WHERE PatientCode/Name/Contact LIKE @K` |

### `BusinessLogic/Controller/PatientController.cs`

- **Purpose:** Validates input and returns `"OK"` or an error message.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class PatientController`

| Method | Validation |
|--------|-----------|
| `GetAllPatients(filter)` | passthrough |
| `GetPatientByCode(code)` | passthrough |
| `SearchPatients(keyword, filter)` | empty keyword → return all |
| `AddPatient(Patient)` | full validation, auto-generate `PatientCode` |
| `UpdatePatient(Patient)` | full validation, patient must exist |
| `DeactivatePatient(code)` | patient must exist and be active |
| `ReactivatePatient(code)` | patient must exist and be inactive |
| `DeletePatient(code)` | must not have admission history |
| `ValidatePatient(Patient)` | private helper — shared by Add and Update |

**Validation rules:**
- First Name and Last Name required
- Date of Birth required, cannot be a future date
- Gender required
- Contact Number required, at least 7 digits
- **Guardian rules:**
  - If patient is a minor (< 18), guardian name + relationship + contact are required, and relationship cannot be `Self`
  - If a guardian name is given, contact is required (unless the default "Self — Patient arrived alone")
- Patient ID is auto-generated (no duplicate IDs possible)

### `DB/Table/Patients.sql`

```sql
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
);
```

### `DB/PostScript/SeedPatients.sql`

Inserts 50 sample patients covering all guardian scenarios:

| Range | Scenario | Count |
|-------|----------|-------|
| P-0001 – P-0010 | Adults with family present | 10 |
| P-0011 – P-0020 | Adults alone (self-guardian) | 10 |
| P-0021 – P-0030 | Minors with parents | 10 |
| P-0031 – P-0040 | Elderly with social worker | 10 |
| P-0041 – P-0045 | Adults with various guardians | 5 |
| P-0046 – P-0050 | Inactive patients (for filter testing) | 5 |

This file is **linked into the UI project** and read at runtime by `DatabaseInitializer`.

### `UI/PatientInformationForm.cs`

- **Purpose:** Main list view — shows all patients in a grid with search + status filter.
- **Namespace:** `UI`
- **Class:** `public partial class PatientInformationForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `PatientInformationForm_Load` | Form opens | Sets user info, filter dropdown, role note, uniform grid font, wires sidebar |
| `LoadPatients()` | internal | Fetches patients, applies filter + search, populates grid |
| `cmbFilter_SelectedIndexChanged` | Filter dropdown changed | Calls `LoadPatients()` |
| `txtSearch_TextChanged` | Search box typed into | Calls `LoadPatients()` (live filter) |
| `dgvPatients_CellPainting` | Grid repaint | Draws Edit + Delete (Admin) or Edit + Deactivate (Staff) buttons |
| `dgvPatients_CellClick` | Actions cell clicked | Opens Edit dialog, or handles Deactivate/Delete/Reactivate |
| `btnAdd_Click` | + Add New Patient clicked | Opens `AddEditPatientForm(null)` |
| `btnMainMenu_Click` | Main Menu clicked | Routes to `AdminMenuForm` or `HospitalStaffMenuForm` based on role |
| `btnLogout_Click` | Logout clicked | Confirms → returns to `LoginPage` |

### `UI/AddEditPatientForm.cs`

- **Purpose:** Modal dialog for adding or editing a single patient.
- **Namespace:** `UI`
- **Class:** `public partial class AddEditPatientForm : Form`
- **Constructor:** Pass `null` for Add mode, or an existing `Patient` for Edit mode.

| Method | Trigger | Action |
|--------|---------|--------|
| `AddEditPatientForm_Load` | Form opens | Populates fields. In Add mode, defaults guardian to "Self — Patient arrived alone". |
| `dtpDOB_ValueChanged` | DOB changed | Auto-ticks the "minor" checkbox if age < 18 |
| `btnSave_Click` | Save clicked | Builds `Patient`, calls `AddPatient()` or `UpdatePatient()`, shows error if validation fails |
| `btnCancel_Click` | Cancel clicked | Returns `DialogResult.Cancel` |

**Form sections:**
1. **Patient Information** — name fields, DOB, gender, contact, address, civil status, occupation
2. **Guardian / Emergency Contact** — checkboxes for "minor" and "unable to provide", guardian fields, "present with patient" checkbox
3. **Secondary Emergency Contact (Optional)** — name and number

---

## 🗄️ Database Schema

**Table:** `Patients`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `PatientID` | INTEGER | PRIMARY KEY AUTOINCREMENT | Internal ID |
| `PatientCode` | TEXT | NOT NULL, UNIQUE | Display ID: `P-0001` |
| `FirstName` | TEXT | NOT NULL | Required |
| `MiddleName` | TEXT | | Optional |
| `LastName` | TEXT | NOT NULL | Required |
| `DateOfBirth` | TEXT | NOT NULL | Stored as `yyyy-MM-dd` |
| `Gender` | TEXT | NOT NULL | Male / Female / Other |
| `ContactNumber` | TEXT | NOT NULL | Min 7 digits |
| `Address` | TEXT | | Optional |
| `CivilStatus` | TEXT | | Optional |
| `Occupation` | TEXT | | Optional |
| `GuardianName` | TEXT | | Default: "Self — Patient arrived alone" |
| `GuardianRelationship` | TEXT | | Self / Parent / Spouse / etc. |
| `GuardianContact` | TEXT | | Guardian's contact |
| `GuardianAddress` | TEXT | | Optional |
| `GuardianPresent` | INTEGER | DEFAULT 0 | 0 = No, 1 = Yes |
| `EmergencyContactName` | TEXT | | Optional |
| `EmergencyContactNumber` | TEXT | | Optional |
| `IsActive` | INTEGER | DEFAULT 1 | 0 = deactivated (soft delete) |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row creation time |

**Location at runtime:** `UI/bin/Debug/App_Data/HospitalDB.db`

---

## 🔄 Data Flow

### Adding a patient

```
User               UI                    Controller            Repository           SQLite
 │                 │                         │                     │                 │
 │  clicks Add ───►│                         │                     │                 │
 │                 │  AddPatient(patient) ─► │                     │                 │
 │                 │                         │  validate ─► error  │                 │
 │                 │                         │  GenerateNextCode ─►│                 │
 │                 │                         │                     │◄── "P-0051" ───│
 │                 │                         │  AddPatient(Room) ─►│                 │
 │                 │                         │                     │  INSERT ──────►│
 │                 │                         │                     │◄── success ───│
 │                 │◄─── "OK" ────────────── │                     │                 │
 │  sees grid ◄────│                         │                     │                 │
```

### Deactivating a patient

```
User                UI                    Controller            Repository           SQLite
 │                  │                         │                     │                 │
 │  clicks           │                         │                     │                 │
 │  Deactivate ─────►│  Deactivate(code) ────► │                     │                 │
 │                  │                         │  GetPatientByCode ─►│                 │
 │                  │                         │◄── Patient ─────────│                 │
 │                  │                         │  check IsActive     │                 │
 │                  │                         │  Deactivate(code) ─►│                 │
 │                  │                         │                     │  UPDATE ──────►│
 │                  │◄─── "OK" ────────────── │                     │                 │
 │  grid refreshes ◄│                         │                     │                 │
```

---

## 👥 Team Contributions (Patient Information)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Database (Patients.sql, SeedPatients.sql), Backend (Patient.cs, PatientRepository.cs, PatientController.cs, DatabaseInitializer update), UI code-behind (PatientInformationForm.cs, AddEditPatientForm.cs), Tester |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (PatientInformationForm.Designer.cs, AddEditPatientForm.Designer.cs) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done
- **US-004a Register/Update Patients (Staff)** — Add/edit with validation, guardian fields, deactivate-only removal
- **US-004b Full Patient Record Management (Admin)** — Same as Staff plus permanent delete (only if no history) and reactivate

### In Progress
- *(Nothing currently)*

### Not Started
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

### [🔗 View Group 4 Kanban Board](https://github.com/users/bogiiiie/projects/4)

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
7. On first run, `DatabaseInitializer.EnsureDatabase()` creates `HospitalDB.db` and seeds the Users, Rooms, and Patients tables
8. Login with `admin01` / `admin123` → open **Patient Information**

### Optional — Inspect the database
Install **DB Browser for SQLite** from https://sqlitebrowser.org/. Open:
```
HospitalAdmissionAndBillingSystem/UI/bin/Debug/App_Data/HospitalDB.db
```

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/Patient.cs` | Blueprint of a patient, plus `FullName` and `Age` helpers |
| `BusinessLogic/Repository/PatientRepository.cs` | Runs SQL CRUD, search, soft-delete, reactivate |
| `BusinessLogic/Controller/PatientController.cs` | Validates patient input (incl. guardian rules for minors) |
| `BusinessLogic/Repository/DatabaseInitializer.cs` | Creates and seeds Patients table (reads from `PostScript/*.sql`) |
| `DB/Table/Patients.sql` | Documents the Patients table schema |
| `DB/PostScript/SeedPatients.sql` | Documents the 50 seed patients |
| `UI/PatientInformationForm.cs` | Main list view (grid + search + filter + role-based actions) |
| `UI/AddEditPatientForm.cs` | Add/Edit dialog with patient + guardian + emergency sections |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.
```
