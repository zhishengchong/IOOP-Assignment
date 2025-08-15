-- Facility 表
IF OBJECT_ID('dbo.Facility', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Facility(
        FacilityID   INT IDENTITY(1,1) PRIMARY KEY,
        FacilityCode NVARCHAR(20)  NOT NULL UNIQUE,
        FacilityName NVARCHAR(100) NOT NULL,
        Location     NVARCHAR(100) NULL,
        RatePerHour  DECIMAL(10,2) NOT NULL
    );
END;

-- Booking 表
IF OBJECT_ID('dbo.Booking', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Booking(
        BookingID    INT IDENTITY(1,1) PRIMARY KEY,
        StudentID    INT NOT NULL,
        FacilityID   INT NOT NULL,
        StartAt      DATETIME2 NOT NULL,
        EndAt        DATETIME2 NOT NULL,
        Hours        INT NOT NULL,
        RatePerHour  DECIMAL(10,2) NOT NULL,
        TotalCost    DECIMAL(10,2) NOT NULL,
        CreatedAt    DATETIME2 NOT NULL CONSTRAINT DF_Booking_CreatedAt DEFAULT SYSUTCDATETIME()
    );
    ALTER TABLE dbo.Booking
      ADD CONSTRAINT FK_Booking_Student  FOREIGN KEY (StudentID)  REFERENCES dbo.Student(StudentID),
          CONSTRAINT FK_Booking_Facility FOREIGN KEY (FacilityID) REFERENCES dbo.Facility(FacilityID);
    CREATE INDEX IX_Booking_Facility_Time ON dbo.Booking(FacilityID, StartAt, EndAt);
END;

-- 示例设施数据
IF NOT EXISTS (SELECT 1 FROM dbo.Facility WHERE FacilityCode='GYM01')
INSERT INTO dbo.Facility(FacilityCode, FacilityName, Location, RatePerHour)
VALUES ('GYM01','Main Gym','Campus A',50.00);

IF NOT EXISTS (SELECT 1 FROM dbo.Facility WHERE FacilityCode='POOL1')
INSERT INTO dbo.Facility(FacilityCode, FacilityName, Location, RatePerHour)
VALUES ('POOL1','Swimming Pool','Campus B',30.00);

IF NOT EXISTS (SELECT 1 FROM dbo.Facility WHERE FacilityCode='COURT1')
INSERT INTO dbo.Facility(FacilityCode, FacilityName, Location, RatePerHour)
VALUES ('COURT1','Badminton Court','Campus A',12.00);
