# 🏥 Treatment / Billing Breakdown Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Treatment / Billing Breakdown** module allows Hospital Staff to record individual services, treatments, or medications given to an admitted patient. These charges build up a running subtotal that will later be combined with room charges in the Billing module. Admin users have read-only access to this screen. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-009 | Record Treatment Charges (Hospital Staff) | ✅ Done |

---

## 📖 US-009 — Record Treatment Charges

**User Story:**
As Hospital Staff, I want to record services provided to a patient so that the charges can be included in the patient's bill.

**Acceptance Criteria:**
- [x] Staff can select an active admission and add a service/treatment with date, quantity, and unit cost.
- [x] System computes Total Cost (Quantity × Unit Cost) per line item.
- [x] Quantity must be greater than zero; cost cannot be negative.
- [x] System calculates and displays a running subtotal.
- [x] Services cannot be added to a discharged or inactive admission.
- [x] Treatment records feed directly into the Billing module.
- [x] Admin has view-only access (cannot add treatments).

**Development Tasks:**
- [x] Design `TreatmentBillingForm` layout (header + sidebar + admission picker + grid + add panel) — Stephen
- [x] Build `TreatmentBillingForm.Designer.cs` with admission field, treatment grid, Service/Qty/Unit Cost inputs, Add Item button — Stephen
- [x] Build `AdmissionPickerDialog` (modal search for active admissions) — Stephen
- [x] Add multi-field search in `AdmissionPickerDialog` (Admission Code, Patient Name, Patient Code) — Stephen
- [x] Role-based UI: Disable inputs and `+ Add Item` button for Admin — Stephen
- [x] Show running subtotal dynamically — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen
- [x] Sidebar highlight on the current module — Stephen
- [x] Wire Treatment tile in Admin and Staff menu forms — Stephen

**Backend / Database Tasks:**
- [x] Create `Model/Treatment.cs` — entity with `AdmissionCode`, `ServiceName`, `Date`, `Quantity`, `UnitCost`, `TotalCost` — Stephen
- [x] Create `Treatments` table schema — Stephen
- [x] Create `TreatmentRepository` (Add, GetByAdmission) — Stephen
- [x] Create `TreatmentController.AddTreatment()` with validation chain — Stephen
- [x] Update `DatabaseInitializer.cs` to create the `Treatments` table — Stephen
- [x] Auto-generate `TotalCost` on the backend — Stephen

**Testing Tasks:**
- [x] Test adding a treatment (X-Ray, Qty 1, ₱800) — Lynet, Luster
- [x] Test adding multiple treatments — Lynet, Luster
- [x] Test running subtotal updates correctly — Lynet, Luster
- [x] Test validation: quantity ≤ 0 → "Quantity must be greater than zero." — Lynet, Luster
- [x] Test validation: negative cost → "Unit cost cannot be negative." — Lynet, Luster
- [x] Test validation: empty service name → "Service name is required." — Lynet, Luster
- [x] Test cannot add to a discharged admission — Lynet, Luster
- [x] Test Admin view: inputs and Add button are disabled — Lynet, Luster
- [x] Test sidebar navigation to and from the module — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files

| # | File | Purpose |
|---|------|---------|
| 1 | `Model/Treatment.cs` | Blueprint for a treatment line item |
| 2 | `DB/Table/Treatments.sql` | Documents the Treatments schema |
| 3 | `BusinessLogic/Repository/TreatmentRepository.cs` | SQL queries for Treatments |
| 4 | `BusinessLogic/Controller/TreatmentController.cs` | Validation and business logic |
| 5 | `UI/AdmissionPickerDialog.cs` | Modal search for active admissions |
| 6 | `UI/AdmissionPickerDialog.Designer.cs` | Layout for the picker |
| 7 | `UI/TreatmentBillingForm.cs` | Main Treatment UI logic |
| 8 | `UI/TreatmentBillingForm.Designer.cs` | Layout for the Treatment form |

### Modified Files

| # | File | Change |
|---|------|--------|
| 9 | `BusinessLogic/Repository/DatabaseInitializer.cs` | Added `Treatments` table creation |
| 10 | `UI/RoomManagementForm.cs` | Sidebar wiring |
| 11 | `UI/PatientInformationForm.cs` | Sidebar wiring |
| 12 | `UI/PatientInfoSearchForm.cs` | Sidebar wiring |
| 13 | `UI/PatientRoomSearchForm.cs` | Sidebar wiring |
| 14 | `UI/AdmissionForm.cs` | Sidebar wiring |
| 15 | `UI/AdmissionLogForm.cs` | Sidebar wiring |
| 16 | `UI/AdminMenuForm.cs` | Treatment tile wired |
| 17 | `UI/HospitalStaffMenuForm.cs` | Treatment tile wired |

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `Model/Treatment.cs` | Stores line-item data for a service/treatment |
| `BusinessLogic/Repository/TreatmentRepository.cs` | Inserts and retrieves treatments from SQLite |
| `BusinessLogic/Controller/TreatmentController.cs` | Validates quantity, unit cost, and admission status |
| `UI/AdmissionPickerDialog.cs` | Allows Staff/Admin to search and select an active admission |
| `UI/TreatmentBillingForm.cs` | Main grid and data entry form |

---

## 🏛️ Architecture Overview

```
TreatmentBillingForm
     │
     ▼
TreatmentController ──► TreatmentRepository ──► SQLite (Treatments)
     │
     ▼
AdmissionController ──► AdmissionRepository ──► SQLite (Admissions)
```

---

## 🎨 Form Layout

### `TreatmentBillingForm`

**Regions:**
- **Header**: Brand, user info, Main Menu button, Logout button.
- **Sidebar**: Modules list, Treatment/Billing highlighted.
- **Toolbar**: Read-only textbox showing the selected admission. **🔍 Find** button to open the `AdmissionPickerDialog`.
- **Grid**: Displays existing treatments for the selected admission.
- **Add Treatment Panel** (Bottom): Contains Service Name, Qty, Unit Cost inputs, and a `+ Add Item` button. Includes the Subtotal label.
- **Admin State**: Inputs and the `+ Add Item` button are disabled.

---

## 📄 File-by-File Reference

### `BusinessLogic/Controller/TreatmentController.cs`

- **Purpose:** Validates input and returns `"OK"` or an error message.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class TreatmentController`

| Method | Returns | Validation |
|--------|---------|------------|
| `AddTreatment()` | `string` | Checks if admission is active, service name not empty, qty > 0, cost >= 0. |
| `GetTreatments(code)` | `List<Treatment>` | Passthrough to repository. |
| `CalculateSubtotal(code)` | `decimal` | Sums the `TotalCost` of all treatments for an admission. |

### `UI/TreatmentBillingForm.cs`

- **Purpose:** Main UI for US-009.
- **Namespace:** `UI`
- **Class:** `public partial class TreatmentBillingForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `TreatmentBillingForm_Load` | Form opens | Applies role-based UI changes (disables inputs for Admin). Wires sidebar. |
| `btnFindAdmission_Click` | Find button | Opens `AdmissionPickerDialog`. |
| `LoadTreatments()` | Internal | Fetches treatments, populates grid, recalculates subtotal. |
| `btnAddItem_Click` | Add Item button | Validates input, calls `AddTreatment()`, clears inputs, reloads grid. |

### `UI/AdmissionPickerDialog.cs`

- **Purpose:** Modal search for active admissions.
- **Class:** `public partial class AdmissionPickerDialog : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `RunSearch()` | Internal | Fetches active admissions, filters by Admission Code, Patient Name, or Patient Code. |
| `ConfirmSelection()` | Select button / Double-click | Returns the `AdmissionCode` and a formatted display string to the parent form. |

---

## 🗄️ Database Schema

### Table: `Treatments`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `TreatmentID` | INTEGER | PK AUTOINCREMENT | Internal ID |
| `AdmissionCode` | TEXT | NOT NULL | FK to Admissions |
| `ServiceName` | TEXT | NOT NULL | e.g., "X-Ray" |
| `TreatmentDate` | TEXT | NOT NULL | `yyyy-MM-dd HH:mm:ss` |
| `Quantity` | INTEGER | NOT NULL | Must be > 0 |
| `UnitCost` | REAL | NOT NULL | Must be >= 0 |
| `TotalCost` | REAL | NOT NULL | Quantity × UnitCost |
| `RecordedBy` | TEXT | NOT NULL | Username of staff |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row timestamp |

---

## 🔄 Data Flow

### Adding a Treatment

1. **User** clicks **🔍 Find** on the Treatment form.
2. `AdmissionPickerDialog` opens.
3. **User** searches for an active admission and clicks **Select**.
4. Parent form populates the read-only textbox and calls `LoadTreatments()`.
5. **User** fills in Service Name, Qty, and Unit Cost.
6. **User** clicks **+ Add Item**.
7. `TreatmentController.AddTreatment()` validates the data.
8. If valid, `TreatmentRepository.AddTreatment()` inserts the row.
9. Form clears input fields and calls `LoadTreatments()` again.
10. Grid refreshes and Subtotal updates.

---

## 👥 Team Contributions (Treatment / Billing Breakdown)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Database (`Treatments.sql`), Backend (`Treatment.cs`, `TreatmentRepository.cs`, `TreatmentController.cs`, `DatabaseInitializer` update), UI code-behind (`TreatmentBillingForm.cs`, `AdmissionPickerDialog.cs`), Sidebar wiring, Role-based UI logic |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (`TreatmentBillingForm.Designer.cs`, `AdmissionPickerDialog.Designer.cs`) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-009 Treatment/Billing Breakdown** — Staff can add itemized treatments to active admissions. Admin has view-only access. Subtotal calculates dynamically.

### In Progress

- *(Nothing currently)*

### Not Started

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
5. Press **`F5`** to build and run
6. Login as `areyes` / `staff123` or `admin01` / `admin123`
7. Click **Treatment / Billing** in the sidebar

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/Treatment.cs` | Entity for a treatment line item |
| `BusinessLogic/Repository/TreatmentRepository.cs` | Inserts/retrieves treatments from SQLite |
| `BusinessLogic/Controller/TreatmentController.cs` | Validates treatment input and calculates subtotals |
| `BusinessLogic/Repository/DatabaseInitializer.cs` | Creates the Treatments table |
| `UI/TreatmentBillingForm.cs` | Main UI for viewing and adding treatments |
| `UI/AdmissionPickerDialog.cs` | Modal search dialog for active admissions |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.