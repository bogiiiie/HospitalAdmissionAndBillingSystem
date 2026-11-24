-- Rooms table for Hospital Admission and Billing System
-- SQLite syntax. Each room can now have multiple beds.

CREATE TABLE IF NOT EXISTS Rooms (
    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
    RoomNumber TEXT NOT NULL UNIQUE,
    RoomType TEXT NOT NULL,
    Rate REAL NOT NULL,
    Capacity INTEGER NOT NULL DEFAULT 1,
    Status TEXT NOT NULL DEFAULT 'Available'
);