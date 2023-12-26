-- Create database
CREATE DATABASE TourTracer COLLATE Turkish_CI_AS;
GO

-- Use the database
USE TourTracer;
GO

-- create the tbl_User table
CREATE TABLE tbl_Users (
    ID int PRIMARY KEY IDENTITY(1,1),
    FirstName varchar(50) NOT NULL,
    LastName varchar(50) NOT NULL,
    Email varchar(50) NOT NULL CHECK (Email LIKE '%_@_%._%'),
    PhoneNumber varchar(12) NOT NULL,
    Password varchar(50) NOT NULL,
    BirthDate date NOT NULL,
    Role varchar(8) CHECK (Role IN ('Admin', 'Customer', 'Staff')) NOT NULL
);
GO

-- add an admin to the tbl_User table
INSERT INTO tbl_Users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role)
VALUES ('Admin', 'User', 'admin@example.com', '1234567890', 'AdminPassword', '1970-01-01', 'Admin');
GO

CREATE TABLE tbl_Cities (
    PlateNumber int PRIMARY KEY IDENTITY(1,1),
    CityName varchar(30) COLLATE Turkish_CI_AS NOT NULL,
);
GO

-- add cities to the tbl_Cities table
INSERT INTO tbl_Cities (CityName)
VALUES 
('Adana'), ('Adıyaman'), ('Afyon'), ('Ağrı'), ('Amasya'), ('Ankara'), ('Antalya'), ('Artvin'), 
('Aydın'), ('Balıkesir'), ('Bilecik'), ('Bingöl'), ('Bitlis'), ('Bolu'), ('Burdur'), ('Bursa'), 
('Çanakkale'), ('Çankırı'), ('Çorum'), ('Denizli'), ('Diyarbakır'), ('Edirne'), ('Elazığ'), 
('Erzincan'), ('Erzurum'), ('Eskişehir'), ('Gaziantep'), ('Giresun'), ('Gümüşhane'), ('Hakkari'), 
('Hatay'), ('Isparta'), ('Mersin'), ('İstanbul'), ('İzmir'), ('Kars'), ('Kastamonu'), ('Kayseri'), 
('Kırklareli'), ('Kırşehir'), ('Kocaeli'), ('Konya'), ('Kütahya'), ('Malatya'), ('Manisa'), 
('Kahramanmaraş'), ('Mardin'), ('Muğla'), ('Muş'), ('Nevşehir'), ('Niğde'), ('Ordu'), ('Rize'), 
('Sakarya'), ('Samsun'), ('Siirt'), ('Sinop'), ('Sivas'), ('Tekirdağ'), ('Tokat'), ('Trabzon'), 
('Tunceli'), ('Şanlıurfa'), ('Uşak'), ('Van'), ('Yozgat'), ('Zonguldak'), ('Aksaray'), 
('Bayburt'), ('Karaman'), ('Kırıkkale'), ('Batman'), ('Şırnak'), ('Bartın'), ('Ardahan'), 
('Iğdır'), ('Yalova'), ('Karabük'), ('Kilis'), ('Osmaniye'), ('Düzce');
GO

-- create tbl_Tours table
CREATE TABLE tbl_Tours (
    ID int PRIMARY KEY IDENTITY(1,1),
    Start_Time date NOT NULL,
    End_Time date NOT NULL,
    StaffID int REFERENCES tbl_Users(ID),
    Price money NOT NULL,
    CityID int REFERENCES tbl_Cities(PlateNumber)
    );
GO

-- create tbl_Bookings table
CREATE TABLE tbl_Bookings (
    ID int PRIMARY KEY IDENTITY(1,1),
    TourID int REFERENCES tbl_Tours(ID),
    CustomerID int REFERENCES tbl_Users(ID)
);
GO

-- create tbl_DeletedUsers table
CREATE TABLE tbl_DeletedUsers (
    ID int,
    FirstName varchar(50),
    LastName varchar(50),
    Email varchar(50),
    PhoneNumber varchar(12),
    Password varchar(50),
    BirthDate date,
    Role varchar(8)
);
GO

-- create tbl_DeletedTours table
CREATE TABLE tbl_DeletedTours (
    ID int,
    Start_Time date,
    End_Time date,
    StaffID int,
    Price money,
    CityID int
);
GO

-- create tr_DeletedTour trigger
CREATE TRIGGER tr_DeletedTour ON tbl_Tours
    AFTER DELETE
AS
BEGIN
    DECLARE @ID int
    DECLARE @Start_Time date
    DECLARE @End_Time date
    DECLARE @StaffID int
    DECLARE @Price money
    DECLARE @CityID int

SELECT @ID=ID FROM deleted
SELECT @Start_Time=Start_Time FROM deleted
SELECT @End_Time=End_Time FROM deleted
SELECT @StaffID=StaffID FROM deleted
SELECT @Price=Price FROM deleted
SELECT @CityID=CityID FROM deleted

    INSERT INTO tbl_DeletedTours VALUES (@ID, @Start_Time, @End_Time, @StaffID, @Price, @CityID)
END;
GO

-- create tr_DeletedUsers trigger
CREATE TRIGGER tr_DeletedUsers ON tbl_Users
    AFTER DELETE
AS
BEGIN
    DECLARE @ID int
    DECLARE @FirstName varchar(50)
    DECLARE @LastName varchar(50)
    DECLARE @Email varchar(50)
    DECLARE @PhoneNumber varchar(12)
    DECLARE @Password varchar(50)
    DECLARE @BirthDate date
    DECLARE @Role varchar(8)

SELECT @ID=ID FROM deleted
SELECT @FirstName=FirstName FROM deleted
SELECT @LastName=LastName FROM deleted
SELECT @Email=Email FROM deleted
SELECT @PhoneNumber=PhoneNumber FROM deleted
SELECT @Password=Password FROM deleted
SELECT @BirthDate=BirthDate FROM deleted
SELECT @Role=Role FROM deleted

    INSERT INTO tbl_DeletedUsers VALUES (@ID, @FirstName, @LastName, @Email, @PhoneNumber, @Password, @BirthDate, @Role)
END;



-- if you want to delete the database
-- ALTER DATABASE TourTracer SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- DROP DATABASE TourTracer;