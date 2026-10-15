-- Seed 50 sample patients for testing.
-- Covers all guardian scenarios:
--   - Adult with family present
--   - Adult alone (self-guardian)
--   - Minor with parent
--   - Elderly with social worker fallback
-- A few are marked Inactive (IsActive = 0) to test the Active/Inactive filter.

INSERT INTO Patients
(PatientCode, FirstName, MiddleName, LastName, DateOfBirth, Gender,
 ContactNumber, Address, CivilStatus, Occupation,
 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress, GuardianPresent,
 EmergencyContactName, EmergencyContactNumber,
 IsActive)
VALUES
-- ===== P-0001 to P-0010: Adults with family =====
('P-0001', 'Juan', 'Ramos', 'Dela Cruz', '1990-03-12', 'Male',
 '0917-123-4567', '123 Rizal St., Imus, Cavite', 'Married', 'Teacher',
 'Elena Dela Cruz', 'Spouse', '0917-999-1234', '123 Rizal St., Imus, Cavite', 1,
 'Pedro Dela Cruz', '0918-555-7890', 1),

('P-0002', 'Maria', 'Lopez', 'Santos', '1985-07-22', 'Female',
 '0918-555-2211', '45 Mabini Ave., Bacoor, Cavite', 'Married', 'Nurse',
 'Jose Santos', 'Spouse', '0918-555-9999', '45 Mabini Ave., Bacoor, Cavite', 1,
 'Ana Santos', '0918-777-1234', 1),

('P-0003', 'Carlos', 'Bautista', 'Reyes', '1978-11-02', 'Male',
 '0920-444-7788', '78 Luna St., Dasmarinas, Cavite', 'Married', 'Engineer',
 'Linda Reyes', 'Spouse', '0920-444-0000', '78 Luna St., Dasmarinas, Cavite', 1,
 'Antonio Reyes', '0920-444-1111', 1),

('P-0004', 'Liza', 'Cruz', 'Garcia', '1976-01-30', 'Female',
 '0916-321-9090', '12 Bonifacio Rd., Bacoor, Cavite', 'Widowed', 'Retired',
 'Rosa Garcia', 'Parent', '0916-321-0000', '12 Bonifacio Rd., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0005', 'Ramon', 'Cruz', 'Bautista', '1960-05-15', 'Male',
 '0919-222-3344', '9 Mabuhay St., Imus, Cavite', 'Married', 'Farmer',
 'Rosa Bautista', 'Spouse', '0919-222-5566', '9 Mabuhay St., Imus, Cavite', 1,
 NULL, NULL, 1),

('P-0006', 'Ana', 'Reyes', 'Mendoza', '1992-08-17', 'Female',
 '0917-555-1010', '22 Acacia St., Bacoor, Cavite', 'Single', 'Accountant',
 'Pedro Mendoza', 'Parent', '0917-555-2020', '22 Acacia St., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0007', 'Miguel', 'Torres', 'Villanueva', '1988-04-25', 'Male',
 '0918-777-3030', '5 Sampaguita St., Imus, Cavite', 'Married', 'Driver',
 'Carla Villanueva', 'Spouse', '0918-777-4040', '5 Sampaguita St., Imus, Cavite', 1,
 NULL, NULL, 1),

('P-0008', 'Sofia', 'Cruz', 'Navarro', '1995-12-03', 'Female',
 '0919-333-5050', '88 Katipunan St., Dasmarinas, Cavite', 'Single', 'Call Center',
 'Mario Navarro', 'Parent', '0919-333-6060', '88 Katipunan St., Dasmarinas, Cavite', 1,
 NULL, NULL, 1),

('P-0009', 'Diego', 'Luna', 'Aquino', '1972-06-14', 'Male',
 '0920-111-7070', '14 Bonifacio Ave., Bacoor, Cavite', 'Married', 'Businessman',
 'Isabel Aquino', 'Spouse', '0920-111-8080', '14 Bonifacio Ave., Bacoor, Cavite', 1,
 'Rafael Aquino', '0920-111-9090', 1),

('P-0010', 'Isabella', 'Ramos', 'Castro', '1983-09-09', 'Female',
 '0917-222-1212', '30 Mabini St., Imus, Cavite', 'Married', 'Doctor',
 'Andres Castro', 'Spouse', '0917-222-1313', '30 Mabini St., Imus, Cavite', 1,
 NULL, NULL, 1),

-- ===== P-0011 to P-0020: Adults alone (self-guardian) =====
('P-0011', 'Roberto', NULL, 'Silva', '1990-02-28', 'Male',
 '0918-444-1414', '3 Rizal St., Bacoor, Cavite', 'Single', 'Seaman',
 'Self — Patient arrived alone', 'Self', '0918-444-1414', NULL, 0,
 NULL, NULL, 1),

('P-0012', 'Patricia', NULL, 'Domingo', '1993-11-19', 'Female',
 '0919-555-1515', '60 Luna St., Imus, Cavite', 'Single', 'Freelancer',
 'Self — Patient arrived alone', 'Self', '0919-555-1515', NULL, 0,
 NULL, NULL, 1),

('P-0013', 'Fernando', 'Reyes', 'Aguilar', '1987-07-07', 'Male',
 '0920-666-1616', '11 Acacia St., Dasmarinas, Cavite', 'Single', 'Programmer',
 'Self — Patient arrived alone', 'Self', '0920-666-1616', NULL, 0,
 NULL, NULL, 1),

('P-0014', 'Cristina', NULL, 'Pascual', '1991-05-21', 'Female',
 '0917-888-1717', '25 Sampaguita St., Bacoor, Cavite', 'Single', 'Barista',
 'Self — Patient arrived alone', 'Self', '0917-888-1717', NULL, 0,
 NULL, NULL, 1),

('P-0015', 'Marco', 'Santos', 'Fernandez', '1989-03-15', 'Male',
 '0918-999-1818', '7 Katipunan St., Imus, Cavite', 'Single', 'Architect',
 'Self — Patient arrived alone', 'Self', '0918-999-1818', NULL, 0,
 NULL, NULL, 1),

('P-0016', 'Diana', NULL, 'Romero', '1994-09-04', 'Female',
 '0919-000-1919', '50 Bonifacio Ave., Dasmarinas, Cavite', 'Single', 'Teacher',
 'Self — Patient arrived alone', 'Self', '0919-000-1919', NULL, 0,
 NULL, NULL, 1),

('P-0017', 'Victor', 'Lopez', 'Salazar', '1986-12-12', 'Male',
 '0920-222-2020', '33 Mabini St., Bacoor, Cavite', 'Single', 'Salesman',
 'Self — Patient arrived alone', 'Self', '0920-222-2020', NULL, 0,
 NULL, NULL, 1),

('P-0018', 'Beatrice', NULL, 'Gonzales', '1996-06-30', 'Female',
 '0917-444-2121', '19 Rizal St., Imus, Cavite', 'Single', 'Student',
 'Self — Patient arrived alone', 'Self', '0917-444-2121', NULL, 0,
 NULL, NULL, 1),

('P-0019', 'Eduardo', 'Reyes', 'Mercado', '1982-08-08', 'Male',
 '0918-666-2222', '42 Luna St., Dasmarinas, Cavite', 'Single', 'Chef',
 'Self — Patient arrived alone', 'Self', '0918-666-2222', NULL, 0,
 NULL, NULL, 1),

('P-0020', 'Jasmine', NULL, 'Vargas', '1990-10-10', 'Female',
 '0919-888-2323', '16 Acacia St., Bacoor, Cavite', 'Single', 'Designer',
 'Self — Patient arrived alone', 'Self', '0919-888-2323', NULL, 0,
 NULL, NULL, 1),

-- ===== P-0021 to P-0030: Minors with parents =====
('P-0021', 'Carlo', 'Bautista', 'Reyes', '2015-11-02', 'Male',
 '0920-444-2424', '78 Luna St., Dasmarinas, Cavite', 'Single', 'Student',
 'Rosario Reyes', 'Parent', '0920-444-2525', '78 Luna St., Dasmarinas, Cavite', 1,
 'Antonio Reyes', '0920-444-2626', 1),

('P-0022', 'Sofia', 'Cruz', 'Mendoza', '2018-03-20', 'Female',
 '0917-555-2727', '22 Acacia St., Bacoor, Cavite', 'Single', 'Student',
 'Pedro Mendoza', 'Parent', '0917-555-2828', '22 Acacia St., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0023', 'Liam', 'Garcia', 'Torres', '2016-07-11', 'Male',
 '0918-777-2929', '5 Sampaguita St., Imus, Cavite', 'Single', 'Student',
 'Carla Torres', 'Parent', '0918-777-3031', '5 Sampaguita St., Imus, Cavite', 1,
 NULL, NULL, 1),

('P-0024', 'Emma', 'Reyes', 'Navarro', '2019-01-25', 'Female',
 '0919-333-3131', '88 Katipunan St., Dasmarinas, Cavite', 'Single', 'Student',
 'Mario Navarro', 'Parent', '0919-333-3232', '88 Katipunan St., Dasmarinas, Cavite', 1,
 NULL, NULL, 1),

('P-0025', 'Noah', 'Luna', 'Aquino', '2014-05-30', 'Male',
 '0920-111-3333', '14 Bonifacio Ave., Bacoor, Cavite', 'Single', 'Student',
 'Isabel Aquino', 'Parent', '0920-111-3434', '14 Bonifacio Ave., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0026', 'Olivia', 'Ramos', 'Castro', '2017-09-14', 'Female',
 '0917-222-3535', '30 Mabini St., Imus, Cavite', 'Single', 'Student',
 'Andres Castro', 'Parent', '0917-222-3636', '30 Mabini St., Imus, Cavite', 1,
 NULL, NULL, 1),

('P-0027', 'Lucas', 'Silva', 'Domingo', '2013-02-18', 'Male',
 '0918-444-3737', '3 Rizal St., Bacoor, Cavite', 'Single', 'Student',
 'Roberto Silva', 'Parent', '0918-444-3838', '3 Rizal St., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0028', 'Mia', 'Aguilar', 'Pascual', '2020-06-08', 'Female',
 '0919-555-3939', '11 Acacia St., Dasmarinas, Cavite', 'Single', 'Student',
 'Fernando Aguilar', 'Parent', '0919-555-4040', '11 Acacia St., Dasmarinas, Cavite', 1,
 NULL, NULL, 1),

('P-0029', 'Ethan', 'Fernandez', 'Romero', '2012-04-22', 'Male',
 '0920-666-4141', '60 Luna St., Imus, Cavite', 'Single', 'Student',
 'Marco Fernandez', 'Parent', '0920-666-4242', '60 Luna St., Imus, Cavite', 1,
 NULL, NULL, 1),

('P-0030', 'Ava', 'Salazar', 'Gonzales', '2016-12-01', 'Female',
 '0917-888-4343', '25 Sampaguita St., Bacoor, Cavite', 'Single', 'Student',
 'Victor Salazar', 'Parent', '0917-888-4444', '25 Sampaguita St., Bacoor, Cavite', 1,
 NULL, NULL, 1),

-- ===== P-0031 to P-0040: Elderly with social worker =====
('P-0031', 'Ernesto', NULL, 'Pascual', '1948-03-30', 'Male',
 '0918-999-4545', '7 Katipunan St., Imus, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0032', 'Corazon', 'Reyes', 'Aguilar', '1950-08-15', 'Female',
 '0919-000-4646', '50 Bonifacio Ave., Dasmarinas, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0033', 'Gregorio', NULL, 'Silva', '1945-12-25', 'Male',
 '0920-222-4747', '33 Mabini St., Bacoor, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0034', 'Rosario', 'Cruz', 'Mendoza', '1952-07-04', 'Female',
 '0917-444-4848', '19 Rizal St., Imus, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0035', 'Alfredo', NULL, 'Torres', '1947-05-20', 'Male',
 '0918-666-4949', '42 Luna St., Dasmarinas, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0036', 'Teresita', 'Ramos', 'Navarro', '1955-01-12', 'Female',
 '0919-888-5050', '16 Acacia St., Bacoor, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0037', 'Rodolfo', NULL, 'Aquino', '1943-09-03', 'Male',
 '0920-333-5151', '88 Katipunan St., Dasmarinas, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0038', 'Luzviminda', 'Santos', 'Castro', '1958-11-28', 'Female',
 '0917-555-5252', '30 Mabini St., Imus, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0039', 'Benjamin', NULL, 'Domingo', '1944-06-17', 'Male',
 '0918-777-5353', '5 Sampaguita St., Imus, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

('P-0040', 'Amparo', 'Luna', 'Vargas', '1953-04-09', 'Female',
 '0919-333-5454', '14 Bonifacio Ave., Bacoor, Cavite', 'Widowed', 'Retired',
 'Hospital Social Worker', 'Social Worker', '02-8888-1234', NULL, 0,
 NULL, NULL, 1),

-- ===== P-0041 to P-0045: Adults with various guardians =====
('P-0041', 'Renato', 'Cruz', 'Estrella', '1980-02-14', 'Male',
 '0920-555-5555', '23 Rizal St., Dasmarinas, Cavite', 'Married', 'Engineer',
 'Lorna Estrella', 'Spouse', '0920-555-5656', '23 Rizal St., Dasmarinas, Cavite', 1,
 NULL, NULL, 1),

('P-0042', 'Milagros', 'Reyes', 'Buenaventura', '1975-10-22', 'Female',
 '0917-666-5757', '17 Acacia St., Bacoor, Cavite', 'Married', 'Nurse',
 'Ricardo Buenaventura', 'Spouse', '0917-666-5858', '17 Acacia St., Bacoor, Cavite', 1,
 NULL, NULL, 1),

('P-0043', 'Arturo', NULL, 'Manalo', '1968-08-08', 'Male',
 '0918-888-5959', '9 Sampaguita St., Imus, Cavite', 'Married', 'Businessman',
 'Cecilia Manalo', 'Spouse', '0918-888-6060', '9 Sampaguita St., Imus, Cavite', 1,
 'Jose Manalo', '0918-888-6161', 1),

('P-0044', 'Nena', 'Santos', 'Villanueva', '1983-01-19', 'Female',
 '0919-999-6262', '55 Katipunan St., Dasmarinas, Cavite', 'Married', 'Teacher',
 'Paolo Villanueva', 'Spouse', '0919-999-6363', '55 Katipunan St., Dasmarinas, Cavite', 1,
 NULL, NULL, 1),

('P-0045', 'Rogelio', 'Cruz', 'Torres', '1970-05-05', 'Male',
 '0920-111-6464', '12 Bonifacio Ave., Bacoor, Cavite', 'Married', 'Driver',
 'Marites Torres', 'Spouse', '0920-111-6565', '12 Bonifacio Ave., Bacoor, Cavite', 1,
 NULL, NULL, 1),

-- ===== P-0046 to P-0050: Inactive patients (IsActive = 0) =====
('P-0046', 'Rico', 'Bautista', 'Yan', '1987-09-12', 'Male',
 '0917-321-6666', '3 Acacia St., Imus, Cavite', 'Single', 'Vendor',
 'Self — Patient arrived alone', 'Self', '0917-321-6666', NULL, 0,
 NULL, NULL, 0),

('P-0047', 'Marcela', NULL, 'Rosales', '1990-12-04', 'Female',
 '0918-432-6767', '7 Sampaguita St., Bacoor, Cavite', 'Single', 'Cashier',
 'Self — Patient arrived alone', 'Self', '0918-432-6767', NULL, 0,
 NULL, NULL, 0),

('P-0048', 'Danilo', 'Reyes', 'Pascual', '1985-04-15', 'Male',
 '0919-543-6868', '19 Katipunan St., Dasmarinas, Cavite', 'Single', 'Welder',
 'Self — Patient arrived alone', 'Self', '0919-543-6868', NULL, 0,
 NULL, NULL, 0),

('P-0049', 'Evelyn', NULL, 'Mendoza', '1993-06-27', 'Female',
 '0920-654-6969', '41 Rizal St., Imus, Cavite', 'Single', 'Saleslady',
 'Self — Patient arrived alone', 'Self', '0920-654-6969', NULL, 0,
 NULL, NULL, 0),

('P-0050', 'Isagani', 'Cruz', 'Vargas', '1979-11-11', 'Male',
 '0917-765-7070', '25 Luna St., Bacoor, Cavite', 'Married', 'Fisherman',
 'Luz Vargas', 'Spouse', '0917-765-7171', '25 Luna St., Bacoor, Cavite', 1,
 NULL, NULL, 0);