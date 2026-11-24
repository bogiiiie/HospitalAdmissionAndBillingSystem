-- Seed initial users for testing
-- Passwords are SHA256 hashes, NOT plain text.
--
--   admin01  → admin123 (Lebron James)
--   areyes   → staff123 (Anna Reyes)

INSERT INTO Users (Username, PasswordHash, FullName, Role, IsActive) VALUES
('admin01',
 '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9',
 'Lebron James',
 'Admin',
 1),

('areyes',
 '10176E7B7B24D317ACFCF8D2064CFD2F24E154F7B5A96603077D5EF813D6A6B6',
 'Anna Reyes',
 'Hospital Staff',
 1);