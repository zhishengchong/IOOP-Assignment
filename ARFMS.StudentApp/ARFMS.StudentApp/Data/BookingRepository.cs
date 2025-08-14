using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ARFMS.StudentApp.Models;

namespace ARFMS.StudentApp.Data
{
    public class BookingRepository
    {
        public List<Booking> GetByStudent(int studentId)
        {
            var list = new List<Booking>();
            using var conn = Db.GetConnection();
            conn.Open();
            var sql = @"
                SELECT b.BookingID, b.StudentID, b.FacilityID, f.Name, b.BookingDate, b.Status, b.CreatedAt
                FROM Bookings b
                JOIN Facilities f ON f.FacilityID = b.FacilityID
                WHERE b.StudentID = @sid
                ORDER BY b.BookingDate DESC, b.BookingID DESC;";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sid", studentId);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Booking
                {
                    BookingID = r.GetInt32(0),
                    StudentID = r.GetInt32(1),
                    FacilityID = r.GetInt32(2),
                    FacilityName = r.GetString(3),
                    BookingDate = r.GetDateTime(4),
                    Status = r.GetString(5),
                    CreatedAt = r.GetDateTime(6)
                });
            }
            return list;
        }

        public void Add(int studentId, int facilityId, DateTime bookingDate)
        {
            if (bookingDate.Date < DateTime.Today.AddDays(1))
                throw new InvalidOperationException("Booking must be at least ONE day in advance.");

            using var conn = Db.GetConnection();
            conn.Open();
            var cmd = new SqlCommand(@"
                INSERT INTO Bookings(StudentID, FacilityID, BookingDate, Status)
                VALUES(@sid, @fid, @d, 'Pending');", conn);
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@fid", facilityId);
            cmd.Parameters.AddWithValue("@d", bookingDate.Date);
            cmd.ExecuteNonQuery();
        }

        public void UpdateDate(int bookingId, DateTime newDate)
        {
            if (newDate.Date < DateTime.Today.AddDays(1))
                throw new InvalidOperationException("Booking must be at least ONE day in advance.");

            using var conn = Db.GetConnection();
            conn.Open();
            var cmd = new SqlCommand(@"
                UPDATE Bookings SET BookingDate=@d
                WHERE BookingID=@id AND Status='Pending';", conn);
            cmd.Parameters.AddWithValue("@d", newDate.Date);
            cmd.Parameters.AddWithValue("@id", bookingId);
            if (cmd.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("Only 'Pending' bookings can be edited.");
        }

        public void Delete(int bookingId)
        {
            using var conn = Db.GetConnection();
            conn.Open();
            var cmd = new SqlCommand(@"
                DELETE FROM Bookings WHERE BookingID=@id AND Status='Pending';", conn);
            cmd.Parameters.AddWithValue("@id", bookingId);
            if (cmd.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("Only 'Pending' bookings can be deleted.");
        }
    }
}
