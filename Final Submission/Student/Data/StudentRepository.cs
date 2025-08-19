#nullable enable
using System;
using System.Data.SqlClient;
using ARFMS.StudentApp.Models;

namespace Final_Submission.Student.Data
{
    public class StudentRepository
    {
        public Student? Login(string email, string password)
        {
            using var conn = Db.GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                SELECT TOP 1 StudentID, Name, Email, Password, Phone, University, CreatedAt
                FROM Students
                WHERE Email = @e AND Password = @p;", conn);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@p", password);

            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;

            return new Student
            {
                StudentID = r.GetInt32(0),
                Name = r.GetString(1),
                Email = r.GetString(2),
                Password = r.GetString(3),
                Phone = r.IsDBNull(4) ? "" : r.GetString(4),
                University = r.IsDBNull(5) ? "" : r.GetString(5),
                CreatedAt = r.GetDateTime(6)
            };
        }

        public void UpdateProfile(Student s)
        {
            using var conn = Db.GetConnection();
            conn.Open();
            var cmd = new SqlCommand(@"
                UPDATE Students
                   SET Name=@n, Phone=@ph, University=@u
                 WHERE StudentID=@id;", conn);
            cmd.Parameters.AddWithValue("@n", s.Name);
            cmd.Parameters.AddWithValue("@ph", (object?)s.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@u", (object?)s.University ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", s.StudentID);
            cmd.ExecuteNonQuery();
        }
    }
}
