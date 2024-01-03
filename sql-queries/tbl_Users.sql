CREATE TABLE tbl_Users (
    ID int PRIMARY KEY IDENTITY(1,1),
    FirstName varchar(50) NOT NULL,
    LastName varchar(50) NOT NULL,
    Email varchar(50) NOT NULL CHECK (Email LIKE '%_@_%._%'),
    PhoneNumber varchar(12) NOT NULL,
    Password varchar(50) NOT NULL,
    BirthDate date NOT NULL,
    Role varchar(8) CHECK (Role IN ('Admin', 'Customer', 'Staff')) NOT NULL
);

INSERT INTO tbl_Users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role) VALUES
    ('Ahmet', 'Yılmaz', 'ahmet.yilmaz@example.com', '05321234567', 'password123', '1990-01-01', 'Customer'),
    ('Mehmet', 'Öztürk', 'mehmet.ozturk@example.com', '05321234568', 'password123', '1992-02-02', 'Customer'),
    ('Elif', 'Demir', 'elif.demir@example.com', '05321234569', 'password123', '1993-03-03', 'Customer'),
    ('Ayşe', 'Kaya', 'ayse.kaya@example.com', '05321234570', 'password123', '1994-04-04', 'Customer'),
    ('Fatma', 'Çelik', 'fatma.celik@example.com', '05321234571', 'password123', '1995-05-05', 'Customer'),
    ('Yusuf', 'Şahin', 'yusuf.sahin@example.com', '05321234572', 'password123', '1996-06-06', 'Customer'),
    ('Zeynep', 'Koç', 'zeynep.koc@example.com', '05321234573', 'password123', '1997-07-07', 'Customer'),
    ('Merve', 'Yıldız', 'merve.yildiz@example.com', '05321234574', 'password123', '1998-08-08', 'Customer'),
    ('Oğuz', 'Aydın', 'oguz.aydin@example.com', '05321234575', 'password123', '1999-09-09', 'Customer'),
    ('Esra', 'Kara', 'esra.kara@example.com', '05321234576', 'password123', '2000-10-10', 'Customer'),
    ('Emre', 'Can', 'emre.can@example.com', '05321234577', 'password123', '1985-11-11', 'Staff'),
    ('Seda', 'Akın', 'seda.akin@example.com', '05321234578', 'password123', '1986-12-12', 'Staff'),
    ('Canan', 'Erbil', 'canan.erbil@example.com', '05321234579', 'password123', '1987-01-13', 'Staff'),
    ('Kemal', 'Türk', 'kemal.turk@example.com', '05321234580', 'password123', '1975-02-14', 'Admin'),
    ('Leyla', 'Gül', 'leyla.gul@example.com', '05321234581', 'password123', '1978-03-15', 'Admin');
