using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Update_Profile : Form
    {
        private string connectionString = "Server=LEBRON\\SQLEXPRESS;Database=IOOP-Assignment;Trusted_Connection=True;Encrypt=False;";

        public Update_Profile()
        {
            InitializeComponent();
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            LoadStaffProfile();
        }

        private void LoadStaffProfile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 [Staff ID], Name, Email, [Phone Number], Password " +
                    "FROM [dbo].[Staff]", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridViewStaff.DataSource = dt;

                // Fill textboxes with the staff's data
                if (dt.Rows.Count > 0)
                {
                    txtBoxName.Text = dt.Rows[0]["Name"].ToString();
                    txtBoxEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtBoxPhone.Text = dt.Rows[0]["Phone Number"].ToString();
                    txtBoxPassword.Text = dt.Rows[0]["Password"].ToString();
                }
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text.Trim();
            string email = txtBoxEmail.Text.Trim();
            string phone = txtBoxPhone.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Update only the first staff found
                string query = @"UPDATE Staff
                                 SET Name = @Name,
                                     Email = @Email,
                                     [Phone Number] = @Phone,
                                     Password = @Password
                                 WHERE [Staff ID] = (SELECT TOP 1 [Staff ID] FROM Staff)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffProfile(); // Refresh table
                    }
                    else
                    {
                        MessageBox.Show("No profile was updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
