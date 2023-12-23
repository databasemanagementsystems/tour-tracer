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

    INSERT INTO DeletedUsers VALUES (@ID, @FirstName, @LastName, @Email, @PhoneNumber, @Password, @BirthDate, @Role)
END;

