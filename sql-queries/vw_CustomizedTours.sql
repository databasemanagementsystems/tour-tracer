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

