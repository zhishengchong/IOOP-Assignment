using System;

namespace Final_Submission.Student.Model
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int StudentID { get; set; }
        public int FacilityID { get; set; }
        public string FacilityName { get; set; } = ""; // convenience
        public int Rating { get; set; }
        public string Comments { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
