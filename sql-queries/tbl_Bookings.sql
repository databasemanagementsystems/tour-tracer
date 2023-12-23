CREATE TABLE tbl_Bookings (
    ID int PRIMARY KEY IDENTITY(1,1),
    TourID int REFERENCES tbl_Tours(ID),
    CustomerID int REFERENCES tbl_Users(ID)
);
