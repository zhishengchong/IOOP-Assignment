#nullable enable
using System.Collections.Generic;
using System.Data.SqlClient;
using ARFMS.StudentApp.Models;

namespace Final_Submission.Student.Data
{
    public class ReviewRepository
    {
        public void Add(int studentId, int facilityId, int rating, string? comments)
        {
            using var conn = Db.GetConnection();
            conn.Open();
            var cmd = new SqlCommand(@"
                INSERT INTO Reviews(StudentID, FacilityID, Rating, Comments)
                VALUES(@sid, @fid, @r, @c);", conn);
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@fid", facilityId);
            cmd.Parameters.AddWithValue("@r", rating);
            cmd.Parameters.AddWithValue("@c", (object?)comments ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        public List<Review> GetByStudent(int studentId)
        {
            var list = new List<Review>();
            using var conn = Db.GetConnection();
            conn.Open();
            var sql = @"
                SELECT r.ReviewID, r.StudentID, r.FacilityID, f.Name, r.Rating, r.Comments, r.CreatedAt
                FROM Reviews r
                JOIN Facilities f ON f.FacilityID = r.FacilityID
                WHERE r.StudentID = @sid
                ORDER BY r.CreatedAt DESC;";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sid", studentId);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Review
                {
                    ReviewID = r.GetInt32(0),
                    StudentID = r.GetInt32(1),
                    FacilityID = r.GetInt32(2),
                    FacilityName = r.GetString(3),
                    Rating = r.GetInt32(4),
                    Comments = r.IsDBNull(5) ? "" : r.GetString(5),
                    CreatedAt = r.GetDateTime(6)
                });
            }
            return list;
        }
    }
}
