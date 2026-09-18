// ============================================================
// LoginController.cs
// Purpose: Handle the login business logic.
//          - Validates that the fields aren't empty
//          - Asks UserRepository to fetch the user by username
//          - Hashes the entered password
//          - Compares the hash to what's stored in the database
//          - Returns the role (Admin / Hospital Staff) if valid,
//            or a friendly error message if not
//
// This file does NOT talk to the database directly.
// It only talks to the Repository.
// ============================================================

using System;                       // For String, etc.
using System.Security.Cryptography; // For SHA256
using System.Text;                  // For StringBuilder, Encoding
using Model;                        // For the User class
using BusinessLogic.Repository;     // For UserRepository

namespace BusinessLogic.Controller
{
    /// <summary>
    /// Controller for all login-related logic.
    /// Called by LoginForm when the user clicks "Log In".
    /// </summary>
    public class LoginController
    {
        // A single repository instance shared across all methods in this class.
        // 'readonly' = assigned once, never changed.
        private readonly UserRepository userRepository = new UserRepository();

        // ------------------------------------------------------------
        // Login
        // Input:  username (what the user typed)
        //         password (what the user typed, in plain text)
        // Output: a string —
        //           "Admin"            -> login successful, admin
        //           "Hospital Staff"   -> login successful, staff
        //           "..."              -> an error message (see below)
        // ------------------------------------------------------------
        public string Login(string username, string password)
        {
            // ---- STEP 1: Validate that both fields are filled ----
            // If either is null, empty, or just whitespace, reject it.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Please fill in all fields";
            }

            // ---- STEP 2: Look up the user by username ----
            // We trim the username to remove accidental spaces.
            // The repository will return null if the user doesn't exist.
            User user = userRepository.GetUserByUsername(username.Trim());

            if (user == null)
            {
                // Username not found. Return a generic error so attackers
                // can't tell if the username exists or the password was wrong.
                return "Invalid username or password";
            }

            // ---- STEP 3: Check if the account is active ----
            // Deactivated accounts can't log in.
            if (!user.IsActive)
            {
                return "Account is inactive. Please contact the administrator.";
            }

            // ---- STEP 4: Hash the entered password ----
            // We hash the plain-text password the user typed, using the
            // same SHA256 algorithm used to create the stored hash.
            string enteredHash = HashPassword(password);

            // ---- STEP 5: Compare the hashes ----
            // If the hashes don't match, the password was wrong.
            // We use OrdinalIgnoreCase to be tolerant of case in hex digits.
            if (!string.Equals(enteredHash, user.PasswordHash, StringComparison.OrdinalIgnoreCase))
            {
                return "Invalid username or password";
            }

            // ---- STEP 6: Success! Return the user's role ----
            // The UI will use this to decide which menu tiles to show.
            return user.Role;   // "Admin" or "Hospital Staff"
        }

        // ------------------------------------------------------------
        // HashPassword
        // Input:  a plain-text password
        // Output: its SHA256 hash, in uppercase hex
        //
        // 'static' so it can be called without creating a LoginController.
        // Example: LoginController.HashPassword("admin123")
        //
        // Why SHA256?
        //   - It's a one-way function: you can hash a password, but you
        //     can't reverse the hash back to the password.
        //   - It always produces the same output for the same input, so
        //     we can compare hashes during login.
        // ------------------------------------------------------------
        public static string HashPassword(string password)
        {
            // Create a SHA256 hashing object.
            using (SHA256 sha = SHA256.Create())
            {
                // Convert the password string into bytes (UTF-8 encoding),
                // then run those bytes through SHA256.
                // Result: a 32-byte hash.
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Build a hex string from the bytes.
                // Each byte becomes two uppercase hex characters,
                // producing a 64-character hash string.
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("X2"));  // "X2" = uppercase hex, 2 digits
                }

                return builder.ToString();
            }
        }
    }
}

