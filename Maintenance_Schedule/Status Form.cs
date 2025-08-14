using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Status_Form : Form
    {
        private SqlDataAdapter? adapter;
        private DataTable? scheduleTable;
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        private string[] allowedStatuses = { "Pending", "In Progress", "Completed" };

        public Status_Form()
        {
            InitializeComponent();
        }

        private void Status_Form_Load(object sender, EventArgs e)
        {
            // Populate Status ComboBox
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.AddRange(allowedStatuses);

            // Set default date
            dateTimePickerTaskDate.Value = DateTime.Now;

            LoadScheduleData();
            SetupDataGridViewButtons();
        }

        private void LoadScheduleData()
        {
            adapter = new SqlDataAdapter("SELECT [Schedule ID], [Facility Name], [Task Description], Status, Date FROM Schedule", connectionString);

            // UPDATE command
            adapter.UpdateCommand = new SqlCommand(
                "UPDATE Schedule SET [Facility Name]=@FacilityName, [Task Description]=@TaskDescription, Status=@Status, Date=@Date WHERE [Schedule ID]=@ScheduleID",
                new SqlConnection(connectionString));
            adapter.UpdateCommand.Parameters.Add("@FacilityName", SqlDbType.NVarChar, 100, "Facility Name");
            adapter.UpdateCommand.Parameters.Add("@TaskDescription", SqlDbType.NVarChar, 200, "Task Description");
            adapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status");
            adapter.UpdateCommand.Parameters.Add("@Date", SqlDbType.DateTime, 0, "Date");
            adapter.UpdateCommand.Parameters.Add("@ScheduleID", SqlDbType.Int, 0, "Schedule ID");

            // DELETE command
            adapter.DeleteCommand = new SqlCommand(
                "DELETE FROM Schedule WHERE [Schedule ID]=@ScheduleID",
                new SqlConnection(connectionString));
            adapter.DeleteCommand.Parameters.Add("@ScheduleID", SqlDbType.Int, 0, "Schedule ID");

            // INSERT command
            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO Schedule ([Facility Name], [Task Description], Status, Date) " +
                "VALUES (@FacilityName, @TaskDescription, @Status, @Date); SELECT SCOPE_IDENTITY()",
                new SqlConnection(connectionString));
            adapter.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.NVarChar, 100, "Facility Name");
            adapter.InsertCommand.Parameters.Add("@TaskDescription", SqlDbType.NVarChar, 200, "Task Description");
            adapter.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status");
            adapter.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime, 0, "Date");
            adapter.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;

            // Fill DataTable
            scheduleTable = new DataTable();
            adapter.Fill(scheduleTable);

            DataGridView1.DataSource = scheduleTable;
            DataGridView1.AllowUserToAddRows = false;

            DataGridView1.Columns["Facility Name"].ReadOnly = false;
            DataGridView1.Columns["Task Description"].ReadOnly = false;
            DataGridView1.Columns["Status"].ReadOnly = false;
            DataGridView1.Columns["Date"].ReadOnly = false;
        }

        private void SetupDataGridViewButtons()
        {
            if (!DataGridView1.Columns.Contains("DeleteButton"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                DataGridView1.Columns.Add(deleteButton);
            }

            if (!DataGridView1.Columns.Contains("EditButton"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                DataGridView1.Columns.Add(editButton);
            }
        }

        // ================= Add Task via TextBoxes =================
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxFacilityName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTaskDescription.Text) ||
                comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields and select a status.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO Schedule ([Facility Name], [Task Description], Status, Date) " +
                        "VALUES (@FacilityName, @TaskDescription, @Status, @Date)",
                        conn);
                    insertCmd.Parameters.AddWithValue("@FacilityName", txtBoxFacilityName.Text);
                    insertCmd.Parameters.AddWithValue("@TaskDescription", txtBoxTaskDescription.Text);
                    insertCmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@Date", dateTimePickerTaskDate.Value);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Task added successfully!");
                LoadScheduleData();

                txtBoxFacilityName.Clear();
                txtBoxTaskDescription.Clear();
                comboBoxStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (scheduleTable != null)
            {
                scheduleTable.RejectChanges();
                LoadScheduleData();
            }
        }

        // ================= DataGridView Edit/Delete =================
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || scheduleTable == null) return;

            DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

            // DELETE BUTTON
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var confirm = MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int scheduleId = Convert.ToInt32(row.Cells["Schedule ID"].Value);
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            SqlCommand deleteCmd = new SqlCommand(
                                "DELETE FROM Schedule WHERE [Schedule ID]=@ScheduleID",
                                conn);
                            deleteCmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                            deleteCmd.ExecuteNonQuery();
                        }
                        LoadScheduleData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting task: " + ex.Message);
                    }
                }
            }

            // EDIT BUTTON
            if (DataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
            {
                string newFacility = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Facility Name:", "Edit Task", row.Cells["Facility Name"].Value?.ToString() ?? "");

                string newTask = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Task Description:", "Edit Task", row.Cells["Task Description"].Value?.ToString() ?? "");

                string newStatus = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Status (Pending, In Progress, Completed):", "Edit Task", row.Cells["Status"].Value?.ToString() ?? "");

                DateTime newDate;
                string dateInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Date (yyyy-MM-dd):", "Edit Task", row.Cells["Date"].Value?.ToString() ?? "");
                if (!DateTime.TryParse(dateInput, out newDate))
                {
                    newDate = (DateTime)row.Cells["Date"].Value!;
                }

                try
                {
                    int scheduleId = Convert.ToInt32(row.Cells["Schedule ID"].Value);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Schedule SET [Facility Name]=@FacilityName, [Task Description]=@TaskDescription, Status=@Status, Date=@Date WHERE [Schedule ID]=@ScheduleID",
                            conn);
                        updateCmd.Parameters.AddWithValue("@FacilityName", newFacility);
                        updateCmd.Parameters.AddWithValue("@TaskDescription", newTask);
                        updateCmd.Parameters.AddWithValue("@Status", newStatus);
                        updateCmd.Parameters.AddWithValue("@Date", newDate);
                        updateCmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

                        updateCmd.ExecuteNonQuery();
                    }
                    LoadScheduleData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating task: " + ex.Message);
                }
            }
        }
    }
}
