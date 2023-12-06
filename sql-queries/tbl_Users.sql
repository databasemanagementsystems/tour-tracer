CREATE TABLE tbl_User (
    CustomerID int PRIMARY KEY IDENTITY(1,1),
    FirstName varchar(50) NOT NULL,
    LastName varchar(50) NOT NULL,
    Email varchar(50) NOT NULL CHECK (Email LIKE '%_@_%._%'),
    PhoneNumber varchar(12) NOT NULL,
    Password varchar(50) NOT NULL,
    BirthDate date NOT NULL,
    Role varchar(8) CHECK (Role IN ('Admin', 'Customer')) NOT NULL
);