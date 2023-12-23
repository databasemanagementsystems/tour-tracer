CREATE TRIGGER tr_NewUser ON tbl_Users
    FOR INSERT
AS
BEGIN
    DECLARE @ID int
    DECLARE @Role varchar(8)

SELECT @ID=ID, @Role=Role FROM inserted

                                   IF @Role = 'Customer'
BEGIN
        PRINT 'A new customer has been added: ' + CAST(@ID AS varchar)
END
END;
