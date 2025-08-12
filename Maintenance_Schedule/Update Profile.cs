using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Maintenance_Schedule
{
    public partial class Update_Profile : Form
    {
        public Update_Profile()
        {
            InitializeComponent();
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=LEBRON\\SQLEXPRESS;Database=IOOP-Assignment;Trusted_Connection=True;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Correct SQL command syntax — you must use SELECT
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Staff]", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridViewStaff.DataSource = dt;
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LEBRON\\SQLEXPRESS;Database=IOOP-Assignment;Trusted_Connection=True;TrustServerCertificate=True;";

            // Example: assumes you have txtName, txtEmail, txtPhone, txtPassword textboxes
            string name = txtBoxName.Text.Trim();
            string email = txtBoxEmail.Text.Trim();
            string phone = txtBoxPhone.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            // You'll need to know which Staff ID to update
            int staffId = Convert.ToInt32(txtBoxStaffId.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Staff
                         SET Name = @Name,
                             Email = @Email,
                             [Phone Number] = @Phone,
                             Password = @Password
                         WHERE [Staff ID] = @StaffID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No profile was updated. Check Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
