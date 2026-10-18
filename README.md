# Hospital Admission and Billing System

**Group 4 | BT3101**  
Stephen William De Jesus · Lynet Cielo · Luster Tamanu Mangaliman · Neil Jerson Manalo

A hospital admission and billing system with role-based access for **Admin** and **Hospital Staff**.

Built using a four-project architecture:

* **Model** — Data models and entities
* **BusinessLogic** — Controllers and repositories
* **DB** — Database scripts
* **UI** — Windows Forms application

---

## 🔑 Demo Login Credentials

These are the two test accounts seeded into the database:

| Role           | Username  | Password   |
| -------------- | --------- | ---------- |
| Admin          | `admin01` | `admin123` |
| Hospital Staff | `areyes`  | `staff123` |

> **Note:** These credentials are intended for development and testing purposes only. Passwords are stored as **SHA256 hashes**, never in plain text.

---

## 📋 Project Kanban Board

Track the project's tasks, progress, and development status through our GitHub Kanban Board:

### [🔗 View Group 4 Kanban Board](https://github.com/users/bogiiiie/projects/4)

---

## 🎥 Demo Video

Watch a full walkthrough of the system in action:

[![Hospital Admission and Billing System — Demo](https://img.youtube.com/vi/_S4evQe2iWA/0.jpg)](https://youtu.be/_S4evQe2iWA)

---

## 👥 Team Roles

| Member                   | GitHub                                                             | Role(s)                                                                     |
| ------------------------ | ------------------------------------------------------------------ | --------------------------------------------------------------------------- |
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie)                           | Product Owner + Reviewer + Database Developer + Backend Developer + Tester  |
| Lynet Cielo              | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UX/UI Designer + Frontend Developer                                         |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue)       | Backend Developer + Tester                                                  |
| Neil Jerson Manalo       | Pending collaborator                                               | Backend Developer                                                           |

---

## 📦 Modules

| #  | Module                             | Status        |
| -- | ---------------------------------- | ------------- |
| 1  | Login & Main Menu (role-based)     | ✅ **Done**    |
| 2  | Room Management                    | ✅ **Done**    |
| 3  | Patient Information Maintenance    | ✅ **Done**    |
| 4  | Patient Info Search                | ✅ **Done**    |
| 5  | Patient Room Search                | ✅ **Done**    |
| 6  | Admission                          | ✅ **Done**    |
| 7  | Admission Log History (Optional)   | ✅ **Done**    |
| 8  | Treatment/Billing Breakdown        | ✅ **Done**    |
| 9  | Doctor/Nurse Assignment (Optional) | ✅ **Done**    |
| 10 | Billing                            | ✅ **Done**    |
| 11 | Discharge                          | ✅ **Done**    |
| 12 | Discharge Summary                  | ✅ **Done**    |
| 13 | User Management (Admin Utility)    | ✅ **Done**    |

---

## ✅ Progress Tracker

### Done

* **US-001 Role-Based Navigation** — Main Menu shows different tiles for Admin and Hospital Staff.
* **US-002 Login** — SHA256 password hashing with SQLite database, automatically created on first run.
* **US-003a Manage Rooms (Admin)** — Full CRUD with validation, unique room number enforcement, and blocked deletion of occupied rooms.
* **US-003b View Room Availability (Staff)** — Read-only view with role-based UI hiding and status filter.
* **US-004a Register/Update Patients (Staff)** — Add and edit patient records with validation. Guardian/emergency contact fields included.
* **US-004b Full Patient Record Management (Admin)** — Same access as Staff plus the ability to permanently delete or reactivate records.
* **US-005 Patient Info Search** — Find patients by ID, name, or contact, with View Details modal.
* **US-006 Patient Room Search** — Find room availability or locate a patient's current room by matching occupant names.
* **US-007a Admission (Staff)** — Select active patients and available rooms, lock in the rate, and start the billing clock.
* **US-007b Override Admissions (Admin)** — Edit existing admissions to change room assignments and update the locked rate.
* **US-008 Admission Log History** — Read-only grid with multi-field search filters (ID, name, room, date, staff).
* **US-009 Treatment/Billing Breakdown** — Record itemized treatments (X-Rays, meds) with dynamic running subtotals.
* **US-010 Doctor/Nurse Assignment (Admin)** — Reassign attending staff and maintain a permanent audit history of all shift changes.
* **US-011a Process Billing (Staff)** — Auto-calculate Room + Treatment charges, validate full payment, and finalize bills.
* **US-011b Apply Billing Adjustments (Admin)** — Apply dynamic discounts (Percentage or Fixed Amount) with specific reasons (Senior Citizen, PhilHealth, etc.).
* **US-012 Discharge** — Validates that the bill is fully paid, updates the room to Available, and closes the room history.
* **US-013 Discharge Summary** — Generates a comprehensive, printable read-only report of the patient's entire stay.
* **US-014 User Management (Admin)** — Admin-only utility to view system accounts and securely reset Hospital Staff passwords.
* **Database Initialization** — `DatabaseInitializer.EnsureDatabase()` creates and seeds all tables by reading SQL scripts from `PostScript/*.sql`.
* **Seed Data** — 2 users, 100 rooms, and 50 patients seeded on first run.
* **Persistent Header** — All module forms share the same header bar with logged-in user info, Main Menu button, and Logout button.
* **Policy B Billing** — Split-rate billing implemented via `AdmissionRoomHistory` to accurately charge patients who change rooms mid-stay.

### 🎉 PROJECT COMPLETE

All Core & Optional User Stories/Utilities have been successfully implemented, tested, and merged.

---

## 🗂️ Project Structure

```text
HospitalAdmissionAndBillingSystem/
│
├── Model/
│   ├── User.cs
│   ├── Room.cs
│   ├── Patient.cs
│   ├── Admission.cs
│   ├── AdmissionRoomHistory.cs
│   ├── Treatment.cs
│   ├── Bill.cs
│   └── StaffAssignment.cs
│
├── BusinessLogic/
│   ├── Controller/
│   │   ├── LoginController.cs
│   │   ├── RoomController.cs
│   │   ├── PatientController.cs
│   │   ├── AdmissionController.cs
│   │   ├── TreatmentController.cs
│   │   ├── BillController.cs
│   │   ├── StaffAssignmentController.cs
│   │   └── UserController.cs
│   │
│   └── Repository/
│       ├── UserRepository.cs
│       ├── RoomRepository.cs
│       ├── PatientRepository.cs
│       ├── AdmissionRepository.cs
│       ├── TreatmentRepository.cs
│       ├── BillRepository.cs
│       ├── StaffAssignmentRepository.cs
│       └── DatabaseInitializer.cs
│
├── DB/
│   ├── Table/
│   │   ├── Users.sql
│   │   ├── Rooms.sql
│   │   ├── Patients.sql
│   │   ├── Admissions.sql
│   │   ├── AdmissionRoomHistory.sql
│   │   ├── Treatments.sql
│   │   ├── Bills.sql
│   │   └── StaffAssignmentHistory.sql
│   │
│   ├── View/                          (empty for now)
│   ├── StoredProc/                    (empty — SQLite has no stored procs)
│   │
│   └── PostScript/
│       ├── SeedUsers.sql
│       ├── SeedRooms.sql
│       └── SeedPatients.sql
│
├── UI/
│   ├── App_Data/                      (auto-created at runtime)
│   │   └── HospitalDB.db
│   │
│   ├── PostScript/                    (linked from DB project, copied to bin)
│   │   ├── SeedUsers.sql
│   │   ├── SeedRooms.sql
│   │   └── SeedPatients.sql
│   │
│   ├── LoginPage.cs
│   ├── AdminMenuForm.cs
│   ├── HospitalStaffMenuForm.cs
│   ├── UserManagementForm.cs
│   ├── RoomManagementForm.cs
│   ├── AddEditRoomForm.cs
│   ├── PatientInformationForm.cs
│   ├── AddEditPatientForm.cs
│   ├── PatientInfoSearchForm.cs
│   ├── PatientDetailsForm.cs
│   ├── PatientRoomSearchForm.cs
│   ├── AdmissionForm.cs
│   ├── EditAdmissionForm.cs
│   ├── AdmissionPickerDialog.cs
│   ├── AdmissionLogForm.cs
│   ├── AdmissionDetailsDialog.cs
│   ├── TreatmentBillingForm.cs
│   ├── DoctorNurseAssignmentForm.cs
│   ├── BillingForm.cs
│   ├── DischargeForm.cs
│   ├── DischargeSummaryForm.cs
│   ├── DischargedPatientPickerDialog.cs
│   ├── ResetPasswordDialog.cs
│   ├── Program.cs
│   └── App.config
│
└── README.md
```

### Architecture Overview

```text
+-----------------------------------------------------------+
|                          UI                               |
|                 Windows Forms Application                 |
|    (Login, Menus, Room, Patient, Search, Admission,       |
|     Treatment, Doctor/Nurse, Billing, Discharge, User)    |
+---------------------------+-------------------------------+
                            |
                            | calls
                            v
+-----------------------------------------------------------+
|                     BusinessLogic                         |
|                                                           |
|   +-------------------+         +---------------------+   |
|   |    Controller     |-------->|     Repository      |   |
|   |  (LoginController,|         |  (UserRepository,   |   |
|   |   RoomController, |         |   RoomRepository,   |   |
|   |   Patient,        |         |   Patient,          |   |
|   |   Admission,      |         |   Admission,        |   |
|   |   Treatment,      |         |   Treatment,        |   |
|   |   Bill,           |         |   Bill,             |   |
|   |   StaffAssignment,|         |   StaffAssignment,  |   |
|   |   UserController) |         |   DatabaseInitializer)|
|   |                   |         |                     |   |
|   |  Business rules   |         |  Database access    |   |
|   +---------+---------+         +----------+----------+   |
+-------------|------------------------------|--------------+
              |                              |
              | uses                         | reads/writes
              v                              v
      +--------------+              +------------------+
      |    Model     |              |   SQLite (.db)   |
      |              |              |                  |
      |  User.cs     |              |  UI/App_Data/    |
      |  Room.cs     |              |  HospitalDB.db   |
      |  Patient.cs  |              |                  |
      |  Admission.. |              |                  |
      |  Treatment   |              |                  |
      |  Bill.cs     |              |                  |
      |  StaffAsgn.  |              |                  |
      +--------------+              +------------------+

      +---------------------------------------------------+
      |              DB Project                           |
      |   (SQL scripts — documentation and reference only;|
      |    runs at runtime through DatabaseInitializer.cs)|
      +---------------------------------------------------+
```

---

## 🧪 Test Accounts

The same demo credentials are also provided here for reference:

| Role           | Username  | Password   |
| -------------- | --------- | ---------- |
| Admin          | `admin01` | `admin123` |
| Hospital Staff | `areyes`  | `staff123` |

Passwords are stored as **SHA256 hashes**, never in plain text.

---

## 🛠️ Tech Stack

* **Language:** C# (.NET Framework 4.7.2)
* **UI:** Windows Forms
* **Database:** SQLite (`System.Data.SQLite.Core`)
* **Version Control:** Git + GitHub
* **Workflow:** Feature Branches → Pull Requests → Review → Merge

---

## 🚀 How to Run

### 1. Clone the Repository

```bash
git clone https://github.com/bogiiiie/HospitalAdmissionAndBillingSystem.git
```

### 2. Open the Project

Open the solution in **Visual Studio**.

### 3. Restore Dependencies

Restore the required NuGet packages, including:

```text
System.Data.SQLite.Core
```

### 4. Run the Application

Build and run the project.

The SQLite database will be automatically created and initialized on the first run through:

```csharp
DatabaseInitializer.EnsureDatabase();
```

The initializer also reads seed data from the `PostScript/*.sql` files, which are linked into the UI project and copied to the output folder on build.

### 5. Log In

Use one of the demo accounts provided at the top of this README.

---

## 🔐 Role-Based Access

The system provides different access levels depending on the logged-in user's role.

### Admin

The Admin account has access to administrative functions available through the Admin Main Menu, including:

* **Room Management** — Full CRUD (add, edit, delete, reactivate rooms).
* **Patient Information** — Full add/edit/delete access. Admin can permanently delete a patient only if they have no admission or billing history.
* **Admission** — Can override/edit existing admissions and correct room assignments.
* **Doctor / Nurse** — Can reassign attending staff and view the assignment history.
* **Billing** — Can apply dynamic Percentage or Fixed Amount discounts (e.g., Senior Citizen, PhilHealth).
* **User Management** — Can view system accounts and reset Hospital Staff passwords.

### Hospital Staff

The Hospital Staff account has access to hospital staff functions available through the Hospital Staff Main Menu, including:

* **Room Management** — Read-only view of rooms with status filtering.
* **Patient Information** — Add and edit patient records. Staff can deactivate a patient, but cannot permanently delete.
* **Admission** — Can admit patients and record admission details.
* **Treatment / Billing** — Can add treatments and process full payments.
* **Discharge** — Can process patient discharge once the bill is fully paid.

The role is determined during login and is used to display the appropriate main menu and control access to role-specific features.

---

## 🌱 Development Workflow

The project follows a feature-branch workflow:

```text
Feature Branch
      │
      ▼
 Development
      │
      ▼
 Pull Request
      │
      ▼
 Code Review
      │
      ▼
   Approval
      │
      ▼
    Merge
```

Each feature is developed in its own branch before being reviewed and merged into the main project.

---

## 📌 Current Status

The entire **Hospital Admission and Billing System** is fully complete. All 13 modules and the Admin User Management utility have been implemented, rigorously tested, and merged into the `main` branch.

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.
