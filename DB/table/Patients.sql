-- Patients table for Hospital Admission and Billing System
-- SQLite syntax.

CREATE TABLE IF NOT EXISTS Patients (
    PatientID INTEGER PRIMARY KEY AUTOINCREMENT,
    PatientCode TEXT NOT NULL UNIQUE,
    FirstName TEXT NOT NULL,
    MiddleName TEXT,
    LastName TEXT NOT NULL,
    DateOfBirth TEXT NOT NULL,
    Gender TEXT NOT NULL,
    ContactNumber TEXT NOT NULL,
    Address TEXT,
    CivilStatus TEXT,
    Occupation TEXT,

    GuardianName TEXT,
    GuardianRelationship TEXT,
    GuardianContact TEXT,
    GuardianAddress TEXT,
    GuardianPresent INTEGER NOT NULL DEFAULT 0,

    EmergencyContactName TEXT,
    EmergencyContactNumber TEXT,

    IsFullyRegistered INTEGER NOT NULL DEFAULT 1, -- NEW: 1 = Yes, 0 = Unconscious/Incomplete
    IsActive INTEGER NOT NULL DEFAULT 1,
    CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
);