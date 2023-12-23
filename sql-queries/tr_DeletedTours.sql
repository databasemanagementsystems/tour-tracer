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
