
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Equipment_Form : Form
    {
        private string connectionString = "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        private DataTable table = null!;
        private SqlDataAdapter adapter = null!;
        private SqlConnection conn = null!;
        public Equipment_Form()
        {
            InitializeComponent();
        }
        private void Equipment_Form_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Equipment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView1.DataSource = dt;
            }
        }
        private void LoadDataFromDatabase()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Equipment", conn);

            // SqlCommandBuilder auto-generates INSERT/UPDATE/DELETE commands
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            table = new DataTable();
            adapter.Fill(table);

            DataGridView1.DataSource = table;
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Equipment ([Item Name], Quantity, Purpose) VALUES (@ItemName, @Quantity, @Purpose)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemName", txtBoxItemName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", (int)(NumericUpDownQuantity.Value));
                    cmd.Parameters.AddWithValue("@Purpose", txtBoxPurpose.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadDataFromDatabase();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            // Get the selected row's Request ID
            int requestId = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["Request ID"].Value);

            // Get new values from your textboxes
            string newItemName = txtBoxItemName.Text.Trim();
            int newQuantity = (int)NumericUpDownQuantity.Value;
            string newPurpose = txtBoxPurpose.Text.Trim();

            if (string.IsNullOrEmpty(newItemName) || string.IsNullOrEmpty(newPurpose))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Equipment " +
                                   "SET [Item Name] = @ItemName, Quantity = @Quantity, Purpose = @Purpose " +
                                   "WHERE [Request ID] = @RequestID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", newItemName);
                        cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                        cmd.Parameters.AddWithValue("@Purpose", newPurpose);
                        cmd.Parameters.AddWithValue("@RequestID", requestId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                            LoadDataFromDatabase(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check your selection.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                int requestId = Convert.ToInt32(DataGridView1.CurrentRow.Cells["Request ID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Equipment WHERE [Request ID] = @RequestID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDataFromDatabase();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void btnSaveRequest_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
            MessageBox.Show("All changes are already saved to the database.");
        }
    }
}
