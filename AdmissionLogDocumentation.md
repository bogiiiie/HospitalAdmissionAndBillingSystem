# 📜 Admission Log History Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Admission Log History** module is a read-only historical viewer for all admissions in the Hospital Admission and Billing System. Both Admin and Hospital Staff can search, filter, and view past and current admissions. There are no edit or delete actions — the module is strictly for reference and tracking. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-008 | View Admission History | ✅ Done |

---

## 📖 US-008 — View Admission History

**User Story:**
As a system user, I want to view a history of all admissions so that I can track who was admitted, when, and by which staff member.

**Acceptance Criteria:**
- [x] Both Admin and Hospital Staff can view and filter all admission records.
- [x] Grid loads all admission records by default, sorted by most recent first.
- [x] User can filter by date range (From / To).
- [x] User can filter by status (All / Admitted / Discharged).
- [x] Search box matches patient name, patient code, admission code, room number, and performed-by username.
- [x] Each record shows which staff member performed the admission.
- [x] Records are read-only — no editing or deleting.
- [x] Double-clicking a record opens a read-only details modal.
- [x] "From" date cannot be later than "To" date.

**Development Tasks:**
- [x] Design `AdmissionLogForm` layout (header + sidebar + toolbar + grid) — Stephen
- [x] Build `AdmissionLogForm.Designer.cs` with From/To pickers, search box, status dropdown, Filter button, grid — Stephen
- [x] Build `AdmissionDetailsDialog` (read-only modal) — Stephen
- [x] Filter by date range (unchecked pickers = no filter) — Stephen
- [x] Multi-field search (patient name, code, admission code, room, performed by) — Stephen
- [x] Filter by status dropdown — Stephen
- [x] Validation: From > To → MessageBox — Stephen
- [x] Double-click row → opens details modal — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen
- [x] Sidebar highlight on the current module — Stephen
- [x] Add Admission Log tile to HospitalStaffMenuForm — Stephen
- [x] Unhide sidebar button for Staff (both roles access this module) — Stephen

**Backend / Database Tasks:**
- [x] Reuse `AdmissionController.GetAllAdmissions()` for the grid — Stephen
- [x] Reuse `AdmissionController.GetAdmissionByCode()` for the details modal — Stephen
- [x] Add `AdmissionController.GetRoomHistory()` passthrough for the details modal — Stephen
- [x] Filtering done in C# on the loaded list — no new SQL needed — Stephen
- [x] Cache patient names to avoid per-row queries — Stephen

**Testing Tasks:**
- [x] Test grid loads all admissions on form open — Lynet, Luster
- [x] Test filter by date range (From only, To only, both) — Lynet, Luster
- [x] Test filter by status (All / Admitted / Discharged) — Lynet, Luster
- [x] Test search by patient name — Lynet, Luster
- [x] Test search by patient code — Lynet, Luster
- [x] Test search by admission code — Lynet, Luster
- [x] Test search by room number — Lynet, Luster
- [x] Test search by performed-by username — Lynet, Luster
- [x] Test validation: From > To → blocked with message — Lynet, Luster
- [x] Test double-click row opens details modal — Lynet, Luster
- [x] Test details modal shows patient, admission info, room history, billing (room charges only) — Lynet, Luster
- [x] Test both Admin and Staff can access the module — Lynet, Luster
- [x] Test sidebar navigation to and from the module — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files

| # | File | Purpose |
|---|------|---------|
| 1 | `UI/AdmissionLogForm.cs` | Main grid form |
| 2 | `UI/AdmissionLogForm.Designer.cs` | Layout |
| 3 | `UI/AdmissionDetailsDialog.cs` | Read-only modal |
| 4 | `UI/AdmissionDetailsDialog.Designer.cs` | Layout |

### Modified Files

| # | File | Change |
|---|------|--------|
| 5 | `UI/RoomManagementForm.cs` | Sidebar wiring |
| 6 | `UI/PatientInformationForm.cs` | Sidebar wiring |
| 7 | `UI/PatientInfoSearchForm.cs` | Sidebar wiring |
| 8 | `UI/PatientRoomSearchForm.cs` | Sidebar wiring |
| 9 | `UI/AdmissionForm.cs` | Sidebar wiring |
| 10 | `UI/AdminMenuForm.cs` | Admission Log tile |
| 11 | `UI/HospitalStaffMenuForm.cs` | Admission Log tile + unhide for Staff |

**No backend changes.** The module reuses existing controllers and repositories:

- `AdmissionController.GetAllAdmissions()`
- `AdmissionController.GetAdmissionByCode()`
- `AdmissionController.GetRoomHistory()` (new passthrough)
- `AdmissionController.CalculateRoomCharges()`
- `PatientController.GetPatientByCode()`

No new tables, no new SQL, no new models.

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `UI/AdmissionLogForm.cs` | Main grid form — displays all admissions with search + filter |
| `UI/AdmissionLogForm.Designer.cs` | Layout: header, sidebar, toolbar, grid |
| `UI/AdmissionDetailsDialog.cs` | Read-only modal showing full admission details + room history |
| `UI/AdmissionDetailsDialog.Designer.cs` | Layout: patient, admission, room history grid, billing summary |

---

## 🏛️ Architecture Overview

The `AdmissionLogForm` calls `AdmissionController`, which delegates to `AdmissionRepository` (and `PatientController` for patient names). Everything is **read-only**.

**Layers involved:**

| Layer | Component | Role |
|-------|-----------|------|
| UI | `AdmissionLogForm` | Grid + filters |
| UI | `AdmissionDetailsDialog` | Read-only details modal |
| BusinessLogic | `AdmissionController` | Read methods, room history, billing calc |
| BusinessLogic | `PatientController` | Patient name lookup |
| Repository | `AdmissionRepository` | SQL for Admissions + AdmissionRoomHistory |
| Repository | `PatientRepository` | SQL for Patients |
| DB | `HospitalDB.db` | SQLite file |

**Call flow:**

```
AdmissionLogForm
     │
     ▼
AdmissionController ──► AdmissionRepository ──► SQLite (Admissions, AdmissionRoomHistory)
     │
     ▼
PatientController ──► PatientRepository ──► SQLite (Patients)
```

---

## 🎨 Form Layout

### `AdmissionLogForm`

**Regions:**

- **Header** (top, 65px): brand, user info, Main Menu button, Logout button
- **Sidebar** (left, 240px): MODULES label + 10 buttons, current module highlighted in blue
- **Content area** (rest): title + subtitle + toolbar + grid card

**Toolbar controls (top of content area):**

| Control | Purpose |
|---------|---------|
| From picker | Optional lower bound on admission date (unchecked = no filter) |
| To picker | Optional upper bound on admission date (unchecked = no filter) |
| Search box | Matches patient name, patient code, admission code, room number, performed-by |
| Status dropdown | `All` / `Admitted` / `Discharged` |
| Filter button | Applies all filters |

**Grid columns:**

| Column | Width | Notes |
|--------|-------|-------|
| Admission Code | 12% | e.g. `ADM-0001` |
| Admit Date | 15% | `MM/dd/yyyy` |
| Patient | 33% | `Last, First` |
| Room | 8% | e.g. `204` |
| Status | 12% | Admitted / Discharged |
| Performed By | 20% | Username |

**Bottom:** `Total Results: N` label, bottom-left of the card.

### `AdmissionDetailsDialog`

**Regions:**

- **Header**: title "Admission Details — ADM-0001"
- **Body** (scrollable):
  - **PATIENT section**: patient code + full name
  - **ADMISSION section**: code, date, status, admitted by, diagnosis
  - **ROOM HISTORY section**: grid with Room #, Type, Rate/Day, From, To
  - **BILLING section**: Room Charges, Treatment (pending), Total (so far)
- **Footer**: Close button

---

## 📄 File-by-File Reference

### `UI/AdmissionLogForm.cs`

- **Purpose:** Main grid view — displays all admissions with search + filter controls.
- **Namespace:** `UI`
- **Class:** `public partial class AdmissionLogForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `AdmissionLogForm_Load` | Form opens | Sets user info, populates status dropdown, wires sidebar, runs initial search |
| `RunSearch()` | internal | Validates date range, fetches all admissions, filters in C#, populates grid |
| `btnFilter_Click` | Filter button | Calls `RunSearch()` |
| `txtSearch_KeyDown` | Enter in search box | Calls `RunSearch()` |
| `dgvAdmissions_CellDoubleClick` | Double-click a row | Opens `AdmissionDetailsDialog` for that admission |
| `btnMainMenu_Click` | Main Menu | Routes to `AdminMenuForm` or `HospitalStaffMenuForm` |
| `btnLogout_Click` | Logout | Confirms → returns to `LoginPage` |

**Filtering logic (inside `RunSearch()`):**

1. **Validation** — if From is checked and To is checked and `From > To` → MessageBox and abort
2. **Fetch** — `AdmissionController.GetAllAdmissions()` (already sorted DESC by AdmissionID)
3. **Cache** — build a `Dictionary<string, string>` of patient names to avoid repeated queries
4. **Filter in C#** — for each admission, apply:
   - Date range (if picked)
   - Status (if not "All")
   - Search keyword (contains, case-insensitive) against patient name, patient code, admission code, room number, performed-by
5. **Populate** — grid rows + `Total Results: N` label

### `UI/AdmissionDetailsDialog.cs`

- **Purpose:** Read-only modal showing full details of one admission, including room history and room charges.
- **Namespace:** `UI`
- **Class:** `public partial class AdmissionDetailsDialog : Form`
- **Constructor:** `AdmissionDetailsDialog(Admission admission)`

| Method | Trigger | Action |
|--------|---------|--------|
| `AdmissionDetailsDialog_Load` | Form opens | Sets uniform grid font, loads patient name, admission info, room history, and room charges |
| `btnClose_Click` | Close button | Closes the modal |

**Billing section note:** Only **Room Charges** are computed (from `AdmissionRoomHistory` via `CalculateRoomCharges`). Treatment charges will populate once the Treatment module (US-009) is built.

---

## 🗄️ Database

**No new tables.** This module reads from:

- `Admissions` — the main records
- `AdmissionRoomHistory` — for room periods in the details modal
- `Patients` — for patient names in the grid

**Location at runtime:** `UI/bin/Debug/App_Data/HospitalDB.db`

---

## 🔄 Data Flow

### Loading the grid

1. User opens `AdmissionLogForm` from the sidebar or a menu tile
2. `AdmissionLogForm_Load` fires
3. Form calls `AdmissionController.GetAllAdmissions()`
4. Repository runs `SELECT * FROM Admissions ORDER BY AdmissionID DESC`
5. For each admission, form looks up patient name via `PatientController.GetPatientByCode()` (cached)
6. Grid is populated; count label updates

### Applying filters

1. User sets From/To dates, types a keyword, or picks a status
2. User clicks **Filter** (or presses Enter in the search box)
3. Form validates date range
4. Form re-fetches all admissions
5. Filters in C# — date range, status, multi-field keyword match
6. Grid is repopulated; count label updates

### Viewing details

1. User double-clicks a row
2. Form extracts the `AdmissionCode`
3. Form calls `AdmissionController.GetAdmissionByCode(code)`
4. Form opens `AdmissionDetailsDialog(admission)`
5. Dialog loads patient, admission info, room history, and computes room charges
6. User clicks Close

---

## 👥 Team Contributions (Admission Log)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | UI (AdmissionLogForm, AdmissionDetailsDialog), code-behind logic, multi-field search, filter validation, sidebar wiring across all forms, menu tile updates |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (AdmissionLogForm.Designer.cs, AdmissionDetailsDialog.Designer.cs) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-008 View Admission History** — Read-only grid with date range, status, and multi-field keyword filtering. Details modal shows patient, admission info, room history (Policy B), and room charges so far. Both Admin and Staff can access.

### In Progress

- *(Nothing currently)*

### Not Started

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

1. Clone the repository
2. Open `HospitalAdmissionAndBillingSystem.slnx` in Visual Studio
3. Restore NuGet packages — right-click solution, then **Restore NuGet Packages**
4. Set `UI` as Startup Project — right-click `UI`, then **Set as Startup Project**
5. Set Platform target to **x64** for `UI` and `BusinessLogic`
6. Press `F5` to build and run
7. Login with `admin01` / `admin123` or `areyes` / `staff123`
8. Click **Admission Log** in the sidebar or menu

### Optional — Inspect the database

Install **DB Browser for SQLite** from https://sqlitebrowser.org/. Open:

```
HospitalAdmissionAndBillingSystem/UI/bin/Debug/App_Data/HospitalDB.db
```

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `UI/AdmissionLogForm.cs` | Main grid view with date range + status + keyword filters |
| `UI/AdmissionLogForm.Designer.cs` | Layout: header, sidebar, toolbar, grid |
| `UI/AdmissionDetailsDialog.cs` | Read-only modal showing full admission details + room history + room charges |
| `UI/AdmissionDetailsDialog.Designer.cs` | Layout for the details modal |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.