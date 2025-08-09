using System.Data;

namespace Maintenance_Schedule
{
    public partial class Schedule_Form : Form
    {
        public Schedule_Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Schedule ID", typeof(int));
            table.Columns.Add("Facility Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time", typeof(DateTime));
            table.Columns.Add("Task Description", typeof(string));
            table.Columns.Add("Status", typeof(string));

            table.Rows.Add(001, "Basketball Court", DateTime.Now, DateTime.Now.AddHours(1), "Setup", "Pending");
            table.Rows.Add(002, "Badminton Court", DateTime.Now.AddDays(1), DateTime.Now.AddHours(2), "Maintenance", "Completed");
            table.Rows.Add(003, "Swimming Pool", DateTime.Now.AddDays(2), DateTime.Now.AddHours(3), "Cleaning", "In Progress");
            table.Rows.Add(004, "Futsal Court", DateTime.Now.AddDays(3), DateTime.Now.AddHours(4), "Setup", "Pending");
            table.Rows.Add(005, "Gymnasium", DateTime.Now.AddDays(4), DateTime.Now.AddHours(5), "Maintenance", "Completed");
            table.Rows.Add(006, "Table Tennis Hall", DateTime.Now.AddDays(5), DateTime.Now.AddHours(6), "Cleaning", "In Progress");
            table.Rows.Add(007, "Volleyball Court", DateTime.Now.AddDays(6), DateTime.Now.AddHours(7), "Setup", "Pending");
            table.Rows.Add(008, "Squash Court", DateTime.Now.AddDays(7), DateTime.Now.AddHours(8), "Maintenance", "Completed");

            DataGridView.DataSource = table;
        }

        private void Schedule_Form_Load(object sender, EventArgs e)
        {

        }
    }
}