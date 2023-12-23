CREATE TABLE tbl_Tours (
    ID int PRIMARY KEY IDENTITY(1,1),
    Start_Time date NOT NULL,
    End_Time date NOT NULL,
    StaffID int REFERENCES tbl_Users(ID),
    Price money NOT NULL,
    CityID int REFERENCES tbl_Cities(PlateNumber)
);
