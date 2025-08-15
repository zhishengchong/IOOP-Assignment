IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_Receipt_BookingID'
      AND object_id = OBJECT_ID('dbo.Receipt')
)
    CREATE UNIQUE INDEX UX_Receipt_BookingID
    ON dbo.Receipt(BookingID);
