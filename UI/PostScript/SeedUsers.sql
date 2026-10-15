-- Seed initial users for testing
-- Passwords are SHA256 hashes, NOT plain text.
--
--   admin01  → admin123
--   areyes   → staff123

INSERT INTO Users (Username, PasswordHash, Role, IsActive) VALUES
('admin01',
 '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9',
 'Admin',
 1),

('areyes',
 '10176E7B7B24D317ACFCF8D2064CFD2F24E154F7B5A96603077D5EF813D6A6B6',
 'Hospital Staff',
 1);