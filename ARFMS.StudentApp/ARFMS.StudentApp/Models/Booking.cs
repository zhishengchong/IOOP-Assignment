using System;

namespace ARFMS.StudentApp.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int StudentID { get; set; }
        public int FacilityID { get; set; }
        public string FacilityName { get; set; } = "";
        public DateTime BookingDate { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; }
    }
}
