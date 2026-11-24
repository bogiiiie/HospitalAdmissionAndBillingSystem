-- Beds table for Hospital Admission and Billing System
-- Represents the individual beds inside a room.

CREATE TABLE IF NOT EXISTS Beds (
    BedID INTEGER PRIMARY KEY AUTOINCREMENT,
    RoomNumber TEXT NOT NULL,
    BedName TEXT NOT NULL,
    Status TEXT NOT NULL DEFAULT 'Available',
    FOREIGN KEY(RoomNumber) REFERENCES Rooms(RoomNumber)
);