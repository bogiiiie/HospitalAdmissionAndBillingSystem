# 🏥 Admission Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Admission** module is the central module of the Hospital Admission and Billing System. It links a Patient to a Room, marks the room as Occupied, captures the room's current rate, and starts the billing clock. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

This branch also upgrades the earlier search modules with **real Admission data** — the Admission Status column in Patient Info Search and the Occupant column in Patient Room Search are now backed by the `Admissions` table.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-007a | Room Assignment / Admission (Hospital Staff) | ✅ Done |
| US-007b | Override / Edit Admissions (Admin) | ✅ Done |

---

## 📖 US-007a — Room Assignment / Admission (Hospital Staff)

**User Story:**
As Hospital Staff, I want to assign an available room to a patient so that the patient's admission can be recorded.

**Acceptance Criteria:**
- [x] Staff can select a patient already registered in Patient Information Maintenance.
- [x] If the patient is not found, the system displays an alert directing staff to register them first.
- [x] Staff can select only from rooms marked as Available.
- [x] System blocks admission if the patient already has an active (non-discharged) admission.
- [x] System sets the room's status to Occupied and starts the billing period upon confirmation.
- [x] System displays a success message and resets the form for the next admission.

**Development Tasks:**
- [x] Design `AdmissionForm` layout (header + sidebar + card + form fields) — Stephen
- [x] Build `AdmissionForm.Designer.cs` with patient field, room field, date/time, diagnosis, Confirm button — Stephen
- [x] Build `PatientPickerDialog` (modal search dialog for patients) — Stephen
- [x] Build `RoomPickerDialog` (modal search dialog for Available rooms) — Stephen
- [x] Add multi-field search in `PatientPickerDialog` (ID / name / contact) — Stephen
- [x] Add multi-field search in `RoomPickerDialog` (room # / type / rate) — Stephen
- [x] Filter pickers to hide already-admitted patients and non-available rooms — Stephen
- [x] Auto-fill Admission Date/Time on form load — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen
- [x] Sidebar highlight on the current module — Stephen

**Backend / Database Tasks:**
- [x] Create `Model/Admission.cs` — entity with `LockedRate`, `Status`, `AdmittedBy`, etc. — Stephen
- [x] Create `Admissions` table schema — Stephen
- [x] Create `AdmissionRepository` (Add, GetAll, GetActive, GetByCode, GenerateNextCode, HasActiveAdmission, HasAnyAdmission, GetOccupant) — Stephen
- [x] Create `AdmissionController.AddAdmission()` with 8-step validation chain — Stephen
- [x] Auto-generate Admission Code (`ADM-0001`, `ADM-0002`, …) — Stephen
- [x] Lock the room's rate into `LockedRate` at admission time — Stephen
- [x] Update `DatabaseInitializer.cs` to create the `Admissions` table — Stephen
- [x] Add `RoomRepository.UpdateRoomStatus()` (trusted internal method that bypasses the occupied-room lock) — Stephen

**Testing Tasks:**
- [x] Test successful admission (patient + room + diagnosis) — Lynet, Luster
- [x] Test patient picker search (ID / name / contact) — Lynet, Luster
- [x] Test room picker search (room # / type / rate) — Lynet, Luster
- [x] Test that the admitted patient no longer appears in the patient picker — Lynet, Luster
- [x] Test that the occupied room no longer appears in the room picker — Lynet, Luster
- [x] Test that the room becomes Occupied in Room Management after admission — Lynet, Luster
- [x] Test that Patient Info Search shows "Admitted" for the new patient — Lynet, Luster
- [x] Test that Patient Room Search shows the patient name as occupant — Lynet, Luster
- [x] Test validation: missing patient → "Please select a patient." — Lynet, Luster
- [x] Test validation: missing room → "Please select a room." — Lynet, Luster
- [x] Test validation: empty diagnosis → "Diagnosis is required." — Lynet, Luster
- [x] Test validation: patient already admitted → "This patient already has an active admission." — Lynet, Luster
- [x] Test sidebar navigation to and from the module — Lynet, Luster

---

## 📖 US-007b — Override / Edit Admissions (Admin)

**User Story:**
As an Admin, I want to override or edit existing admission records so that I can correct errors made during the admission process.

**Acceptance Criteria:**
- [x] Admin has the same admission capabilities as Staff.
- [x] Admin can edit an existing admission record (e.g., correct room assignment).
- [x] The old room becomes Available and the new room becomes Occupied when the room is changed.
- [x] The new room's current rate is captured as the new locked rate.
- [x] The Admin Override section appears only for Admin users.

**Development Tasks:**
- [x] Add "Admin Override" section in `AdmissionForm` (visible only for Admin) — Stephen
- [x] Build `EditAdmissionForm` (modal for editing an existing admission) — Stephen
- [x] Show patient, current room, admission date (read-only) — Stephen
- [x] Allow editing of diagnosis — Stephen
- [x] Allow selecting a new room via `RoomPickerDialog` — Stephen
- [x] Wire "Edit Admission Record" button to open `EditAdmissionForm` — Stephen

**Backend / Database Tasks:**
- [x] Create `AdmissionController.UpdateAdmission()` — Stephen
- [x] Close the old room's status → Available — Stephen
- [x] Open the new room's status → Occupied — Stephen
- [x] Update `Admissions.RoomNumber`, `Diagnosis`, `LockedRate` — Stephen
- [x] Validate: cannot edit a discharged admission — Stephen
- [x] Validate: new room must be Available — Stephen

**Testing Tasks:**
- [x] Test Admin sees the Admin Override section — Lynet, Luster
- [x] Test Staff does NOT see the Admin Override section — Lynet, Luster
- [x] Test the existing-admission dropdown populates with active admissions — Lynet, Luster
- [x] Test editing the room assignment (old room → Available, new room → Occupied) — Lynet, Luster
- [x] Test updating the diagnosis only (room unchanged) — Lynet, Luster
- [x] Test that Room Management reflects the room swap — Lynet, Luster
- [x] Test that Patient Room Search reflects the new occupant — Lynet, Luster

---

## 💰 Policy B — Split-Rate Billing

This module implements **Policy B** for room billing. Instead of locking a single rate for the entire stay, the system records a **history of room periods** in the `AdmissionRoomHistory` table.

### Why Policy B?

If a patient is admitted to a **Ward (₱800/day)** and later moved to a **Semi-Private (₱1,200/day)**, a single locked rate would either overcharge or undercharge the patient.

| Policy | Calculation | Result |
|---|---|---|
| Policy A (single rate) | New rate × total days | Approximate |
| **Policy B (split rate)** | Sum of (rate × days) per room period | ✅ Accurate |

### How it works

1. **On admission** — a row is inserted into `AdmissionRoomHistory` with the first room's rate and `EndDate = NULL` (open period).
2. **On room change** — the current open period is closed (`EndDate = now`), and a new period is opened for the new room.
3. **On discharge** (future module) — the current open period will be closed.
4. **On billing** (future module) — `AdmissionController.CalculateRoomCharges()` sums `rate × days` across all periods for an admission.

### Example

5-day stay: Ward for 2 days, then Semi-Private for 3 days.

```
Period 1:  Ward 201      ₱800/day  × 2 days = ₱1,600
Period 2:  Semi-Private  ₱1,200/day × 3 days = ₱3,600
─────────────────────────────────────────────────────
Total Room Charges                          = ₱5,200
```

### Why `Admissions.LockedRate` Is Still Kept

`Admissions.LockedRate` is updated to the **current** room's rate on every change. It's used for quick display in the Admission form and Admission Log — it is **not** used for billing. Billing always reads from `AdmissionRoomHistory`.

---

## 🗂️ Solution Structure (Files Added / Modified)

```
HospitalAdmissionAndBillingSystem/
│
├── Model/
│   ├── Admission.cs                    ← NEW
│   └── AdmissionRoomHistory.cs         ← NEW (Policy B)
│
├── BusinessLogic/
│   ├── Controller/
│   │   ├── AdmissionController.cs      ← NEW
│   │   └── RoomController.cs           ← modified (UpdateRoomStatus)
│   └── Repository/
│       ├── AdmissionRepository.cs      ← NEW
│       ├── DatabaseInitializer.cs      ← modified (2 new tables)
│       ├── PatientRepository.cs        ← modified (HasAdmissionHistory now real)
│       └── RoomRepository.cs           ← modified (UpdateRoomStatus)
│
├── DB/
│   ├── Table/
│   │   ├── Admissions.sql              ← NEW (reference only)
│   │   └── AdmissionRoomHistory.sql    ← NEW (reference only)
│   └── PostScript/                     ← (no seed for admissions)
│
└── UI/
    ├── AdmissionForm.cs                ← NEW
    ├── AdmissionForm.Designer.cs       ← NEW
    ├── EditAdmissionForm.cs            ← NEW
    ├── EditAdmissionForm.Designer.cs   ← NEW
    ├── PatientPickerDialog.cs          ← NEW
    ├── PatientPickerDialog.Designer.cs ← NEW
    ├── RoomPickerDialog.cs             ← NEW
    ├── RoomPickerDialog.Designer.cs    ← NEW
    ├── RoomManagementForm.cs           ← modified (sidebar wiring)
    ├── PatientInformationForm.cs       ← modified (sidebar wiring)
    ├── PatientInfoSearchForm.cs        ← modified (sidebar + real Admission Status)
    ├── PatientRoomSearchForm.cs        ← modified (sidebar + real Occupant)
    ├── AdminMenuForm.cs                ← modified (Admission tile)
    └── HospitalStaffMenuForm.cs        ← modified (Admission tile)
```

No changes to `LoginPage`, `AddEditRoomForm`, `AddEditPatientForm`, or `PatientDetailsForm`.

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `Model/Admission.cs` | Blueprint for a single admission record |
| `Model/AdmissionRoomHistory.cs` | Blueprint for one room period within an admission (Policy B) |
| `BusinessLogic/Repository/AdmissionRepository.cs` | All SQL for admissions + room history |
| `BusinessLogic/Controller/AdmissionController.cs` | Validation, business logic, billing helper |
| `UI/AdmissionForm.cs` | Main form — admit a patient + Admin Override section |
| `UI/EditAdmissionForm.cs` | Modal for editing an existing admission (Admin only) |
| `UI/PatientPickerDialog.cs` | Modal search dialog for patients (excludes already-admitted) |
| `UI/RoomPickerDialog.cs` | Modal search dialog for rooms (Available only) |

---

## 🏛️ Architecture Overview

```
+-----------------------------------------------------------+
|                          UI                               |
|  AdmissionForm + EditAdmissionForm                        |
|  PatientPickerDialog + RoomPickerDialog                   |
+---------------------------+-------------------------------+
                            | calls
                            v
+-----------------------------------------------------------+
|                     BusinessLogic                         |
|                                                           |
|   +--------------------+      +---------------------+     |
|   |AdmissionController |----->| AdmissionRepository |     |
|   +---------+----------+      +----------+----------+     |
|             |                            |                |
|             | validates against          | reads/writes   |
|             v                            v                |
|   +--------------------+      +---------------------+     |
|   |PatientController   |      | RoomController      |     |
|   |RoomController      |      | (UpdateRoomStatus)  |     |
|   +--------------------+      +---------------------+     |
+---------------------------+-------------------------------+
                            |
                            v
                    +---------------+
                    |   SQLite      |
                    |  Admissions   |
                    |RoomHistory    |
                    |  Patients     |
                    |  Rooms        |
                    +---------------+
```

---

## 📄 File-by-File Reference

### `Model/Admission.cs`

- **Purpose:** Blueprint for a single hospital stay.
- **Namespace:** `Model`
- **Class:** `public class Admission`

| Type | Name | Description |
|------|------|-------------|
| `int` | `AdmissionID` | Internal auto-increment ID |
| `string` | `AdmissionCode` | Display ID like `ADM-0001` |
| `string` | `PatientCode` | FK to `Patients.PatientCode` |
| `string` | `RoomNumber` | FK to `Rooms.RoomNumber` (current room) |
| `DateTime` | `AdmissionDate` | Date/time admitted |
| `string` | `Diagnosis` | Reason for admission |
| `decimal` | `LockedRate` | **Current** room's rate (kept for display) |
| `string` | `Status` | `Admitted` or `Discharged` |
| `string` | `AdmittedBy` | Username of staff who admitted |
| `DateTime?` | `DischargeDate` | NULL until discharged |
| `string` | `DischargeNotes` | NULL until discharged |
| `DateTime` | `CreatedAt` | Row creation timestamp |

### `Model/AdmissionRoomHistory.cs`

- **Purpose:** Blueprint for one room period within an admission (Policy B).
- **Namespace:** `Model`
- **Class:** `public class AdmissionRoomHistory`

| Type | Name | Description |
|------|------|-------------|
| `int` | `HistoryID` | Internal auto-increment ID |
| `string` | `AdmissionCode` | FK to `Admissions.AdmissionCode` |
| `string` | `RoomNumber` | Room during this period |
| `string` | `RoomType` | Snapshot of the room's type |
| `decimal` | `Rate` | Snapshot of the rate for this period |
| `DateTime` | `StartDate` | When this period began |
| `DateTime?` | `EndDate` | When this period ended (NULL = current) |
| `DateTime` | `CreatedAt` | Row creation timestamp |

### `BusinessLogic/Repository/AdmissionRepository.cs`

- **Purpose:** All SQL for admissions and room history.
- **Namespace:** `BusinessLogic.Repository`
- **Class:** `public class AdmissionRepository`

| Method | Returns | SQL |
|--------|---------|-----|
| `GetAllAdmissions()` | `List<Admission>` | `SELECT * FROM Admissions ORDER BY AdmissionID DESC` |
| `GetActiveAdmissions()` | `List<Admission>` | `SELECT * WHERE Status = 'Admitted'` |
| `GetAdmissionByCode(code)` | `Admission` or null | `SELECT * WHERE AdmissionCode = @Code` |
| `GenerateNextAdmissionCode()` | `string` | Look up last code, increment, format `ADM-000N` |
| `AddAdmission(adm)` | `void` | `INSERT INTO Admissions ...` |
| `UpdateAdmission(adm)` | `void` | `UPDATE Admissions SET RoomNumber, Diagnosis, LockedRate` |
| `HasActiveAdmission(code)` | `bool` | `COUNT(*) WHERE Status = 'Admitted'` |
| `HasAnyAdmission(code)` | `bool` | `COUNT(*)` (any status) |
| `GetOccupant(room)` | `string` or null | `SELECT PatientCode WHERE RoomNumber=@r AND Status='Admitted'` |
| `AddRoomHistory(...)` | `void` | `INSERT INTO AdmissionRoomHistory ...` |
| `CloseCurrentRoomHistory(code, end)` | `void` | `UPDATE ... SET EndDate WHERE EndDate IS NULL` |
| `GetRoomHistory(code)` | `List<AdmissionRoomHistory>` | `SELECT * WHERE AdmissionCode=@c ORDER BY HistoryID` |

### `BusinessLogic/Controller/AdmissionController.cs`

- **Purpose:** Validates input and returns `"OK"` or an error message.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class AdmissionController`

| Method | Validation |
|--------|-----------|
| `GetAllAdmissions()` | passthrough |
| `GetActiveAdmissions()` | passthrough |
| `GetAdmissionByCode(code)` | passthrough |
| `AddAdmission(patient, room, diagnosis, by)` | 8-step validation, then INSERT + room flip + open history |
| `UpdateAdmission(code, newRoom, diagnosis)` | validate + close old period + open new + room swap |
| `GetPatientStatus(code)` | returns `"Admitted"` / `"Discharged"` / `"Not Admitted"` |
| `GetOccupantName(room)` | returns patient full name or `"—"` |
| `CalculateRoomCharges(code, asOf)` | sums `rate × days` per history row (Policy B) |

**Validation chain for `AddAdmission`:**

1. Patient selected? → else "Please select a patient."
2. Patient exists? → else "Patient not found. Please reselect."
3. Patient is active? → else "Patient is inactive and cannot be admitted."
4. No active admission? → else "This patient already has an active admission."
5. Room selected? → else "Please select a room."
6. Room exists? → else "Room not found. Please reselect."
7. Room is Available? → else "Selected room is unavailable. Please choose another room."
8. Diagnosis filled? → else "Diagnosis is required."

### `UI/AdmissionForm.cs`

- **Purpose:** Main admission form — one form, role-aware (Admin sees the Admin Override section).
- **Namespace:** `UI`
- **Class:** `public partial class AdmissionForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `AdmissionForm_Load` | Form opens | Sets user info, auto-fills date, shows Admin Override for Admin only, loads active admissions |
| `btnFindPatient_Click` | Find (patient) | Opens `PatientPickerDialog`, fills the field |
| `btnFindRoom_Click` | Find (room) | Opens `RoomPickerDialog`, fills the field |
| `btnConfirmAdmission_Click` | Confirm | Calls `AdmissionController.AddAdmission()`, shows success or error |
| `ResetForm()` | internal | Clears fields, re-auto-fills date, reloads active admissions |
| `LoadActiveAdmissions()` | internal | Populates the Admin Override dropdown |
| `btnEditAdmission_Click` | Edit | Opens `EditAdmissionForm` for the selected admission |
| `btnMainMenu_Click` / `btnLogout_Click` | Header | Navigate / logout |

### `UI/EditAdmissionForm.cs`

- **Purpose:** Modal for editing an existing admission (Admin only).
- **Namespace:** `UI`
- **Class:** `public partial class EditAdmissionForm : Form`
- **Constructor:** `EditAdmissionForm(Admission admission)`

| Method | Trigger | Action |
|--------|---------|--------|
| `EditAdmissionForm_Load` | Form opens | Loads patient, current room, admission date (read-only); loads diagnosis (editable) |
| `btnFindRoom_Click` | Find Room | Opens `RoomPickerDialog`, fills the "New Room" field |
| `btnSave_Click` | Save | Calls `AdmissionController.UpdateAdmission()` |
| `btnCancel_Click` | Cancel | Closes with `DialogResult.Cancel` |

### `UI/PatientPickerDialog.cs`

- **Purpose:** Modal search dialog for patients.
- **Namespace:** `UI`
- **Class:** `public partial class PatientPickerDialog : Form`

**Properties returned:** `SelectedPatientCode`, `SelectedPatientName`

| Method | Trigger | Action |
|--------|---------|--------|
| `PatientPickerDialog_Load` | Form opens | Sets uniform grid font, runs initial search |
| `RunSearch()` | internal | Searches Active patients, excludes those with active admissions, populates grid |
| `btnSearch_Click` / `txtSearch_KeyDown` | Search | Calls `RunSearch()` |
| `dgvPatients_SelectionChanged` | Selection | Enables Select Patient button |
| `ConfirmSelection()` | Select / double-click | Sets properties, returns `DialogResult.OK` |

### `UI/RoomPickerDialog.cs`

- **Purpose:** Modal search dialog for Available rooms.
- **Namespace:** `UI`
- **Class:** `public partial class RoomPickerDialog : Form`

**Properties returned:** `SelectedRoomNumber`, `SelectedRoomType`, `SelectedRoomRate`

| Method | Trigger | Action |
|--------|---------|--------|
| `RoomPickerDialog_Load` | Form opens | Sets uniform grid font, runs initial search |
| `RunSearch()` | internal | Fetches all rooms, filters to Available only |
| `btnSearch_Click` / `txtSearch_KeyDown` | Search | Calls `RunSearch()` |
| `dgvRooms_SelectionChanged` | Selection | Enables Select Room button |
| `ConfirmSelection()` | Select / double-click | Parses rate, sets properties, returns `DialogResult.OK` |

---

## 🗄️ Database Schema

### Table: `Admissions`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `AdmissionID` | INTEGER | PK AUTOINCREMENT | Internal ID |
| `AdmissionCode` | TEXT | NOT NULL UNIQUE | Display ID: `ADM-0001` |
| `PatientCode` | TEXT | NOT NULL | FK to Patients |
| `RoomNumber` | TEXT | NOT NULL | FK to Rooms (current room) |
| `AdmissionDate` | TEXT | NOT NULL | `yyyy-MM-dd HH:mm:ss` |
| `Diagnosis` | TEXT | NOT NULL | Reason for admission |
| `LockedRate` | REAL | NOT NULL | Current room's rate (display only) |
| `Status` | TEXT | NOT NULL DEFAULT 'Admitted' | `Admitted` / `Discharged` |
| `AdmittedBy` | TEXT | NOT NULL | Username |
| `DischargeDate` | TEXT | | NULL until discharged |
| `DischargeNotes` | TEXT | | NULL until discharged |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row timestamp |

### Table: `AdmissionRoomHistory`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `HistoryID` | INTEGER | PK AUTOINCREMENT | Internal ID |
| `AdmissionCode` | TEXT | NOT NULL | FK to Admissions |
| `RoomNumber` | TEXT | NOT NULL | Room for this period |
| `RoomType` | TEXT | NOT NULL | Snapshot of type |
| `Rate` | REAL | NOT NULL | Snapshot of rate |
| `StartDate` | TEXT | NOT NULL | Period start |
| `EndDate` | TEXT | | NULL = current period |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row timestamp |

**Location at runtime:** `UI/bin/Debug/App_Data/HospitalDB.db`

---

## 🔄 Data Flow

### Admitting a Patient

**Step-by-step flow:**

1. **User** clicks **Find** next to Patient → `PatientPickerDialog` opens
2. **User** selects a patient → `SelectedPatientCode` is returned
3. **User** clicks **Find** next to Room → `RoomPickerDialog` opens
4. **User** selects a room → `SelectedRoomNumber` and rate are returned
5. **User** clicks **Confirm Admission** → `AdmissionForm` calls `AdmissionController.AddAdmission()`
6. **AdmissionController** runs the 8-step validation chain
7. **AdmissionController** calls `AdmissionRepository.GenerateNextAdmissionCode()` → gets `ADM-0001`
8. **AdmissionController** calls `AdmissionRepository.AddAdmission(adm)` → inserts into `Admissions`
9. **AdmissionController** calls `AdmissionRepository.AddRoomHistory(...)` → inserts into `AdmissionRoomHistory` (opens first period)
10. **AdmissionController** calls `RoomRepository.UpdateRoomStatus(room, "Occupied")` → updates `Rooms`
11. **AdmissionController** returns `"OK"` → form shows success message and resets

**Summary:**

```
User → AdmissionForm → AdmissionController → AdmissionRepository → SQLite
                                       ↓
                                       → RoomRepository → SQLite
```

---

### Changing Room (Admin Override)

**Step-by-step flow:**

1. **User** selects an admission from the **Admin Override** dropdown
2. **User** clicks **Edit Admission Record** → `EditAdmissionForm` opens
3. **User** clicks **Find Room** → `RoomPickerDialog` opens
4. **User** selects a new room → `SelectedRoomNumber` is returned
5. **User** clicks **Save Changes** → `EditAdmissionForm` calls `AdmissionController.UpdateAdmission()`
6. **AdmissionController** validates the admission and new room
7. **AdmissionController** calls `AdmissionRepository.CloseCurrentRoomHistory(code, now)` → closes the open period
8. **AdmissionController** calls `AdmissionRepository.AddRoomHistory(...)` → opens a new period for the new room
9. **AdmissionController** calls `RoomRepository.UpdateRoomStatus(oldRoom, "Available")` → frees the old room
10. **AdmissionController** calls `RoomRepository.UpdateRoomStatus(newRoom, "Occupied")` → occupies the new room
11. **AdmissionController** calls `AdmissionRepository.UpdateAdmission(adm)` → updates `RoomNumber`, `Diagnosis`, `LockedRate`
12. **AdmissionController** returns `"OK"` → modal closes, main form refreshes

**Summary:**

```
User → EditAdmissionForm → AdmissionController → AdmissionRepository → SQLite
                                             ↓
                                             → RoomRepository → SQLite
```

---

## 👥 Team Contributions (Admission)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Database (Admissions.sql, AdmissionRoomHistory.sql, DatabaseInitializer update), Backend (Admission.cs, AdmissionRoomHistory.cs, AdmissionRepository.cs, AdmissionController.cs, RoomRepository update, PatientRepository update), UI code-behind (AdmissionForm, EditAdmissionForm, PatientPickerDialog, RoomPickerDialog, sidebar wiring across all forms), Policy B design |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (AdmissionForm.Designer.cs, EditAdmissionForm.Designer.cs, PatientPickerDialog.Designer.cs, RoomPickerDialog.Designer.cs) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-007a Room Assignment / Admission (Hospital Staff)** — Full admission flow with picker dialogs, validation, room status update, and billing lock
- **US-007b Override / Edit Admissions (Admin)** — Admin Override section with room reassignment and history tracking
- **Policy B** — Split-rate billing infrastructure via `AdmissionRoomHistory`
- **Search module upgrades** — Patient Info Search now shows real Admission Status; Patient Room Search now shows real Occupant
- **Patient delete-block** — `HasAdmissionHistory()` now backed by real data
- **Room edit/delete lock** — Occupied rooms locked with tooltip, verified in Room Management

### In Progress

- *(Nothing currently)*

### Not Started

- **US-008** — Admission Log History (Optional)
- **US-009** — Treatment/Billing Breakdown
- **US-010** — Doctor/Nurse Assignment (Optional)
- **US-011a / US-011b** — Billing
- **US-012** — Discharge
- **US-013** — Discharge Summary

---

## 📋 Kanban Board

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
3. **Restore NuGet packages** — right-click solution, then **Restore NuGet Packages**
4. **Set `UI` as Startup Project** — right-click `UI`, then Set as Startup Project
5. Set **Platform target** to **x64** for `UI` and `BusinessLogic`
6. Press **`F5`** to build and run
7. On first run, `DatabaseInitializer.EnsureDatabase()` creates `HospitalDB.db` and seeds Users, Rooms, and Patients
8. Login with `admin01` / `admin123`, open **Admission**, click **Find** to pick a patient

### Optional — Inspect the database

Install **DB Browser for SQLite** from https://sqlitebrowser.org/. Open:

```
HospitalAdmissionAndBillingSystem/UI/bin/Debug/App_Data/HospitalDB.db
```

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/Admission.cs` | Blueprint of an admission row |
| `Model/AdmissionRoomHistory.cs` | Blueprint of a room period (Policy B) |
| `BusinessLogic/Repository/AdmissionRepository.cs` | Runs SQL for admissions + history |
| `BusinessLogic/Controller/AdmissionController.cs` | Validates input, orchestrates room/patient updates, calculates billing |
| `BusinessLogic/Repository/DatabaseInitializer.cs` | Creates the Admissions + AdmissionRoomHistory tables |
| `DB/Table/Admissions.sql` | Documents the Admissions schema |
| `DB/Table/AdmissionRoomHistory.sql` | Documents the room history schema |
| `UI/AdmissionForm.cs` | Main admission form (role-aware) |
| `UI/EditAdmissionForm.cs` | Admin-only modal for editing an admission |
| `UI/PatientPickerDialog.cs` | Modal search for patients |
| `UI/RoomPickerDialog.cs` | Modal search for Available rooms |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.