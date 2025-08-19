using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Replacement_Request : Form
    {
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        private int? editingRequestId = null;
        public Replacement_Request()
        {
            InitializeComponent();
            btnSubmit.Click += btnSubmit_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void Replacement_Request_Load(object sender, EventArgs e)
        {
            comboBoxRequestType.Items.Clear();
            comboBoxRequestType.Items.Add("Repair");
            comboBoxRequestType.Items.Add("Replacement");
            LoadRequests();
        }
        private void LoadRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [Request ID], [Facility Code], [Facility Name], [Problem Description], [Request Type], [Date Reported], Status FROM Replacement";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataGridView1.DataSource = dt; // bind to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading requests: {ex.Message}");
                }
            }
        }
        private void txtBoxFacilityCode_Leave(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT [Facility Name] FROM Facilities WHERE [Facility Code] = @code";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@code", txtBoxFacilityCode.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtBoxFacilityName.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Facility code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxFacilityName.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching facility name: {ex.Message}");
                }
            }
        }

        // Submit request
        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            try
            {
                string code = txtBoxFacilityCode.Text.Trim();
                string name = txtBoxFacilityName.Text.Trim();

                if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter both Facility Code and Facility Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (editingRequestId.HasValue)
                {
                    // Update existing request
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string updateQuery = @"
                    UPDATE [Replacement] 
                    SET [Facility Name] = @name, 
                        [Problem Description] = @problem, 
                        [Request Type] = @type, 
                        Status = @status 
                    WHERE [Request ID] = @id";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@name", txtBoxFacilityName.Text.Trim());
                        cmd.Parameters.AddWithValue("@problem", richTxtBoxProblemDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", comboBoxRequestType.SelectedItem?.ToString() ?? "Repair");
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        cmd.Parameters.AddWithValue("@id", editingRequestId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Request updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editingRequestId = null;
                    txtBoxFacilityCode.Enabled = true;
                    LoadRequests();
                }
                else
                {
                    // Insert new request
                    SaveReplacementRequest();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReplacementRequest()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"
                    INSERT INTO [Replacement] 
                    ([Facility Code], [Facility Name], [Problem Description], [Request Type], [Date Reported], Status) 
                    VALUES (@code, @name, @problem, @type, @date, @status)";


                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@code", txtBoxFacilityCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtBoxFacilityName.Text.Trim());
                    cmd.Parameters.AddWithValue("@problem", richTxtBoxProblemDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", comboBoxRequestType.SelectedItem?.ToString() ?? "Repair");
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@status", "Pending");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Replacement request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];

            // Get Request ID and Status
            int requestId = Convert.ToInt32(selectedRow.Cells["Request ID"].Value);
            string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

            if (!string.Equals(status.Trim(), "Completed", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only completed requests can be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var confirm = MessageBox.Show("Are you sure you want to delete this completed request?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Delete from database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM [Replacement] WHERE [Request ID] = @id";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@id", requestId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    LoadRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];

            // Populate the form controls
            txtBoxFacilityCode.Text = selectedRow.Cells["Facility Code"].Value?.ToString() ?? "";
            txtBoxFacilityName.Text = selectedRow.Cells["Facility Name"].Value?.ToString() ?? "";
            richTxtBoxProblemDescription.Text = selectedRow.Cells["Problem Description"].Value?.ToString() ?? "";
            comboBoxRequestType.SelectedItem = selectedRow.Cells["Request Type"].Value?.ToString();

            // Store the Request ID somewhere (e.g., hidden field or private variable)
            editingRequestId = Convert.ToInt32(selectedRow.Cells["Request ID"].Value);

            // Optionally, disable facility code editing if you want it immutable
            txtBoxFacilityCode.Enabled = false;

            MessageBox.Show("Make your changes in the form and click Submit to save.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

    

