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
