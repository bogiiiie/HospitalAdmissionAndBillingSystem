-- Rooms table for Hospital Admission and Billing System
-- SQLite syntax. Each room has exactly one bed.

CREATE TABLE IF NOT EXISTS Rooms (
    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
    RoomNumber TEXT NOT NULL UNIQUE,
    RoomType TEXT NOT NULL,
    Rate REAL NOT NULL,
    Status TEXT NOT NULL DEFAULT 'Available'
);