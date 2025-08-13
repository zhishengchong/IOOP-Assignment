
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Equipment_Form : Form
    {
        private string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;";

        public Equipment_Form()
        {
            InitializeComponent();
        }
        private void Equipment_Form_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
        }

        private void LoadDataFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Equipment", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridView1.DataSource = dt;
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Equipment ([Item Name], Quantity, Purpose) VALUES (@ItemName, @Quantity, @Purpose)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemName", "New Item");
                    cmd.Parameters.AddWithValue("@Quantity", 0);
                    cmd.Parameters.AddWithValue("@Purpose", "Purpose here");
                    cmd.ExecuteNonQuery();
                }
            }
            LoadDataFromDatabase();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                int requestId = Convert.ToInt32(DataGridView1.CurrentRow.Cells["Request ID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Equipment SET [Item Name] = @ItemName, Quantity = @Quantity, Purpose = @Purpose WHERE [Request ID] = @RequestID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", DataGridView1.CurrentRow.Cells["Item Name"].Value);
                        cmd.Parameters.AddWithValue("@Quantity", DataGridView1.CurrentRow.Cells["Quantity"].Value);
                        cmd.Parameters.AddWithValue("@Purpose", DataGridView1.CurrentRow.Cells["Purpose"].Value);
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDataFromDatabase();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
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
            MessageBox.Show("All changes are already saved to the database.");
        }
    }
}
