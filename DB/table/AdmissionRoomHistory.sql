-- AdmissionRoomHistory
-- Tracks each room period within an admission so billing can
-- split charges when a patient moves between rooms.
-- The row with EndDate IS NULL is the "current" period.

CREATE TABLE IF NOT EXISTS AdmissionRoomHistory (
    HistoryID       INTEGER PRIMARY KEY AUTOINCREMENT,
    AdmissionCode   TEXT NOT NULL,
    RoomNumber      TEXT NOT NULL,
    RoomType        TEXT NOT NULL,
    Rate            REAL NOT NULL,
    StartDate       TEXT NOT NULL,
    EndDate         TEXT,
    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
);