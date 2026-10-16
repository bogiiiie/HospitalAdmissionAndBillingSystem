-- Admissions table for Hospital Admission and Billing System
-- SQLite syntax.
-- AdmissionCode is the display ID ("ADM-0001") — auto-generated in code.
-- LockedRate captures the room's rate at admission time so later rate
-- changes in Room Management don't affect this stay.
-- Status = 'Admitted' while the patient is in the hospital,
--          'Discharged' once the Discharge module has run.

CREATE TABLE IF NOT EXISTS Admissions (
    AdmissionID     INTEGER PRIMARY KEY AUTOINCREMENT,
    AdmissionCode   TEXT NOT NULL UNIQUE,
    PatientCode     TEXT NOT NULL,
    RoomNumber      TEXT NOT NULL,
    AdmissionDate   TEXT NOT NULL,
    Diagnosis       TEXT NOT NULL,
    LockedRate      REAL NOT NULL,
    Status          TEXT NOT NULL DEFAULT 'Admitted',
    AdmittedBy      TEXT NOT NULL,
    DischargeDate   TEXT,
    DischargeNotes  TEXT,
    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
);