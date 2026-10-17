# 👥 User Management Module

**Language:** C# (.NET Framework 4.7.2) · **UI:** Windows Forms · **Database:** SQLite

The **User Management** module is an Admin-only utility screen. It allows the Admin to view all system accounts and reset passwords for Hospital Staff who may be locked out. The module ensures that all new passwords are securely hashed using SHA256 before being saved to the database. Built on the same layered architecture as the earlier modules: **Model → BusinessLogic → DB → UI**.

---

## 📦 User Stories in This Branch

| ID | Title | Status |
|----|-------|--------|
| US-014 | User Management (Admin) | ✅ Done |

---

## 📖 US-014 — User Management

**User Story:**
As an Admin, I want to view all system users and reset their passwords so that I can help Hospital Staff who are locked out of their accounts.

**Acceptance Criteria:**
- [x] The User Management screen is strictly Admin-only; Hospital Staff cannot see the tile or sidebar link.
- [x] Admin can view a grid listing all users (Username, Role, Status).
- [x] Admin can select a user and reset their password.
- [x] New passwords must be hashed using SHA256 before being saved to the database.
- [x] Admin accounts cannot be reset from this screen (only Hospital Staff can be reset).
- [x] A confirmation dialog appears prompting for the new password and confirmation.

**Development Tasks:**
- [x] Design `UserManagementForm` layout (read-only grid + fixed-width reset action buttons) — Lynet
- [x] Implement `UserManagementForm.cs` logic (grid loading, custom cell painting, click handling) — Luster
- [x] Design `ResetPasswordDialog` layout — Lynet
- [x] Implement `ResetPasswordDialog.cs` logic (password matching validation) — Luster
- [x] Wire the User Management tile in `AdminMenuForm` — Stephen
- [x] Hide the module entirely from Hospital Staff (no sidebar or menu tile) — Stephen
- [x] Add validation to prevent Admin from resetting another Admin's password — Luster

**Backend / Database Tasks:**
- [x] Add `GetAllUsers()` to `UserRepository` — Stephen
- [x] Add `UpdatePassword()` to `UserRepository` — Stephen
- [x] Add `GetAllUsers()` and `ResetPassword()` to `UserController` — Stephen
- [x] Implement SHA256 hashing for the new password in the controller — Stephen

**Testing Tasks:**
- [x] Test that Admin sees the User Management module — Lynet, Luster
- [x] Test that Staff does NOT see the module — Lynet, Luster
- [x] Test resetting a staff password and logging in with the new password — Lynet, Luster
- [x] Test that the new password is stored as a SHA256 hash in the database — Lynet, Luster
- [x] Test that the "Reset Password" button is hidden for Admin accounts — Lynet, Luster

---

## 🗂️ Solution Structure (Files Added / Modified)

### New Files

| # | File | Purpose |
|---|------|---------|
| 1 | `UI/UserManagementForm.cs` / `.Designer.cs` | Main UI showing the list of users |
| 2 | `UI/ResetPasswordDialog.cs` / `.Designer.cs` | Modal dialog for entering the new password |

### Modified Files

| # | File | Change |
|---|------|--------|
| 3 | `BusinessLogic/Repository/UserRepository.cs` | Added `GetAllUsers()` and `UpdatePassword()` |
| 4 | `BusinessLogic/Controller/UserController.cs` | Added SHA256 hashing and `ResetPassword()` |
| 5 | `AdminMenuForm.cs` / `.Designer.cs` | Added and wired the "User Mgmt" tile |

*(Note: No changes were made to the 11 sidebar forms. As per the PDF requirements, User Management is an Admin utility accessed only via the Main Menu tile, not the sidebar).*

---

## 📁 Purpose of Each New File

| File | Purpose |
|------|---------|
| `UI/UserManagementForm.cs` | Displays the grid of users and handles the custom-painted "Reset Password" buttons |
| `UI/ResetPasswordDialog.cs` | A modal that securely captures the new password and confirmation |

---

## 🎨 Form Layout

### `UserManagementForm`
- **Sidebar**: Standard sidebar (but without a "User Management" button, since you're already on the screen).
- **Toolbar**: None. The grid takes up the main space.
- **Grid**:
  - Columns: Username, Role, Status, Actions.
  - The `Actions` column is fixed to a narrower width (15%) and contains a custom-painted "Reset Password" button (106x32 pixels, aligned left).
  - The button only appears on rows where the Role is `Hospital Staff`.

### `ResetPasswordDialog`
- Modal popup.
- Two masked textboxes (New Password, Confirm Password).
- **Save** and **Cancel** buttons.
- Validates that the password is at least 6 characters and both fields match.

---

## 🔄 Data Flow

### Resetting a Password

1. **Admin** opens the User Management screen from the Main Menu.
2. Form calls `UserController.GetAllUsers()` and populates the grid.
3. **Admin** clicks **Reset Password** on a Hospital Staff row.
4. `ResetPasswordDialog` opens.
5. **Admin** enters the new password twice and clicks **Save**.
6. `UserController.ResetPassword()` is called.
7. The controller validates the password length and uses `SHA256.Create()` to hash the password into a 64-character hexadecimal string.
8. `UserRepository.UpdatePassword()` runs an `UPDATE` query on the `Users` table, saving the hash.
9. Success message is displayed, and the dialog closes.

---

## 🗄️ Database

**No new tables.** This module interacts directly with the existing `Users` table created in US-002.

**Update Query used:**
```sql
UPDATE Users SET PasswordHash = @Hash WHERE Username = @User;
```

---

## 👥 Team Contributions (User Management)

| Member | GitHub | Contribution |
|--------|--------|--------------|
| Stephen William De Jesus | [@bogiiiie](https://github.com/bogiiiie) | Backend (`UserRepository`, `UserController` SHA256 logic), AdminMenu wiring, Module access restriction |
| Lynet Cielo | [@lynet-cielo-disputado](https://github.com/lynet-cielo-disputado) | UI Designer (`UserManagementForm.Designer.cs`, `ResetPasswordDialog.Designer.cs`) |
| Luster Tamanu Mangaliman | [@lstrmangaliman-hue](https://github.com/lstrmangaliman-hue) | UI Code-Behind (`UserManagementForm.cs`, `ResetPasswordDialog.cs`), Custom cell painting, Validation logic |
| Neil Jerson Manalo | (pending) | Backend Developer |

---

## ✅ Progress Tracker

### Done

- **US-014 User Management (Admin)** — Fully functional password reset utility with SHA256 security, role-restricted actions, and integration with the Admin Main Menu.

### 🎉 PROJECT COMPLETE

All 14 Core & Optional User Stories/Utilities have been successfully implemented, tested, and merged.

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
1. **Rebuild** the solution.
2. Login with `admin01` / `admin123`.
3. On the Admin Main Menu, click the **User Mgmt** tile.
4. Click **Reset Password** on the `areyes` row.
5. Enter a new password (e.g., `newpass123`), confirm it, and click Save.
6. Logout and login as `areyes` with `newpass123` to verify.

---

## 📋 Summary Table — File Purpose in One Line

| File | Purpose |
|------|---------|
| `UI/UserManagementForm.cs` | Main grid displaying all users and action buttons |
| `UI/ResetPasswordDialog.cs` | Modal popup for securely entering a new password |
| `BusinessLogic/Controller/UserController.cs` | Handles SHA256 hashing and password validation |
| `BusinessLogic/Repository/UserRepository.cs` | SQL queries to fetch users and update passwords |

---

## 📄 License

This project was developed as part of the **BT3101** academic requirements for **Group 4**.