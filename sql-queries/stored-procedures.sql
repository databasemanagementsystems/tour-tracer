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

--Tüm turları listeleyen prosedür
CREATE PROCEDURE GetAllTours
    AS
BEGIN
SELECT * FROM tbl_Tours;
END;

-- sp_ListAllUsers List all Users in the database.
CREATE PROCEDURE sp_ListAllUsers
    AS
BEGIN
SELECT * FROM tbl_Users;
END;





-- USE TourTracer;
-- GO
-- -- InsertIntoTours procedure checks if the staff is a staff or not.
-- CREATE PROCEDURE InsertIntoTours
--     @StartDate date,
--     @EndDate date,
--     @StaffID int,
--     @Fee decimal,
--     @CityID int
-- AS
-- BEGIN
--     DECLARE @Role varchar(8);
--     SELECT @Role = Role FROM tbl_User WHERE ID = @StaffID;
--
--     IF @Role = 'Staff'
--     BEGIN
--         INSERT INTO tbl_Tours (StartDate, EndDate, StaffID, Fee, CityID)
--         VALUES (@StartDate, @EndDate, @StaffID, @Fee, @CityID);
--     END
--     ELSE
--     BEGIN
--         PRINT 'Error: The selected staff member is not a Staff member.';
--     END
-- END;
--
-- USE TourTracer;
-- GO
--
