-- Patients table for Hospital Admission and Billing System
-- SQLite syntax.
-- PatientCode is the display ID ("P-0001") — auto-generated in code.
-- IsActive = 1 for normal patients, 0 for deactivated (soft-deleted) patients.

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

    -- Guardian / emergency contact
    GuardianName TEXT,
    GuardianRelationship TEXT,
    GuardianContact TEXT,
    GuardianAddress TEXT,
    GuardianPresent INTEGER NOT NULL DEFAULT 0,

    -- Secondary emergency contact
    EmergencyContactName TEXT,
    EmergencyContactNumber TEXT,

    IsActive INTEGER NOT NULL DEFAULT 1,
    CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
);