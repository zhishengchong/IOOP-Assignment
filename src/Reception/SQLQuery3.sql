-- Receipt（收据）表：每个 Booking 只允许一张收据
IF OBJECT_ID('dbo.Receipt', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Receipt(
        ReceiptID      INT IDENTITY(1,1) PRIMARY KEY,
        BookingID      INT NOT NULL UNIQUE,   -- 一个预订只能付一次
        AmountPaid     DECIMAL(10,2) NOT NULL,
        PaymentMethod  NVARCHAR(20)  NOT NULL,
        PaidAt         DATETIME2     NOT NULL CONSTRAINT DF_Receipt_PaidAt DEFAULT SYSUTCDATETIME()
    );
    ALTER TABLE dbo.Receipt
      ADD CONSTRAINT FK_Receipt_Booking FOREIGN KEY (BookingID) REFERENCES dbo.Booking(BookingID);
END;
