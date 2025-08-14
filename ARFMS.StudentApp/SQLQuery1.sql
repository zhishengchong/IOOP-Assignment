-- Create DB
IF DB_ID('ARFMS') IS NULL
    CREATE DATABASE ARFMS;
GO
USE ARFMS;
GO

-- Students
IF OBJECT_ID('dbo.Students','U') IS NOT NULL DROP TABLE dbo.Students;
CREATE TABLE dbo.Students(
    StudentID   INT IDENTITY PRIMARY KEY,
    Name        NVARCHAR(100) NOT NULL,
    Email       NVARCHAR(100) NOT NULL UNIQUE,
    Password    NVARCHAR(100) NOT NULL, -- plain text for simplicity
    Phone       NVARCHAR(50)  NULL,
    University  NVARCHAR(100) NULL,
    CreatedAt   DATETIME2      NOT NULL DEFAULT SYSDATETIME()
);

-- Facilities
IF OBJECT_ID('dbo.Facilities','U') IS NOT NULL DROP TABLE dbo.Facilities;
CREATE TABLE dbo.Facilities(
    FacilityID  INT IDENTITY PRIMARY KEY,
    Name        NVARCHAR(150) NOT NULL,
    Type        NVARCHAR(100) NOT NULL,
    Location    NVARCHAR(150) NOT NULL,
    Rate        DECIMAL(10,2) NOT NULL,
    IsAvailable BIT NOT NULL DEFAULT 1
);

-- Bookings
IF OBJECT_ID('dbo.Bookings','U') IS NOT NULL DROP TABLE dbo.Bookings;
CREATE TABLE dbo.Bookings(
    BookingID   INT IDENTITY PRIMARY KEY,
    StudentID   INT NOT NULL FOREIGN KEY REFERENCES dbo.Students(StudentID),
    FacilityID  INT NOT NULL FOREIGN KEY REFERENCES dbo.Facilities(FacilityID),
    BookingDate DATE NOT NULL,
    Status      NVARCHAR(20) NOT NULL DEFAULT 'Pending', -- Pending/Cancelled/Completed
    CreatedAt   DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

-- Reviews
IF OBJECT_ID('dbo.Reviews','U') IS NOT NULL DROP TABLE dbo.Reviews;
CREATE TABLE dbo.Reviews(
    ReviewID   INT IDENTITY PRIMARY KEY,
    StudentID  INT NOT NULL FOREIGN KEY REFERENCES dbo.Students(StudentID),
    FacilityID INT NOT NULL FOREIGN KEY REFERENCES dbo.Facilities(FacilityID),
    Rating     INT NOT NULL CHECK (Rating BETWEEN 1 AND 5),
    Comments   NVARCHAR(500) NULL,
    CreatedAt  DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

-- Sample data
INSERT INTO dbo.Students(Name, Email, Password, Phone, University)
VALUES (N'Jane Student', N'student1@example.com', N'pass123', N'0123456789', N'APU');

INSERT INTO dbo.Facilities(Name, Type, Location, Rate, IsAvailable) VALUES
(N'Uni A Sports Hall', N'Indoor Court', N'Kuala Lumpur', 50.00, 1),
(N'Uni B Swimming Pool', N'Pool', N'Cyberjaya', 30.00, 1),
(N'Uni C Tennis Court', N'Tennis', N'Bukit Jalil', 25.00, 1),
(N'Uni D Gym', N'Gym', N'Kuala Lumpur', 20.00, 1);
