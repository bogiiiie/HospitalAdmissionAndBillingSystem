# 💵 Billing Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Billing** module is the financial core of the Hospital Admission and Billing System. It allows Staff to compute the final bill, apply payments, and generate receipts. Admin users have the exclusive ability to apply dynamic discounts (Percentage or Fixed Amount) with specific reasons (e.g., Senior Citizen, PhilHealth). Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-011a | Process Billing (Hospital Staff) | ✅ Done |
| US-011b | Apply Billing Adjustments (Admin) | ✅ Done |

---

## 📖 US-011a — Process Billing (Hospital Staff)

**User Story:**
As Hospital Staff, I want to view the patient's accumulated charges so that I can calculate the total amount due.

**Acceptance Criteria:**
- [x] Staff can select an active admission via a modal search dialog.
- [x] System auto-calculates Room Charges from `AdmissionRoomHistory` (Policy B split-rate).
- [x] System auto-calculates Treatment Charges from the `Treatments` table.
- [x] Total Due = Room Charges + Treatment Charges - Discount.
- [x] Full payment is required to finalize — payment less than Total Due is rejected.
- [x] System computes change only when payment exceeds Total Due.
- [x] Staff can finalize the bill, which locks it from further edits.
- [x] Staff cannot apply discounts; the discount fields are hidden/read-only.

**Development Tasks:**
- [x] Design `BillingForm` layout (header + sidebar + admission picker + breakdown panel + payment panel) — Stephen
- [x] Build `BillingForm.Designer.cs` with real-time Total Due and Change calculation — Stephen
- [x] Build the "Save Draft" functionality so cashiers can finalize bills later — Stephen
- [x] Disable discount inputs for Staff and show a read-only summary of applied discounts — Stephen
- [x] Implement read-only mode when a bill is already `Paid` — Stephen
- [x] Wire sidebar navigation across all module forms — Stephen

**Backend / Database Tasks:**
- [x] Create `Model/Bill.cs` — entity with `RoomCharges`, `TreatmentCharges`, `DiscountComputed`, `TotalDue`, `AmountPaid`, `Change`, `Status` — Stephen
- [x] Create `Bills` table schema — Stephen
- [x] Create `BillRepository.cs` (SaveBill, GetBillByAdmission, GenerateNextBillCode) — Stephen
- [x] Create `BillController.cs` with validation (Full payment required, discount limits) — Stephen
- [x] Auto-generate Bill Code (`BILL-0001`) — Stephen
- [x] Update `DatabaseInitializer.cs` to create the `Bills` table — Stephen
- [x] Update `AdmissionDetailsDialog.cs` to show the real-time bill status (Paid/Draft/Unbilled) and applied discounts — Stephen

**Testing Tasks:**
- [x] Test selecting an admission and seeing auto-calculated charges — Lynet, Luster
- [x] Test entering a partial payment (should be blocked) — Lynet, Luster
- [x] Test entering an exact payment (should finalize successfully) — Lynet, Luster
- [x] Test entering an overpayment (should show the correct change) — Lynet, Luster
- [x] Test that a finalized bill locks the form into read-only mode — Lynet, Luster
- [x] Test sidebar navigation to and from the module — Lynet, Luster

---

## 📖 US-011b — Apply Billing Adjustments (Admin)

**User Story:**
As an Admin, I want to apply discounts or adjustments to a patient's bill so that special cases (e.g., PhilHealth deductions) are reflected accurately.

**Acceptance Criteria:**
- [x] Admin has the same billing access as US-011a.
- [x] Admin can apply a dynamic discount (Percentage or Fixed Amount).
- [x] Admin can select a discount reason (PhilHealth, Senior Citizen, PWD, HMO, Employee, Other).
- [x] Discount cannot exceed the total charges.
- [x] Full payment of the discounted Total Due is still required to finalize.
- [x] The Discount fields are only visible/editable by Admin.

**Development Tasks:**
- [x] Show Discount Type, Discount Value, and Discount Reason fields for Admin only — Stephen
- [x] Implement real-time calculation of the discount (e.g., 20% of Subtotal) — Stephen
- [x] Add validation message if discount > total charges — Stephen
- [x] Allow Admin to "Save Draft" to apply the discount early without taking payment — Stephen
- [x] Update the read-only view to show the discount amount and reason clearly — Stephen

**Backend / Database Tasks:**
- [x] Update `Bills` table to include `DiscountType`, `DiscountValue`, `DiscountReason`, and `DiscountComputed` — Stephen
- [x] Update `BillController.ProcessBill()` to handle both Percentage and Amount discounts — Stephen
- [x] Fix the mathematical bug where fixed discounts were calculating as negative numbers — Stephen
- [x] Pass the computed discount to `AdmissionDetailsDialog` so staff can see it — Stephen

**Testing Tasks:**
- [x] Test Admin sees the discount inputs — Lynet, Luster
- [x] Test Percentage discount (e.g., 20%) — Lynet, Luster
- [x] Test Fixed Amount discount (e.g., ₱500) — Lynet, Luster
- [x] Test that Staff sees the applied discount but cannot edit it — Lynet, Luster
- [x] Test that the Admission Details dialog reflects the discounted total and the "PAID" status — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files

| # | File | Purpose |
|---|------|---------|
| 1 | `Model/Bill.cs` | Blueprint for the billing record |
| 2 | `BusinessLogic/Repository/BillRepository.cs` | SQL for saving and retrieving Bills |
| 3 | `BusinessLogic/Controller/BillController.cs` | Validation and financial calculations |
| 4 | `UI/BillingForm.cs` | Main UI logic |
| 5 | `UI/BillingForm.Designer.cs` | Layout for the Billing form |

### Modified Files

| # | File | Change |
|---|------|--------|
| 6 | `BusinessLogic/Repository/DatabaseInitializer.cs` | Added `Bills` table creation |
| 7 | `UI/AdmissionDetailsDialog.cs` | Show real-time billing status and discounts |
| 8 | `UI/AdmissionDetailsDialog.Designer.cs` | Added UI elements for discount/status and enabled AutoScroll |
| 9 | All 8 forms with Sidebars | Wired the `btnNavBilling` button and updated role-based stacking |
| 10 | `AdminMenuForm.cs` / `HospitalStaffMenuForm.cs` | Wired the Billing tile |

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `Model/Bill.cs` | Stores financial data (Room, Treatment, Discount, Total, Paid, Change) |
| `BillRepository.cs` | Inserts and retrieves bill records from SQLite |
| `BillController.cs` | Orchestrates calculations and validates payment amounts |
| `UI/BillingForm.cs` | The user interface for viewing, discounting, and paying bills |

---

## 🏛️ Architecture Overview

```
BillingForm
     │
     ▼
BillController ──► BillRepository ──► SQLite (Bills)
     │
     ├──► AdmissionController ──► SQLite (AdmissionRoomHistory) 
     │
     └──► TreatmentController ──► SQLite (Treatments)
```

---

## 🎨 Form Layout

### `BillingForm`

**Regions:**
- **Header & Sidebar**: Standard chrome.
- **Toolbar**: Read-only textbox with selected admission, plus a **🔍 Find** button to open the `AdmissionPickerDialog`.
- **Bill Breakdown Panel**: Displays Room Charges, Treatment Charges, and Total Due.
  - *Admin View*: Includes input fields for Discount Type, Discount Value, and Reason.
  - *Staff View*: Includes read-only labels displaying the discount amount and reason if applied by Admin.
- **Payment Panel**: Textboxes for Payment Amount and Change, plus **Finalize Bill** and **Save Draft** buttons.

---

## 📄 File-by-File Reference

### `BusinessLogic/Controller/BillController.cs`

- **Purpose:** Validates payments and computes the final bill.
- **Namespace:** `BusinessLogic.Controller`
- **Class:** `public class BillController`

| Method | Validation |
|--------|-----------|
| `CalculateTotals()` | Computes Room + Treatment - Discount. Handles both `Percentage` and `Amount` types. |
| `ProcessBill()` | Ensures `AmountPaid >= TotalDue` before finalizing. Updates Status to `Paid` and locks the record. |
| `GetBill()` | Passthrough to fetch an existing bill. |

### `UI/BillingForm.cs`

- **Purpose:** Main UI for the Billing module.
- **Namespace:** `UI`
- **Class:** `public partial class BillingForm : Form`

| Method | Trigger | Action |
|--------|---------|--------|
| `BillingForm_Load` | Form opens | Checks role to hide/show discount fields. Wires sidebar. |
| `btnFindAdmission_Click` | Find button | Opens `AdmissionPickerDialog`. |
| `LoadBillingData()` | Internal | Fetches existing bill or calculates base totals. Locks form if already Paid. |
| `DiscountChanged()` | Discount inputs | Recomputes the Total Due in real-time (Admin only). |
| `btnSaveDraft_Click` | Save Draft | Saves the discounted bill to the database without finalizing. |
| `btnFinalize_Click` | Finalize | Validates payment, processes the bill, and sets it to read-only. |

---

## 🗄️ Database Schema

### Table: `Bills`

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `BillID` | INTEGER | PK AUTOINCREMENT | Internal ID |
| `BillCode` | TEXT | NOT NULL UNIQUE | Display ID: `BILL-0001` |
| `AdmissionCode` | TEXT | NOT NULL | FK to Admissions |
| `RoomCharges` | REAL | NOT NULL | Auto-pulled from room history |
| `TreatmentCharges` | REAL | NOT NULL | Auto-pulled from treatments |
| `DiscountType` | TEXT | | `Percentage` or `Amount` |
| `DiscountValue` | REAL | DEFAULT 0 | e.g., 20 (for 20%) or 500 (for ₱500) |
| `DiscountReason` | TEXT | | e.g., Senior Citizen, PhilHealth |
| `DiscountComputed` | REAL | NOT NULL | The actual peso amount deducted |
| `TotalDue` | REAL | NOT NULL | Final amount to be paid |
| `AmountPaid` | REAL | NOT NULL | Cash received |
| `Change` | REAL | NOT NULL | Cash returned to patient |
| `Status` | TEXT | NOT NULL | `Draft` or `Paid` |
| `ProcessedBy` | TEXT | NOT NULL | Username of cashier/admin |
| `CreatedAt` | TEXT | DEFAULT datetime('now') | Row timestamp |

---

## 🔄 Data Flow

### Processing a Bill

1. **User** clicks **🔍 Find** and selects an active admission.
2. The form calculates base Room and Treatment charges.
3. **If Admin**: Types a discount, which immediately updates the Total Due.
4. **If Staff**: Sees the Total Due (already discounted if Admin saved a draft).
5. **User** enters the Payment Amount. The form calculates the Change.
6. **User** clicks **Finalize Bill**.
7. `BillController` validates that `Payment >= Total Due`.
8. `BillRepository` inserts the record with `Status = 'Paid'`.
9. The form refreshes and becomes strictly read-only.

---

## 👥 Team Contributions (Billing)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Database (Bills.sql), Backend (Bill.cs, BillRepository.cs, BillController.cs), UI logic (BillingForm.cs), Role-based calculations, Admission Details integration |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (BillingForm.Designer.cs, AdmissionDetailsDialog.Designer.cs updates) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-011a Process Billing (Staff)** — Cashiers can process full payments, calculate change, and finalize bills.
- **US-011b Apply Billing Adjustments (Admin)** — Admins can apply dynamic Percentage or Fixed Amount discounts with specific reasons.
- **Admission Details Integration** — The Admission Log dialog now shows the final bill status (Paid/Unbilled) and any applied discounts.

### In Progress

- *(Nothing currently)*

### Not Started

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
3. Login with `admin01` / `admin123` or `areyes` / `staff123`.
4. Open **Billing** from the sidebar or menu.

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `Model/Bill.cs` | Blueprint of a financial record |
| `BusinessLogic/Repository/BillRepository.cs` | SQL for Bills |
| `BusinessLogic/Controller/BillController.cs` | Calculates totals and validates payments |
| `UI/BillingForm.cs` | Main UI for processing payments |
| `UI/AdmissionDetailsDialog.cs` | Displays the current bill status and discounts |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.