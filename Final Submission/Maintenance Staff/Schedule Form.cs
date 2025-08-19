using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Schedule_Form : Form
    {
        // Your SSMS connection string
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public Schedule_Form()
        {
            InitializeComponent();
        }

        private void Schedule_Form_Load(object sender, EventArgs e)
        {
            // Load all tasks on form load
            LoadSchedule(null);
        }

        private void DateTimePickerFilterScheduleByDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSchedule(DateTimePickerFilterScheduleByDate.Value.Date);
        }

        private void LoadSchedule(DateTime? selectedDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT [Schedule ID], [Facility Name], Date, Time, [Task Description], Status
                        FROM [Maintenanace Schedule]
                        WHERE (@SelectedDate IS NULL OR [Date] = @SelectedDate)
                        ORDER BY Date, Time";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (selectedDate.HasValue)
                            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Value.Date);
                        else
                            cmd.Parameters.AddWithValue("@SelectedDate", DBNull.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message);
            }
        }
    }
}
