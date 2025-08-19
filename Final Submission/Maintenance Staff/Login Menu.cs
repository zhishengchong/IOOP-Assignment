using Microsoft.Data.SqlClient; 
using System;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Login_Menu : Form
    {
        private readonly string connectionString =
            "Data Source=LEBRON\\SQLEXPRESS;Initial Catalog=IOOP-Assignment;Integrated Security=True;TrustServerCertificate=True";
        public int CurrentStaffId { get; private set; } // Add this property
        public string? CurrentStaffName { get; private set; } // Add if you want name too
        public Login_Menu()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            string password = txtBoxPassword.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT [Name] FROM Staff WHERE [Email] = @Email AND [Password] = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null) // shouldn't be null if data exists
                    {
                        string staffName = result.ToString()!;
                        CurrentStaffName = staffName;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.");
                    }
                }
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    

    }
}
