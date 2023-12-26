CREATE TABLE tbl_Tours (
    ID int PRIMARY KEY IDENTITY(1,1),
    Start_Time date NOT NULL,
    End_Time date NOT NULL,
    StaffID int REFERENCES tbl_Users(ID),
    Price money NOT NULL,
    CityID int REFERENCES tbl_Cities(PlateNumber)
);

INSERT INTO tbl_Tours (Start_Time, End_Time, StaffID, Price, CityID) VALUES
    ('2023-12-21', '2023-12-28', 3, 1000.00, 1),
    ('2023-12-21', '2023-12-28', 6, 1200.00, 2),
    ('2023-12-21', '2023-12-28', 9, 1100.00, 3);