using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Status_Form : Form
    {
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        private SqlDataAdapter? adapter;
        private DataTable? scheduleTable;

        public Status_Form()
        {
            InitializeComponent();
            comboBoxStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadScheduleData();
        }

        private void LoadScheduleData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(
                    "SELECT [Schedule ID], [Facility Name], [Task Description], Status, [Date], [Time] FROM Schedule",
                    conn);
                scheduleTable = new DataTable();
                adapter.Fill(scheduleTable);
                DataGridView1.DataSource = scheduleTable;
            }
        }

        // ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxFacilityName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTaskDescription.Text) ||
                comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Schedule ([Facility Name], [Task Description], Status, [Date], [Time]) VALUES (@Facility, @Task, @Status, @Date, @Time)", conn);
                cmd.Parameters.AddWithValue("@Facility", txtBoxFacilityName.Text ?? "");
                cmd.Parameters.AddWithValue("@Task", txtBoxTaskDescription.Text ?? "");
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem?.ToString() ?? "Pending");
                cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Time", timePicker.Value.TimeOfDay);

                cmd.ExecuteNonQuery();
            }

            LoadScheduleData();
            MessageBox.Show("Task added successfully.");
        }

        // EDIT BUTTON
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            DataGridViewRow row = DataGridView1.SelectedRows[0];
            int scheduleId = Convert.ToInt32(row.Cells["Schedule ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Schedule SET [Facility Name] = @Facility, [Task Description] = @Task, Status = @Status, [Date] = @Date, [Time] = @Time WHERE [Schedule ID] = @ID", conn);
                cmd.Parameters.AddWithValue("@Facility", txtBoxFacilityName.Text ?? "");
                cmd.Parameters.AddWithValue("@Task", txtBoxTaskDescription.Text ?? "");
                cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem?.ToString() ?? "Pending");
                cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Time", timePicker.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@ID", scheduleId);

                cmd.ExecuteNonQuery();
            }

            LoadScheduleData();
            MessageBox.Show("Task updated successfully.");
        }

        // DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow row = DataGridView1.SelectedRows[0];
            int scheduleId = Convert.ToInt32(row.Cells["Schedule ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Schedule WHERE [Schedule ID] = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", scheduleId);
                cmd.ExecuteNonQuery();
            }

            LoadScheduleData();
            MessageBox.Show("Task deleted successfully.");
        }

        // CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // WHEN ROW IS CLICKED, LOAD DETAILS INTO INPUT FIELDS
        private void dataGridViewSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DataGridView1.SelectedRows[0];
                txtBoxFacilityName.Text = row.Cells["Facility Name"].Value?.ToString();
                txtBoxTaskDescription.Text = row.Cells["Task Description"].Value?.ToString();
                comboBoxStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
                datePicker.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                timePicker.Value = DateTime.Today.Add((TimeSpan)row.Cells["Time"].Value);
            }
        }
    }
}
