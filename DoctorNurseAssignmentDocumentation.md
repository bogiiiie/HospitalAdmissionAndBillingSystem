# 👨‍⚕️ Doctor / Nurse Assignment Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Doctor / Nurse Assignment** module allows Admins to update the attending medical staff for an admitted patient. It maintains a permanent audit trail of all assignments and shift changes. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-010 | Reassign Doctor/Nurse (Admin) | ✅ Done |

---

## 📖 US-010 — Reassign Doctor/Nurse

**User Story:**
As an Admin, I want to reassign a patient's doctor or nurse so that staffing changes during a patient's stay are reflected in the system.

**Acceptance Criteria:**
- [x] Admin can select an active admission and choose a new doctor and/or nurse.
- [x] System updates the admission record with the new assignment.
- [x] Reassignment cannot be performed on a discharged admission.
- [x] System maintains a permanent audit trail (history) of all assignments.
- [x] The module is strictly Admin-only; Hospital Staff cannot access it.

**Development Tasks:**
- [x] Design `DoctorNurseAssignmentForm` layout (header + sidebar + admission picker + current assignment + update panel + history grid) — Stephen
- [x] Build `DoctorNurseAssignmentForm.Designer.cs` with textboxes for New Doctor, New Nurse, Reason, and an Update button — Stephen
- [x] Wire `AdmissionPickerDialog` to select the active admission — Stephen
- [x] Display the current Doctor and Nurse for the selected admission — Stephen
- [x] Display the `StaffAssignmentHistory` in a data grid — Stephen
- [x] Role-based UI: Ensure only Admin sees the sidebar link and menu tile — Stephen
- [x] Update `AdmissionDetailsDialog` to display the current Doctor/Nurse and include Treatment charges in the Billing section — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen

**Backend / Database Tasks:**
- [x] Create `Model/StaffAssignment.cs` — entity for the audit trail — Stephen
- [x] Update `Model/Admission.cs` to include `AttendingDoctor` and `AssignedNurse` properties — Stephen
- [x] Create `StaffAssignmentHistory` table schema — Stephen
- [x] Add `AttendingDoctor` and `AssignedNurse` columns to the `Admissions` table schema — Stephen
- [x] Create `StaffAssignmentRepository.cs` (AddHistory, GetHistoryByAdmission) — Stephen
- [x] Create `StaffAssignmentController.cs` with validation (block discharged admissions, require at least one field to change) — Stephen
- [x] Update `AdmissionRepository.cs` to save the current staff (`UpdateStaffAssignment`) and map the new columns — Stephen
- [x] Update `DatabaseInitializer.cs` to create the new tables and columns — Stephen

**Testing Tasks:**
- [x] Test Admin sees the module in sidebar and menu — Lynet, Luster
- [x] Test Staff does NOT see the module — Lynet, Luster
- [x] Test updating only the Doctor — Lynet, Luster
- [x] Test updating only the Nurse — Lynet, Luster
- [x] Test updating both and providing a reason — Lynet, Luster
- [x] Test history grid populates with timestamps and reasons — Lynet, Luster
- [x] Test validation: cannot update without changing at least one field — Lynet, Luster
- [x] Test validation: cannot update a discharged admission — Lynet, Luster
- [x] Test that `AdmissionDetailsDialog` shows the newly assigned staff — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files

| # | File | Purpose |
|---|------|---------|
| 1 | `Model/StaffAssignment.cs` | Blueprint for a staff assignment history row |
| 2 | `BusinessLogic/Repository/StaffAssignmentRepository.cs` | SQL for the history table |
| 3 | `BusinessLogic/Controller/StaffAssignmentController.cs` | Validation and business logic |
| 4 | `UI/DoctorNurseAssignmentForm.cs` | Main UI logic |
| 5 | `UI/DoctorNurseAssignmentForm.Designer.cs` | Layout for the assignment form |

### Modified Files

| # | File | Change |
|---|------|--------|
| 6 | `Model/Admission.cs` | Added `AttendingDoctor` and `AssignedNurse` |
| 7 | `BusinessLogic/Repository/AdmissionRepository.cs` | Added `UpdateStaffAssignment` and updated mapping |
| 8 | `BusinessLogic/Repository/DatabaseInitializer.cs` | Added new table and updated `Admissions` schema |
| 9 | `UI/AdmissionDetailsDialog.cs` | Display staff and calculate treatment charges |
| 10 | `UI/AdmissionDetailsDialog.Designer.cs` | Added labels for staff |
| 11 | `UI/RoomManagementForm.cs` | Sidebar wiring (Admin only) |
| 12 | `UI/PatientInformationForm.cs` | Sidebar wiring (Admin only) |
| 13 | `UI/PatientInfoSearchForm.cs` | Sidebar wiring (Admin only) |
| 14 | `UI/PatientRoomSearchForm.cs` | Sidebar wiring (Admin only) |
| 15 | `UI/AdmissionForm.cs` | Sidebar wiring (Admin only) |
| 16 | `UI/AdmissionLogForm.cs` | Sidebar wiring (Admin only) |
| 17 | `UI/TreatmentBillingForm.cs` | Sidebar wiring (Admin only) |
| 18 | `UI/AdminMenuForm.cs` | Tile wired |

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `Model/StaffAssignment.cs` | Stores the timestamp, role, name, and reason for every assignment change |
| `StaffAssignmentRepository.cs` | Inserts and retrieves records from `StaffAssignmentHistory` |
| `StaffAssignmentController.cs` | Validates active admissions and orchestrates the dual-write (update current staff + insert history) |
| `UI/DoctorNurseAssignmentForm.cs` | Allows Admin to pick an admission, view history, and reassign staff |

---

## 🏛️ Architecture Overview

```
DoctorNurseAssignmentForm
     │
     ▼
StaffAssignmentController ──► StaffAssignmentRepository ──► SQLite (StaffAssignmentHistory)
     │
     ▼
AdmissionRepository ──► SQLite (Admissions)
```

---

## 🎨 Form Layout

### `DoctorNurseAssignmentForm`

**Regions:**
- **Header**: Brand, user info, Main Menu button, Logout button.
- **Sidebar**: Modules list, Doctor/Nurse highlighted (Visible only for Admin).
- **Toolbar**: Read-only textbox showing the selected admission. **🔍 Find** button opens `AdmissionPickerDialog`.
- **Current Assignment Panel**: Shows the names of the currently assigned Doctor and Nurse.
- **Update Assignment Panel**: Textboxes for New Doctor, New Nurse, and Reason, plus an **Update Assignment** button.
- **History Grid**: Shows a timeline of all past assignments (Date, Role, Staff Name, Reason).

---

## 📄 File-by-File Reference

### `BusinessLogic/Controller/StaffAssignmentController.cs`

- **Purpose:** Validates input and handles the logic of updating assignments.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class StaffAssignmentController`

| Method | Validation |
|--------|-----------|
| `UpdateAssignment()` | Checks if admission is active, requires at least one field to change, writes to `Admissions` and `StaffAssignmentHistory`. |
| `GetHistory()` | Passthrough to fetch the audit trail for the grid. |

### `UI/DoctorNurseAssignmentForm.cs`

- **Purpose:** Main UI for US-010.
- **Namespace:** `UI`
- **Class:** `public partial class DoctorNurseAssignmentForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `DoctorNurseAssignmentForm_Load` | Form opens | Wires sidebar, hides panels until an admission is selected. |
| `btnFindAdmission_Click` | Find button | Opens `AdmissionPickerDialog`. |
| `LoadAssignmentData()` | Internal | Fetches current staff and history, updates labels and grid. |
| `btnUpdate_Click` | Update button | Calls `StaffAssignmentController.UpdateAssignment()`, refreshes data. |

---

## 🗄️ Database Schema

### Table: `StaffAssignmentHistory`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `HistoryID` | INTEGER | PK AUTOINCREMENT | Internal ID |
| `AdmissionCode` | TEXT | NOT NULL | FK to Admissions |
| `Role` | TEXT | NOT NULL | "Doctor" or "Nurse" |
| `StaffName` | TEXT | NOT NULL | Name of the assigned staff |
| `AssignedDate` | TEXT | NOT NULL | `yyyy-MM-dd HH:mm:ss` |
| `Reason` | TEXT | | Optional note for the shift change |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row timestamp |

### Update to `Admissions` Table
Two new columns were added:
- `AttendingDoctor` (TEXT)
- `AssignedNurse` (TEXT)

*Note: These columns store the **current** assignees for quick display, while the history table stores the audit trail.*

---

## 🔄 Data Flow

### Updating an Assignment

1. **User** clicks **🔍 Find** and selects an admission from `AdmissionPickerDialog`.
2. The form populates the current doctor/nurse and loads the history grid.
3. **User** types "Dr. Reyes" into the New Doctor field, types "Shift change" into Reason, and clicks **Update Assignment**.
4. `StaffAssignmentController.UpdateAssignment()` runs.
5. If valid, the controller calls `AdmissionRepository.UpdateStaffAssignment()` to update the `Admissions` table.
6. The controller calls `StaffAssignmentRepository.AddHistory()` to insert a row into `StaffAssignmentHistory`.
7. Form clears the input fields and calls `LoadAssignmentData()` to refresh the view.

---

## 👥 Team Contributions (Doctor/Nurse Assignment)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Database (New table + schema updates), Backend (`StaffAssignment`, repositories, controller), UI code-behind (`DoctorNurseAssignmentForm`, `AdmissionDetailsDialog` updates), Role-based wiring |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (`DoctorNurseAssignmentForm.Designer.cs`, `AdmissionDetailsDialog.Designer.cs` updates) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-010 Doctor/Nurse Assignment (Admin)** — Dedicated Admin form to reassign staff, update the current record, and log the audit trail. Also updated the Admission Details dialog to show assigned staff and treatment charges.

### In Progress

- *(Nothing currently)*

### Not Started

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

---

## 🚀 How to Run

### Prerequisites
- Visual Studio with the **.NET desktop development** workload
- .NET Framework **4.7.2** (or higher)

### Steps
1. **Delete** `UI/bin/Debug/App_Data/HospitalDB.db` to apply the schema changes.
2. **Rebuild** the solution.
3. Login with `admin01` / `admin123`.
4. Open **Doctor / Nurse** from the sidebar or menu.

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/StaffAssignment.cs` | Entity for the audit history row |
| `BusinessLogic/Repository/StaffAssignmentRepository.cs` | Inserts/reads from `StaffAssignmentHistory` |
| `BusinessLogic/Controller/StaffAssignmentController.cs` | Validates and orchestrates staff updates |
| `UI/DoctorNurseAssignmentForm.cs` | Main UI for assigning doctors and nurses |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.