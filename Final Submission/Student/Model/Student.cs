using System;

namespace Final_Submission.Student.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Phone { get; set; } = "";
        public string University { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
