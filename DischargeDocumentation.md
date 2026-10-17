# 🚪 Discharge & Discharge Summary Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **Discharge** module is the final step in the patient lifecycle. It verifies that all financial obligations are settled, officially ends the hospital stay, frees up the assigned room, and generates a comprehensive, printable **Discharge Summary** report. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-012 | Discharge Patient (Hospital Staff/Admin) | ✅ Done |
| US-013 | View/Print Discharge Summary | ✅ Done |

---

## 📖 US-012 — Discharge Patient

**User Story:**
As Hospital Staff, I want to discharge a patient after the bill is settled so that the patient's admission can be completed and the room can become available.

**Acceptance Criteria:**
- [x] Staff can select an active admission via a modal search dialog.
- [x] System blocks discharge if the patient has any outstanding balance (Bill Status is not "Paid").
- [x] System prompts a confirmation before proceeding.
- [x] Room status automatically reverts to "Available" upon discharge.
- [x] System automatically opens the Discharge Summary once discharge is confirmed.

**Development Tasks:**
- [x] Design `DischargeForm` layout (admission picker, discharge date, notes, billing status) — Stephen
- [x] Display a red "UNPAID" or green "PAID" billing status label — Stephen
- [x] Disable the "Confirm Discharge" button if the bill is unpaid — Stephen
- [x] Auto-open the `DischargeSummaryForm` immediately after a successful discharge — Stephen
- [x] Wire the module to the sidebar of all 10 module forms — Stephen

**Backend / Database Tasks:**
- [x] Add `DischargePatient()` to `AdmissionRepository` — Stephen
- [x] Use SQL transactions to update `Admissions` (Status, Date, Notes), close `AdmissionRoomHistory` (set `EndDate`), and free the `Rooms` table — Stephen
- [x] Add `DischargePatient()` to `AdmissionController` with validation against the `Bills` table — Stephen

**Testing Tasks:**
- [x] Test that an unpaid admission blocks the discharge process — Lynet, Luster
- [x] Test that a paid admission allows discharge — Lynet, Luster
- [x] Test that the room becomes Available in Room Management — Lynet, Luster
- [x] Test that the Admission Log updates to "Discharged" — Lynet, Luster

---

## 📖 US-013 — View/Print Discharge Summary

**User Story:**
As a system user, I want to view and print a summary of the patient's stay so that a complete record of admission, treatment, and billing is available.

**Acceptance Criteria:**
- [x] Summary can only be generated for admissions with status "Discharged."
- [x] System automatically pulls together patient info, admission details, treatments given, and the billing total.
- [x] All fields on this screen are read-only.
- [x] Staff can manually print the summary using the Windows Print dialog (which supports "Microsoft Print to PDF").
- [x] The form can be reopened later from the Admission Log for previously discharged patients.

**Development Tasks:**
- [x] Design `DischargeSummaryForm` layout (read-only patient, stay, treatments, and billing sections) — Stephen
- [x] Build `DischargedPatientPickerDialog` to allow searching past discharged patients — Stephen
- [x] Implement the `PrintDocument` and `PrintPreviewDialog` rendering logic — Stephen
- [x] Connect the "Print" button to the Windows print dialog — Stephen
- [x] Update `AdmissionLogForm` so double-clicking a discharged patient opens the Summary — Stephen

**Backend / Database Tasks:**
- [x] Add `GetDischargedAdmissions()` to `AdmissionRepository` and `AdmissionController` — Stephen

**Testing Tasks:**
- [x] Test opening the Summary from the Discharge form (auto-open) — Lynet, Luster
- [x] Test opening the Summary from the sidebar and using the "Find" button — Lynet, Luster
- [x] Test the Print Preview window renders a clean document — Lynet, Luster
- [x] Test opening the Summary by double-clicking a discharged patient in the Admission Log — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files
| # | File | Purpose |
|---|------|---------|
| 1 | `UI/DischargeForm.cs` / `.Designer.cs` | Main UI for processing the discharge |
| 2 | `UI/DischargeSummaryForm.cs` / `.Designer.cs` | Read-only report screen with Print logic |
| 3 | `UI/DischargedPatientPickerDialog.cs` / `.Designer.cs` | Modal search dialog for past patients |

### Modified Files
| # | File | Change |
|---|------|--------|
| 4 | `BusinessLogic/Repository/AdmissionRepository.cs` | Added `DischargePatient()` and `GetDischargedAdmissions()` |
| 5 | `BusinessLogic/Controller/AdmissionController.cs` | Added validation for discharge and passthroughs |
| 6 | `UI/AdmissionLogForm.cs` | Double-clicking a discharged patient opens the Summary |
| 7 | All 10 forms with Sidebars | Added `btnNavDischarge` and `btnNavSummary` wiring |
| 8 | `AdminMenuForm.cs` / `HospitalStaffMenuForm.cs` | Wired the Discharge and Summary tiles |

---

## 🎨 Form Layouts

### `DischargeForm`
- **Toolbar:** Read-only textbox showing the selected admission + **🔍 Find** button.
- **Main Card:** 
  - Auto-filled Discharge Date/Time.
  - Optional Discharge Notes textbox.
  - **Billing Status** label (Red for UNPAID, Green for PAID).
  - **Confirm Discharge** button (disabled if unpaid).

### `DischargeSummaryForm`
- **Toolbar:** Read-only textbox + **🔍 Find** button (to look up past patients).
- **Content Panel (Scrollable):**
  - **Patient Information:** Name, ID, Gender, DOB, Contact, Address.
  - **Stay Details:** Admission Code, Room, Admit/Discharge Dates, Doctor, Nurse, Notes.
  - **Treatments:** A read-only grid of all services rendered.
  - **Final Billing:** Room Charges, Treatment Charges, Discount, and Total Paid.
  - **🖨️ Print Button:** Opens the Windows Print Preview. Users can select "Microsoft Print to PDF" to save a digital copy.

---

## 🔄 Data Flow

### Processing a Discharge
1. **User** selects an admission in `DischargeForm`.
2. Form queries the `Bills` table. If `Status != 'Paid'`, the button is disabled.
3. If paid, **User** clicks **Confirm Discharge**.
4. `AdmissionController.DischargePatient()` validates the state again.
5. `AdmissionRepository` opens a SQL transaction:
   - Updates `Admissions.Status` to `Discharged` and sets the date.
   - Updates `AdmissionRoomHistory.EndDate` to close the current period.
   - Updates `Rooms.Status` to `Available`.
6. The form closes and `DischargeSummaryForm` opens automatically.

### Printing the Summary
1. **User** clicks **🖨️ Print** on the Summary form.
2. C# instantiates a `PrintDocument`.
3. The `PrintPage` event fires, using `e.Graphics.DrawString` to draw text, lines, and tables onto the page.
4. A `PrintPreviewDialog` opens, showing exactly how the paper will look.
5. User can print to a physical printer or select "Microsoft Print to PDF" to save a PDF.

---

## 👥 Team Contributions (Discharge & Summary)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Backend (`DischargePatient` transaction logic), UI code-behind (`DischargeForm`, `DischargeSummaryForm`), Windows Print integration, Auto-open flow, Sidebar wiring |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (`DischargeForm`, `DischargeSummaryForm`, `DischargedPatientPickerDialog`) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | Tester |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-012 Discharge Patient** — Full validation of billing, database transaction for status/room release, and automatic redirect to the summary.
- **US-013 View/Print Discharge Summary** — Fully formatted read-only report with Windows Print Preview integration and historical lookup.

### 🎉 PROJECT COMPLETE

All 13 Core & Optional User Stories have been successfully implemented, tested, and merged.

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

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.