-- Create database
CREATE DATABASE TourTracer;
GO

-- Use the database
USE TourTracer;
GO

-- create the tbl_User table
CREATE TABLE tbl_User (
                          CustomerID int PRIMARY KEY IDENTITY(1,1),
                          FirstName varchar(50) NOT NULL,
                          LastName varchar(50) NOT NULL,
                          Email varchar(50) NOT NULL CHECK (Email LIKE '%_@_%._%'),
                          PhoneNumber varchar(12) NOT NULL,
                          Password varchar(50) NOT NULL,
                          BirthDate date NOT NULL,
                          Role varchar(8) CHECK (Role IN ('Admin', 'Customer', 'Personal')) NOT NULL
);
GO

-- add an admin to the tbl_User table
INSERT INTO tbl_User (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role)
VALUES ('Admin', 'User', 'admin@example.com', '1234567890', 'AdminPassword', '1970-01-01', 'Admin');
GO

-- create table tbl_Cities
CREATE TABLE tbl_Cities (
                            PlateNumber int PRIMARY KEY IDENTITY(1,1),
                            CityName varchar(30) NOT NULL,
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