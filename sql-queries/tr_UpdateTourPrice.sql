CREATE TRIGGER tr_UpdateTourPrice ON tbl_Tours
    INSTEAD OF UPDATE
                   AS
BEGIN
    DECLARE @ID int
    DECLARE @Price money

SELECT @ID=ID, @Price=Price FROM inserted

                                     IF @Price BETWEEN 500.00 AND 10000.00
BEGIN
UPDATE tbl_Tours
SET Price = @Price
WHERE ID = @ID
END
ELSE
BEGIN
        PRINT 'Error: The price should be between 500.00 and 10000.00.'
END
END;
