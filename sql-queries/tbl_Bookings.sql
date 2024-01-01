CREATE TABLE tbl_Bookings (
    ID int PRIMARY KEY IDENTITY(1,1),
    TourID int REFERENCES tbl_Tours(ID),
    CustomerID int REFERENCES tbl_Users(ID)
);

INSERT INTO tbl_Bookings (TourID, CustomerID) VALUES
    (1, 1), (1, 2), (2, 3), (2, 4), (3, 5), (3, 6),
    (4, 7), (4, 8), (5, 9), (5, 10), (6, 1), (6, 2),
    (7, 3), (7, 4), (8, 5), (8, 6), (9, 7), (9, 8),
    (10, 9), (10, 10);
