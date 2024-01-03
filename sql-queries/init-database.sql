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

INSERT INTO tbl_Users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role) VALUES
    ('Ahmet', 'Yılmaz', 'ahmet.yilmaz@example.com', '05321234567', 'password123', '1990-01-01', 'Customer'),
    ('Mehmet', 'Öztürk', 'mehmet.ozturk@example.com', '05321234568', 'password123', '1992-02-02', 'Customer'),
    ('Elif', 'Demir', 'elif.demir@example.com', '05321234569', 'password123', '1993-03-03', 'Customer'),
    ('Ayşe', 'Kaya', 'ayse.kaya@example.com', '05321234570', 'password123', '1994-04-04', 'Customer'),
    ('Fatma', 'Çelik', 'fatma.celik@example.com', '05321234571', 'password123', '1995-05-05', 'Customer'),
    ('Yusuf', 'Şahin', 'yusuf.sahin@example.com', '05321234572', 'password123', '1996-06-06', 'Customer'),
    ('Zeynep', 'Koç', 'zeynep.koc@example.com', '05321234573', 'password123', '1997-07-07', 'Customer'),
    ('Merve', 'Yıldız', 'merve.yildiz@example.com', '05321234574', 'password123', '1998-08-08', 'Customer'),
    ('Oğuz', 'Aydın', 'oguz.aydin@example.com', '05321234575', 'password123', '1999-09-09', 'Customer'),
    ('Esra', 'Kara', 'esra.kara@example.com', '05321234576', 'password123', '2000-10-10', 'Customer'),
    ('Emre', 'Can', 'emre.can@example.com', '05321234577', 'password123', '1985-11-11', 'Staff'),
    ('Seda', 'Akın', 'seda.akin@example.com', '05321234578', 'password123', '1986-12-12', 'Staff'),
    ('Canan', 'Erbil', 'canan.erbil@example.com', '05321234579', 'password123', '1987-01-13', 'Staff'),
    ('Kemal', 'Türk', 'kemal.turk@example.com', '05321234580', 'password123', '1975-02-14', 'Admin'),
    ('Leyla', 'Gül', 'leyla.gul@example.com', '05321234581', 'password123', '1978-03-15', 'Admin');
GO

-- add an admin to the tbl_User table (optional) (we already have inserted an admin)
-- INSERT INTO tbl_Users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role)
-- VALUES ('Admin', 'User', 'admin@example.com', '1234567890', 'AdminPassword', '1970-01-01', 'Admin');
-- GO

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
    DepartureCityID int REFERENCES tbl_Cities(PlateNumber),
    DestinationCityID int REFERENCES tbl_Cities(PlateNumber)
);
GO

INSERT INTO tbl_Tours (Start_Time, End_Time, StaffID, Price, DepartureCityID, DestinationCityID) VALUES
    ('2024-04-01', '2024-04-05', 11, 500.00, 1, 10),
    ('2024-05-01', '2024-05-05', 11, 600.00, 2, 11),
    ('2024-06-01', '2024-06-05', 12, 550.00, 3, 12),
    ('2024-07-01', '2024-07-05', 12, 650.00, 4, 13),
    ('2024-08-01', '2024-08-05', 12, 700.00, 5, 14),
    ('2024-09-01', '2024-09-05', 13, 750.00, 6, 15),
    ('2024-10-01', '2024-10-05', 13, 800.00, 7, 16),
    ('2024-11-01', '2024-11-05', 13, 850.00, 8, 17),
    ('2024-12-01', '2024-12-05', 11, 900.00, 9, 18),
    ('2025-01-01', '2025-01-05', 11, 950.00, 10, 19);
GO

-- create tbl_Bookings table
CREATE TABLE tbl_Bookings (
    ID int PRIMARY KEY IDENTITY(1,1),
    TourID int REFERENCES tbl_Tours(ID),
    CustomerID int REFERENCES tbl_Users(ID)
);
GO
INSERT INTO tbl_Bookings (TourID, CustomerID) VALUES
    (1, 1), (1, 2), (2, 3), (2, 4), (3, 5), (3, 6),
    (4, 7), (4, 8), (5, 9), (5, 10), (6, 1), (6, 2),
    (7, 3), (7, 4), (8, 5), (8, 6), (9, 7), (9, 8),
    (10, 9), (10, 10);
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
    DepartureCityID int,
    DestinationCityID int
);
GO

-- sp_ListAllUsers List all Users in the database.
CREATE PROCEDURE sp_ListAllUsers
    AS
BEGIN
SELECT * FROM tbl_Users;
END;
GO

-- sp_TopCustomer find the customer who has booked the most tours.
CREATE PROCEDURE sp_TopCustomer
    AS
BEGIN
SELECT TOP 1 u.FirstName, u.LastName, COUNT(b.CustomerID) as TourCount
FROM tbl_Users u
         INNER JOIN tbl_Bookings b ON u.ID = b.CustomerID
GROUP BY u.FirstName, u.LastName
ORDER BY TourCount DESC;
END;
GO

-- sp_GetCustomersByCity List all Customers in a specific city.
-- sp_GetCustomersByCity seçilen şehire ait turlara kayıt olan müşterilerin listesi
CREATE PROCEDURE sp_GetCustomersByCity
    @CityID int
AS
BEGIN
SELECT u.FirstName, u.LastName, u.Email
FROM tbl_Users u
         INNER JOIN tbl_Bookings b ON u.ID = b.CustomerID
         INNER JOIN tbl_Tours t ON b.TourID = t.ID
WHERE t.CityID = @CityID AND u.Role = 'Customer'
END;

--Tüm turları listeleyen prosedür
CREATE PROCEDURE GetAllTours
    AS
BEGIN
SELECT * FROM tbl_Tours;
END;
GO

-- sp_GetCustomersByCity List all Customers in a specific city.
CREATE PROCEDURE sp_GetCustomersByCity
    @CityName varchar(30)
AS
BEGIN
SELECT
    u.ID,
    u.FirstName,
    u.LastName,
    u.Email
FROM
    tbl_Users u
        INNER JOIN
    tbl_Bookings b ON u.ID = b.CustomerID
        INNER JOIN
    tbl_Tours t ON b.TourID = t.ID
        INNER JOIN
    tbl_Cities c ON t.DestinationCityID = c.PlateNumber OR t.DepartureCityID = c.PlateNumber
WHERE
    c.CityName = @CityName;
END;
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
    DECLARE @DepartureCityID int
    DECLARE @DestinationCityID int

SELECT @ID=ID FROM deleted
SELECT @Start_Time=Start_Time FROM deleted
SELECT @End_Time=End_Time FROM deleted
SELECT @StaffID=StaffID FROM deleted
SELECT @Price=Price FROM deleted
SELECT @DepartureCityID=DepartureCityID FROM deleted
SELECT @DestinationCityID=DestinationCityID FROM deleted

    INSERT INTO tbl_DeletedTours VALUES (@ID, @Start_Time, @End_Time, @StaffID, @Price, @DepartureCityID, @DestinationCityID)
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
GO

-- tr_CheckDuplicateBooking Checks the customer is already reserved in same tour
CREATE TRIGGER tr_CheckDuplicateBooking
    ON tbl_Bookings
    AFTER INSERT
AS
BEGIN
    -- Eğer yeni eklenen kayıt, aynı CustomerID ve TourID ile zaten varsa, hata döndür
    IF EXISTS (
        SELECT *
        FROM tbl_Bookings b
        INNER JOIN inserted i ON b.TourID = i.TourID AND b.CustomerID = i.CustomerID
        WHERE b.ID <> i.ID
    )
BEGIN
        RAISERROR('Bu tura zaten kayıtlısınız.', 16, 1);
ROLLBACK TRANSACTION;
END
END;

-- Create view for listing tours with meaningful information
CREATE VIEW vw_CustomizedTours AS
SELECT
    t.ID,
    t.Start_Time,
    t.End_Time,
    u.FirstName + ' ' + u.LastName AS StaffName,
    t.Price,
    depCity.CityName AS DepartureCity,
    destCity.CityName AS DestinationCity
FROM
    tbl_Tours t
        INNER JOIN
    tbl_Users u ON t.StaffID = u.ID
        INNER JOIN
    tbl_Cities depCity ON t.DepartureCityID = depCity.PlateNumber
        INNER JOIN
    tbl_Cities destCity ON t.DestinationCityID = destCity.PlateNumber;



-- if you want to delete the database
-- ALTER DATABASE TourTracer SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- DROP DATABASE TourTracer;