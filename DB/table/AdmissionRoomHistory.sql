-- AdmissionRoomHistory
-- Tracks each room period within an admission.

CREATE TABLE IF NOT EXISTS AdmissionRoomHistory (
    HistoryID       INTEGER PRIMARY KEY AUTOINCREMENT,
    AdmissionCode   TEXT NOT NULL,
    RoomNumber      TEXT NOT NULL,
    BedName         TEXT NOT NULL, -- NEW
    RoomType        TEXT NOT NULL,
    Rate            REAL NOT NULL,
    StartDate       TEXT NOT NULL,
    EndDate         TEXT,
    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
);