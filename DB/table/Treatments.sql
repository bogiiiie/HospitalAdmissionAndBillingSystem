CREATE TABLE IF NOT EXISTS Treatments (
    TreatmentID     INTEGER PRIMARY KEY AUTOINCREMENT,
    AdmissionCode   TEXT NOT NULL,
    ServiceName     TEXT NOT NULL,
    TreatmentDate   TEXT NOT NULL,
    Quantity        INTEGER NOT NULL,
    UnitCost        REAL NOT NULL,
    TotalCost       REAL NOT NULL,
    RecordedBy      TEXT NOT NULL,
    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
);