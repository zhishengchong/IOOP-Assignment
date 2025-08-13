using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Replacement_Request : Form
    {
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
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
            string code = txtBoxFacilityCode.Text.Trim();
            string name = txtBoxFacilityName.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter both Facility Code and Facility Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    string checkQuery = "SELECT [Facility Name] FROM [Replacement] WHERE [Facility Code] = @code";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@code", code);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        string existingName = result.ToString()!;


                        if (!string.Equals(existingName.Trim(), txtBoxFacilityName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                $"The facility code '{code}' already exists with the name '{existingName}'.\n" +
                                "Please enter the correct facility name.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtBoxFacilityName.Clear();
                            txtBoxFacilityName.Focus();
                            return;
                        }
                    }


                    SaveReplacementRequest();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking facility code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

    }
}
    

