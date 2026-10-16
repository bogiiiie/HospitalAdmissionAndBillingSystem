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
| 7  | Admission Log History (Optional)   | ⬜ Not started |
| 8  | Treatment/Billing Breakdown        | ⬜ Not started |
| 9  | Doctor/Nurse Assignment (Optional) | ⬜ Not started |
| 10 | Billing                            | ⬜ Not started |
| 11 | Discharge                          | ⬜ Not started |
| 12 | Discharge Summary                  | ⬜ Not started |

---

## ✅ Progress Tracker

### Done

* **US-001 Role-Based Navigation** — Main Menu shows different tiles for Admin and Hospital Staff.
* **US-002 Login** — SHA256 password hashing with SQLite database, automatically created on first run.
* **US-003a Manage Rooms (Admin)** — Full CRUD with validation, unique room number enforcement, and blocked deletion of occupied rooms. Occupied rooms lock the Edit/Delete actions with a hover tooltip. Deleted rooms can be reactivated back to Available.
* **US-003b View Room Availability (Staff)** — Read-only view with role-based UI hiding and status filter.
* **US-004a Register/Update Patients (Staff)** — Add and edit patient records with validation. Staff can deactivate patients (soft delete) but cannot permanently delete. Guardian/emergency contact fields included.
* **US-004b Full Patient Record Management (Admin)** — Same access as Staff plus the ability to permanently delete records that have no admission or billing history, and to reactivate deactivated patients.
* **Guardian Defaults** — Default guardian is "Self — Patient arrived alone" for conscious adults. Guardian is mandatory for minors and patients unable to provide information.
* **Database Initialization** — `DatabaseInitializer.EnsureDatabase()` creates and seeds the Users, Rooms, and Patients tables by reading SQL scripts from `PostScript/*.sql`.
* **Seed Data** — 2 users, 100 rooms, and 50 patients seeded on first run.
* **UI Wiring** — `LoginPage` connected to `LoginController`; `RoomManagementForm` connected to `RoomController`; `PatientInformationForm` connected to `PatientController`.
* **Persistent Header** — All module forms share the same header bar with logged-in user info, Main Menu button, and Logout button.

### In Progress

* *(Nothing currently)*

### Not Started

* **US-005** — Patient Info Search
* **US-006** — Patient Room Search
* **US-007a / US-007b** — Admission
* **US-008** — Admission Log History (Optional)
* **US-009** — Treatment/Billing Breakdown
* **US-010** — Doctor/Nurse Assignment (Optional)
* **US-011a / US-011b** — Billing
* **US-012** — Discharge
* **US-013** — Discharge Summary

---

## 🗂️ Project Structure

```text
HospitalAdmissionAndBillingSystem/
│
├── Model/
│   ├── User.cs
│   ├── Room.cs
│   └── Patient.cs
│
├── BusinessLogic/
│   ├── Controller/
│   │   ├── LoginController.cs
│   │   ├── RoomController.cs
│   │   └── PatientController.cs
│   │
│   └── Repository/
│       ├── UserRepository.cs
│       ├── RoomRepository.cs
│       ├── PatientRepository.cs
│       └── DatabaseInitializer.cs
│
├── DB/
│   ├── Table/
│   │   ├── Users.sql
│   │   ├── Rooms.sql
│   │   └── Patients.sql
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
│   ├── RoomManagementForm.cs
│   ├── AddEditRoomForm.cs
│   ├── PatientInformationForm.cs
│   ├── AddEditPatientForm.cs
│   ├── Program.cs
│   └── App.config
│
└── README.md
```

### Architecture Overview

```text
┌───────────────────────────────────────────────────────────┐
│                          UI                               │
│                 Windows Forms Application                 │
│    (LoginPage, AdminMenuForm, HospitalStaffMenuForm,      │
│     RoomManagementForm, AddEditRoomForm,                  │
│     PatientInformationForm, AddEditPatientForm)           │
└───────────────────────────┬───────────────────────────────┘
                            │
                            │ calls
                            ▼
┌───────────────────────────────────────────────────────────┐
│                     BusinessLogic                         │
│                                                           │
│   ┌───────────────────┐         ┌─────────────────────┐  │
│   │    Controller     │────────▶│     Repository      │  │
│   │  (LoginController,│         │  (UserRepository,   │  │
│   │   RoomController, │         │   RoomRepository,   │  │
│   │   PatientController)│       │   PatientRepository,│  │
│   │                   │         │   DatabaseInitializer)│ │
│   │  Business rules   │         │  Database access    │  │
│   └─────────┬─────────┘         └──────────┬──────────┘  │
└─────────────┼──────────────────────────────┼─────────────┘
              │                              │
              │ uses                         │ reads/writes
              ▼                              ▼
      ┌──────────────┐              ┌──────────────────┐
      │    Model     │              │   SQLite (.db)   │
      │              │              │                  │
      │  User.cs     │              │  UI/App_Data/    │
      │  Room.cs     │              │  HospitalDB.db   │
      │  Patient.cs  │              │                  │
      └──────────────┘              └──────────────────┘

      ┌──────────────────────────────────────┐
      │              DB Project              │
      │   (SQL scripts — documentation and   │
      │    reference only; runs at runtime   │
      │    through DatabaseInitializer.cs)   │
      └──────────────────────────────────────┘
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
* **Patient Information** — Full add/edit/delete access. Admin can permanently delete a patient **only if they have no admission or billing history**, otherwise the record can only be deactivated. Admin can also reactivate deactivated patients.

### Hospital Staff

The Hospital Staff account has access to hospital staff functions available through the Hospital Staff Main Menu, including:

* **Room Management** — Read-only view of rooms with status filtering.
* **Patient Information** — Add and edit patient records. Staff can **deactivate** a patient (soft delete), but **cannot permanently delete** any record.

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

The **Login**, **Role-Based Main Menu**, **Room Management**, and **Patient Information Maintenance** modules are currently completed.

The remaining modules will be implemented progressively, following the project's feature-branch and pull-request workflow.

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.
