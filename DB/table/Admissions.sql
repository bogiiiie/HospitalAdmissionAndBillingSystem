-- Admissions table for Hospital Admission and Billing System
-- SQLite syntax.

CREATE TABLE IF NOT EXISTS Admissions (
    AdmissionID     INTEGER PRIMARY KEY AUTOINCREMENT,
    AdmissionCode   TEXT NOT NULL UNIQUE,
    PatientCode     TEXT NOT NULL,
    RoomNumber      TEXT NOT NULL,
    BedName         TEXT NOT NULL, -- NEW
    AdmissionDate   TEXT NOT NULL,
    Diagnosis       TEXT NOT NULL,
    LockedRate      REAL NOT NULL,
    Status          TEXT NOT NULL DEFAULT 'Admitted',
    AdmittedBy      TEXT NOT NULL,
    DischargeDate   TEXT,
    DischargeNotes  TEXT,
    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
);