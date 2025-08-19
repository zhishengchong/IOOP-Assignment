namespace Final_Submission.Student.Model
{
    public class Facility
    {
        public int FacilityID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public decimal Rate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
