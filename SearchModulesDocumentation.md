# 🔍 Search Modules Documentation

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

This branch adds the two search-focused modules to the Hospital Admission and Billing System: **Patient Info Search (US-005)** and **Patient Room Search (US-006)**. Both are read-only lookup screens designed to complement the CRUD modules without duplicating them. They share the same chrome as Room Management and Patient Information — header bar, sidebar, uniform grid styles — and follow the same layered architecture: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-005 | Patient Info Search | ✅ Done |
| US-006 | Patient Room Search | ✅ Done |

---

## 📖 US-005 — Patient Info Search (Admin or Hospital Staff)

**User Story:**
As a system user, I want to search for a patient's record so that I can quickly find their information without scrolling the full list.

**Acceptance Criteria:**
- [x] User can search using the patient's ID, name, or contact number
- [x] Results show Patient ID, Name, Gender, and Admission Status only — no room data
- [x] "No patient records found" shows if there's no match
- [x] Selecting a result opens that patient's full record
- [x] Search is case-insensitive and allows partial matches
- [x] Both Admin and Hospital Staff can access the module

**Development Tasks:**
- [x] Design `PatientInfoSearchForm` layout matching other modules (header + sidebar + toolbar + grid) — Stephen
- [x] Build `PatientInfoSearchForm.Designer.cs` with search box, filters, grid, and View Details button — Stephen
- [x] Implement `RunSearch()` with search keyword + Gender filter + Admission Status filter — Stephen
- [x] Add "Search" button + Enter-key support — Stephen
- [x] Add "No patient records found" empty-state label — Stephen
- [x] Create `PatientDetailsForm` (read-only modal) for the View Details action — Stephen
- [x] Enable View Details button only when a row is selected — Stephen
- [x] Support double-click on a row to open details — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen
- [x] Sidebar highlight on the current module — Stephen

**Backend / Database Tasks:**
- [x] Reuse `PatientController.SearchPatients(keyword, filter)` — Stephen
- [x] Filter results to only Active patients — Stephen
- [x] Add `PatientDetailsForm` reads — uses `PatientController.GetPatientByCode()` — Stephen
- [x] Placeholder Admission Status value "Not Admitted" until the Admission module is built — Stephen
- [x] Admission Status filter dropdown includes 4 options: All / Not Admitted / Admitted / Discharged — Stephen

**Testing Tasks:**
- [x] Test search by ID — Stephen
- [x] Test search by name (partial, case-insensitive) — Stephen
- [x] Test search by contact number — Stephen
- [x] Test Gender filter dropdown — Stephen
- [x] Test Admission Status filter dropdown — Stephen
- [x] Test "No patient records found" empty state — Stephen
- [x] Test View Details opens the read-only modal — Stephen
- [x] Test double-click on a row opens the details modal — Stephen
- [x] Test that inactive patients do not appear in search results — Stephen
- [x] Test sidebar navigation to and from the module — Stephen

---

## 📖 US-006 — Patient Room Search (Admin or Hospital Staff)

**User Story:**
As a system user, I want to check room availability or find what room a patient is in so that I can quickly locate patients or free rooms.

**Acceptance Criteria:**
- [x] User can search by room number, room type, or patient name
- [x] Results show Room Number, Type, Status, and Occupant only — no patient contact or demographic details
- [x] If searching by patient name and the patient is not admitted, the system displays: "Patient is not currently admitted to a room."
- [x] Both Admin and Hospital Staff can access the module
- [x] Deleted rooms are excluded from results

**Development Tasks:**
- [x] Design `PatientRoomSearchForm` layout matching other modules (header + sidebar + toolbar + grid) — Stephen
- [x] Build `PatientRoomSearchForm.Designer.cs` with search box, status filter, and 4-column grid — Stephen
- [x] Implement `RunSearch()` with search keyword + Status filter — Stephen
- [x] Add smart empty-state messages:
  - "Patient is not currently admitted to a room." (when the keyword looks like a name)
  - "No rooms found." (otherwise) — Stephen
- [x] Add "Search" button + Enter-key support — Stephen
- [x] Sidebar highlight on the current module — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen

**Backend / Database Tasks:**
- [x] Reuse `RoomController.GetAllRooms()` and `RoomController.SearchRooms(keyword)` — Stephen
- [x] Filter out Deleted rooms from results — Stephen
- [x] Placeholder Occupant value "—" until the Admission module is built — Stephen
- [x] Detect when the search keyword looks like a name (no digits) to choose the correct empty-state message — Stephen

**Testing Tasks:**
- [x] Test search by room number — Stephen
- [x] Test search by room type — Stephen
- [x] Test search by patient name (shows the "not admitted" message) — Stephen
- [x] Test Status filter dropdown (All / Available / Occupied / Maintenance) — Stephen
- [x] Test that Deleted rooms are hidden — Stephen
- [x] Test "No rooms found." empty state — Stephen
- [x] Test sidebar navigation to and from the module — Stephen

---

## 🗂️ Solution Structure (Files Added / Modified)
HospitalAdmissionAndBillingSystem/
│
├── UI/
│ ├── PatientInfoSearchForm.cs ← NEW
│ ├── PatientInfoSearchForm.Designer.cs ← NEW
│ ├── PatientDetailsForm.cs ← NEW (read-only modal)
│ ├── PatientDetailsForm.Designer.cs ← NEW
│ ├── PatientRoomSearchForm.cs ← NEW
│ ├── PatientRoomSearchForm.Designer.cs ← NEW
│ │
│ ├── RoomManagementForm.cs ← modified (sidebar wiring)
│ ├── PatientInformationForm.cs ← modified (sidebar wiring)
│ ├── AdminMenuForm.cs ← modified (tile)
│ └── HospitalStaffMenuForm.cs ← modified (tile)

text

No new models, no new controllers, no new repositories, no new tables — both modules reuse the existing `PatientController` and `RoomController`.

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `UI/PatientInfoSearchForm.cs` | Search UI for patients: search box, filters, grid, View Details button |
| `UI/PatientInfoSearchForm.Designer.cs` | Layout: header, sidebar, toolbar, grid, details panel |
| `UI/PatientDetailsForm.cs` | Read-only modal that displays a full patient record |
| `UI/PatientDetailsForm.Designer.cs` | Layout: header, three sections (Patient, Guardian, Secondary), Close button |
| `UI/PatientRoomSearchForm.cs` | Search UI for rooms: search box, status filter, grid |
| `UI/PatientRoomSearchForm.Designer.cs` | Layout: header, sidebar, toolbar, grid |

---

## 🏛️ Architecture Overview
┌───────────────────────────────────────────────────────┐
│ UI │
│ PatientInfoSearchForm + PatientDetailsForm │
│ PatientRoomSearchForm │
└──────────────────────┬────────────────────────────────┘
│ calls
▼
┌───────────────────────────────────────────────────────┐
│ BusinessLogic │
│ │
│ ┌────────────────────┐ ┌────────────────────┐ │
│ │ PatientController │ │ RoomController │ │
│ └─────────┬──────────┘ └─────────┬──────────┘ │
│ │ │ │
│ ▼ ▼ │
│ ┌────────────────────┐ ┌────────────────────┐ │
│ │PatientRepository │ │RoomRepository │ │
│ └─────────┬──────────┘ └─────────┬──────────┘ │
└─────────────┼─────────────────────────┼──────────────┘
│ │
▼ ▼
┌───────────────┐ ┌───────────────┐
│ Patients │ │ Rooms │
│ table │ │ table │
└───────────────┘ └───────────────┘

text

Both search forms are **pure read layers** on top of existing controllers. No state is created or modified.

---

## 📄 File-by-File Reference

### `UI/PatientInfoSearchForm.cs`

- **Purpose:** Search UI for finding patients by ID, name, or contact number.
- **Namespace:** `UI`
- **Class:** `public partial class PatientInfoSearchForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `PatientInfoSearchForm_Load` | Form opens | Sets user info, populates filter dropdowns, wires sidebar, runs initial search |
| `RunSearch()` | internal | Fetches patients, applies gender + admission status filters, populates grid |
| `btnSearch_Click` | Search button clicked | Calls `RunSearch()` |
| `txtSearch_KeyDown` | Enter key in search box | Calls `RunSearch()` |
| `cmbGender_SelectedIndexChanged` | Gender filter changed | Calls `RunSearch()` |
| `cmbAdmissionStatus_SelectedIndexChanged` | Status filter changed | Calls `RunSearch()` |
| `dgvSearchResults_SelectionChanged_EnableButton` | Row selection changed | Enables/disables View Details button |
| `dgvSearchResults_CellDoubleClick` | Double-click a row | Opens `PatientDetailsForm` |
| `btnViewDetails_Click` | View Details clicked | Opens `PatientDetailsForm` |
| `btnMainMenu_Click` | Main Menu clicked | Routes to `AdminMenuForm` or `HospitalStaffMenuForm` |
| `btnLogout_Click` | Logout clicked | Confirms → returns to `LoginPage` |

**Admission Status placeholder logic:**
```csharp
// Until the Admission module exists, every patient is shown as "Not Admitted".
string admissionStatus = "Not Admitted";
UI/PatientDetailsForm.cs
Purpose: Read-only modal that shows a patient's full record.

Namespace: UI

Class: public partial class PatientDetailsForm : Form

Constructor: PatientDetailsForm(Patient patient) — pass the patient to display.

Method	Trigger	Action
PatientDetailsForm_Load	Form opens	Sets all label values from the Patient object
btnClose_Click	Close clicked	Closes the modal
Sections displayed:

Patient Information — First/Middle/Last Name, DOB, Gender, Age, Contact, Address, Civil Status, Occupation

Guardian / Emergency Contact — Guardian name, relationship, contact, address, present flag

Secondary Emergency Contact — Emergency name, contact

All fields are read-only labels — no textboxes, no editing.

UI/PatientRoomSearchForm.cs
Purpose: Search UI for finding room availability and locating patients.

Namespace: UI

Class: public partial class PatientRoomSearchForm : Form

Method	Trigger	Action
PatientRoomSearchForm_Load	Form opens	Sets user info, populates status filter, wires sidebar, runs initial search
RunSearch()	internal	Fetches rooms, filters out Deleted, applies status filter, populates grid
btnSearch_Click	Search button clicked	Calls RunSearch()
txtSearch_KeyDown	Enter key in search box	Calls RunSearch()
cmbStatus_SelectedIndexChanged	Status filter changed	Calls RunSearch()
ContainsDigit(string)	internal helper	Determines if the keyword is a name vs. room number
btnMainMenu_Click	Main Menu clicked	Routes to AdminMenuForm or HospitalStaffMenuForm
btnLogout_Click	Logout clicked	Confirms → returns to LoginPage
Occupant placeholder logic:

csharp
// TODO: Replace with real lookup once the Admissions table exists.
// For now, show "—" for every room.
string occupant = "—";
Smart empty state:

csharp
if (rooms.Count == 0)
{
    lblNoResults.Text = keywordLooksLikeName
        ? "Patient is not currently admitted to a room."
        : "No rooms found.";
    lblNoResults.Visible = true;
    dgvRooms.Visible = false;
}
🔄 Data Flow
Searching for a patient
text
User                 UI                    Controller            Repository           SQLite
 │                   │                         │                     │                 │
 │  types keyword ──►│                         │                     │                 │
 │  clicks Search    │  SearchPatients ──────► │                     │                 │
 │                   │                         │  search SQL ───────►│                 │
 │                   │                         │                     │  SELECT ──────►│
 │                   │                         │                     │◄── rows ──────│
 │                   │◄── List<Patient> ────── │                     │                 │
 │                   │  apply gender filter    │                     │                 │
 │                   │  apply status filter    │                     │                 │
 │                   │  populate grid          │                     │                 │
 │  sees results ◄───│                         │                     │                 │
 │  clicks row       │  GetPatientByCode ────► │                     │                 │
 │                   │◄── Patient ──────────── │                     │                 │
 │                   │  opens PatientDetails  │                     │                 │
Searching for a room
text
User                 UI                    Controller            Repository           SQLite
 │                   │                         │                     │                 │
 │  types keyword ──►│                         │                     │                 │
 │  clicks Search    │  SearchRooms ─────────► │                     │                 │
 │                   │                         │  search SQL ───────►│                 │
 │                   │                         │                     │  SELECT ──────►│
 │                   │                         │                     │◄── rows ──────│
 │                   │◄── List<Room> ───────── │                     │                 │
 │                   │  filter out Deleted     │                     │                 │
 │                   │  apply status filter    │                     │                 │
 │                   │  populate grid          │                     │                 │
 │  sees results ◄───│                         │                     │                 │
🗄️ Database
No new tables. Both search modules reuse:

Patients table (created by the Patient Information module)

Rooms table (created by Room Management)

Placeholder columns until the Admission module is built:

PatientInfoSearchForm → Admission Status column shows "Not Admitted" for every patient

PatientRoomSearchForm → Occupant column shows "—" for every room

Both will become dynamic once the Admissions table is created in US-007.

👥 Team Contributions (Search Modules)
Member	GitHub	Contribution
Stephen William De Jesus	@bogiiiie	UI (PatientInfoSearchForm, PatientDetailsForm, PatientRoomSearchForm), code-behind logic, sidebar wiring, testing
Lynet Cielo	@lynet-cielo-disputado	UI Designer (PatientInfoSearchForm.Designer.cs, PatientDetailsForm.Designer.cs, PatientRoomSearchForm.Designer.cs)
Luster Tamanu Mangaliman	@lstrmangaliman-hue	Tester
Neil Jerson Manalo	(pending)	Backend Developer
✅ Progress Tracker
Done
US-005 Patient Info Search — Full search UI, filters, view details

US-006 Patient Room Search — Full search UI, status filter, smart empty states

In Progress
(Nothing currently)

Not Started
US-007a / US-007b — Admission

US-008 — Admission Log History (Optional)

US-009 — Treatment/Billing Breakdown

US-010 — Doctor/Nurse Assignment (Optional)

US-011a / US-011b — Billing

US-012 — Discharge

US-013 — Discharge Summary

📋 Kanban Board
🔗 View Group 4 Kanban Board
🔑 Test Accounts
Role	Username	Password
Admin	admin01	admin123
Hospital Staff	areyes	staff123
Passwords are stored as SHA256 hashes, never in plain text.

🚀 How to Run
Prerequisites
Visual Studio with the .NET desktop development workload

.NET Framework 4.7.2 (or higher)

Steps
Clone the repository

Open HospitalAdmissionAndBillingSystem.slnx in Visual Studio

Restore NuGet packages — right-click solution → Restore NuGet Packages

Set UI as Startup Project — right-click UI → Set as Startup Project

Set Platform target to x64 for UI and BusinessLogic

Press F5 to build and run

On first run, DatabaseInitializer.EnsureDatabase() creates HospitalDB.db and seeds the Users, Rooms, and Patients tables

Login with admin01 / admin123 → open Patient Info Search or Patient Room Search

Optional — Inspect the database
Install DB Browser for SQLite from https://sqlitebrowser.org/. Open:

text
HospitalAdmissionAndBillingSystem/UI/bin/Debug/App_Data/HospitalDB.db
📋 Summary Table — File Purpose in One Line
File	Purpose
UI/PatientInfoSearchForm.cs	Search UI for patients (search + filters + grid + View Details)
UI/PatientInfoSearchForm.Designer.cs	Layout for the patient search screen
UI/PatientDetailsForm.cs	Read-only modal showing a patient's full record
UI/PatientDetailsForm.Designer.cs	Layout for the read-only patient modal
UI/PatientRoomSearchForm.cs	Search UI for rooms (search + status filter + grid)
UI/PatientRoomSearchForm.Designer.cs	Layout for the room search screen
📄 License
This project was developed as part of the BT3101 academic requirements for Group 4.