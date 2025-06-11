USE HospitalDB;

CREATE TABLE Ward
(
    WardID INT PRIMARY KEY IDENTITY,
    Type VARCHAR(100),
    Capacity INT
);

CREATE TABLE Patients
(
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Gender NVARCHAR(10),
    DOB DATE,
    Phone NVARCHAR(20),
    Address NVARCHAR(200)
);


CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Specializations
(
    SpecializationID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL
);


CREATE TABLE Doctors
(
    DoctorID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Gender NVARCHAR(10),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    SpecializationID INT FOREIGN KEY REFERENCES Specializations(SpecializationID),
    Address NVARCHAR(200),
    JoiningDate DATE
);


CREATE TABLE Appointments
(
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    DoctorID INT FOREIGN KEY REFERENCES Doctors(DoctorID),
    AppointmentDate DATE,
    AppointmentTime TIME,
    Status NVARCHAR(20),
    Notes NVARCHAR(500)
);


CREATE TABLE Admission
(
    AdmissionID INT PRIMARY KEY IDENTITY,
    PatientID INT,
    WardID INT,
    AdmissionDate DATE,
    DischargeDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (WardID) REFERENCES Ward(WardID)
);

CREATE TABLE Treatment
(
    TreatmentID INT PRIMARY KEY IDENTITY,
    AdmissionID INT,
    AppointmentID INT,
    Description TEXT,
    Date DATE,
    DoctorID INT,
    FOREIGN KEY (AdmissionID) REFERENCES Admission(AdmissionID),
    FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);


CREATE TABLE Medicine
(
    MedicineID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Type VARCHAR(50),
    PricePerUnit DECIMAL(10,2)
);


CREATE TABLE Prescription
(
    PrescriptionID INT PRIMARY KEY IDENTITY,
    TreatmentID INT,
    MedicineID INT,
    Dosage VARCHAR(100),
    Duration VARCHAR(100),
    FOREIGN KEY (TreatmentID) REFERENCES Treatment(TreatmentID),
    FOREIGN KEY (MedicineID) REFERENCES Medicine(MedicineID)
);

CREATE TABLE Bill
(
    BillID INT PRIMARY KEY IDENTITY,
    PatientID INT,
    Amount DECIMAL(10,2),
    BillDate DATE,
    Status VARCHAR(50),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

CREATE TABLE Payment
(
    PaymentID INT PRIMARY KEY IDENTITY,
    BillID INT,
    PaymentDate DATE,
    AmountPaid DECIMAL(10,2),
    Method VARCHAR(50),
    FOREIGN KEY (BillID) REFERENCES Bill(BillID)
);



SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Patients';

-- Departments
INSERT INTO Departments (Name) VALUES 
('Cardiology'), ('Neurology'), ('Pediatrics'), ('Orthopedics');

-- Specializations
INSERT INTO Specializations (Title) VALUES 
('Surgeon'), ('Physician'), ('Radiologist'), ('Dermatologist');


Select * From Doctors;

Select * From Patients;

Select * From Appointments;


ALTER TABLE Bill
ADD 
    TreatmentID INT NULL,
    AdmissionID INT NULL,
    DoctorID INT NULL,
    Discount DECIMAL(10,2) DEFAULT 0,
    Tax DECIMAL(10,2) DEFAULT 0,
    Notes NVARCHAR(255) NULL,
    TotalAmount AS (Amount - Discount + Tax) PERSISTED,
    CONSTRAINT FK_Bill_Treatment FOREIGN KEY (TreatmentID) REFERENCES Treatment(TreatmentID),
    CONSTRAINT FK_Bill_Admission FOREIGN KEY (AdmissionID) REFERENCES Admission(AdmissionID),
    CONSTRAINT FK_Bill_Doctor FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID);




	-- ============================
-- PATIENTS
-- ============================
-- CREATE
INSERT INTO Patients (Name, Gender, DOB, Phone, Address)
VALUES ('Ali Raza', 'Male', '2000-04-15', '03001234567', 'Lahore');

-- READ
SELECT * FROM Patients;

-- UPDATE
UPDATE Patients
SET Phone = '03007654321'
WHERE PatientID = 1;

-- DELETE
DELETE FROM Patients
WHERE PatientID = 1;


-- ============================
-- DOCTORS
-- ============================
-- CREATE
INSERT INTO Doctors (Name, Gender, Phone, Email, DepartmentID, SpecializationID, Address, JoiningDate)
VALUES ('Dr. Sara', 'Female', '03211234567', 'sara@example.com', 1, 2, 'Multan', '2024-01-10');

-- READ
SELECT * FROM Doctors;

-- UPDATE
UPDATE Doctors
SET Email = 'sara.ahmed@clinic.com'
WHERE DoctorID = 1;

-- DELETE
DELETE FROM Doctors
WHERE DoctorID = 1;


-- ============================
-- APPOINTMENTS
-- ============================
-- CREATE
INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, Status, Notes)
VALUES (2, 1, '2024-06-10', '14:30:00', 'Pending', 'Follow-up visit');

-- READ
SELECT * FROM Appointments;

-- UPDATE
UPDATE Appointments
SET Status = 'Completed'
WHERE AppointmentID = 1;

-- DELETE
DELETE FROM Appointments
WHERE AppointmentID = 1;


-- ============================
-- ADMISSION
-- ============================
-- CREATE
INSERT INTO Admission (PatientID, WardID, AdmissionDate, DischargeDate)
VALUES (2, 1, '2024-06-05', NULL);

-- READ
SELECT * FROM Admission;

-- UPDATE
UPDATE Admission
SET DischargeDate = '2024-06-10'
WHERE AdmissionID = 1;

-- DELETE
DELETE FROM Admission
WHERE AdmissionID = 1;


-- ============================
-- TREATMENT
-- ============================
-- CREATE
INSERT INTO Treatment (AdmissionID, AppointmentID, Description, Date, DoctorID)
VALUES (1, 2, 'IV fluids and monitoring', '2024-06-06', 1);

-- READ
SELECT * FROM Treatment;

-- UPDATE
UPDATE Treatment
SET Description = 'Updated treatment plan'
WHERE TreatmentID = 1;

-- DELETE
DELETE FROM Treatment
WHERE TreatmentID = 1;


-- ============================
-- MEDICINE
-- ============================
-- CREATE
INSERT INTO Medicine (Name, Type, PricePerUnit)
VALUES ('Paracetamol', 'Tablet', 5.00);

-- READ
SELECT * FROM Medicine;

-- UPDATE
UPDATE Medicine
SET PricePerUnit = 6.00
WHERE MedicineID = 1;

-- DELETE
DELETE FROM Medicine
WHERE MedicineID = 1;


-- ============================
-- PRESCRIPTION
-- ============================
-- CREATE
INSERT INTO Prescription (TreatmentID, MedicineID, Dosage, Duration)
VALUES (1, 1, '1 tablet twice a day', '5 days');

-- READ
SELECT * FROM Prescription;

-- UPDATE
UPDATE Prescription
SET Dosage = '1 tablet three times a day'
WHERE PrescriptionID = 1;

-- DELETE
DELETE FROM Prescription
WHERE PrescriptionID = 1;


-- ============================
-- BILL
-- ============================
-- CREATE
INSERT INTO Bill (PatientID, Amount, BillDate, Status)
VALUES (2, 1500.00, '2024-06-07', 'Unpaid');

-- READ
SELECT * FROM Bill;

-- UPDATE
UPDATE Bill
SET Status = 'Paid'
WHERE BillID = 1;

-- DELETE
DELETE FROM Bill
WHERE BillID = 1;


-- ============================
-- PAYMENT
-- ============================
-- CREATE
INSERT INTO Payment (BillID, PaymentDate, AmountPaid, Method)
VALUES (1, '2024-06-07', 1500.00, 'Cash');

-- READ
SELECT * FROM Payment;

-- UPDATE
UPDATE Payment
SET Method = 'Credit Card'
WHERE PaymentID = 1;

-- DELETE
DELETE FROM Payment
WHERE PaymentID = 1;
