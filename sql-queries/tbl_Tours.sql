CREATE TABLE tbl_Tours (
    ID int PRIMARY KEY IDENTITY(1,1),
    Start_Time date NOT NULL,
    End_Time date NOT NULL,
    StaffID int REFERENCES tbl_Users(ID),
    Price money NOT NULL,
    DepartureCityID int REFERENCES tbl_Cities(PlateNumber),
    DestinationCityID int REFERENCES tbl_Cities(PlateNumber)
);

INSERT INTO tbl_Tours (Start_Time, End_Time, StaffID, Price, DepartureCityID, DestinationCityID) VALUES
    ('2024-04-01', '2024-04-05', 11, 500.00, 1, 10),
    ('2024-05-01', '2024-05-05', 11, 600.00, 2, 11),
    ('2024-06-01', '2024-06-05', 12, 550.00, 3, 12),
    ('2024-07-01', '2024-07-05', 12, 650.00, 4, 13),
    ('2024-08-01', '2024-08-05', 12, 700.00, 5, 14),
    ('2024-09-01', '2024-09-05', 13, 750.00, 6, 15),
    ('2024-10-01', '2024-10-05', 13, 800.00, 7, 16),
    ('2024-11-01', '2024-11-05', 13, 850.00, 8, 17),
    ('2024-12-01', '2024-12-05', 11, 900.00, 9, 18),
    ('2025-01-01', '2025-01-05', 11, 950.00, 10, 19);
