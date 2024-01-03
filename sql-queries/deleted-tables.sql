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

CREATE TABLE tbl_DeletedTours (
    ID int,
    Start_Time date,
    End_Time date,
    StaffID int,
    Price money,
    DepartureCityID int,
    DestinationCityID int
);