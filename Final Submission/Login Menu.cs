using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Submission_compile
{
    public partial class Login_Menu : Form
    {
        private readonly string _connectionString =
            "Server=LEBRON\\SQLEXPRESS;Database=IOOP-Assignment;Trusted_Connection=True;TrustServerCertificate=True;";

        public Login_Menu()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // Press Enter = Login
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            var email = txtBoxEmail.Text.Trim();
            var pass = txtBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                lblError.Text = "Please enter email and password.";
                return;
            }

            try
            {
                using (var con = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("SELECT Name, Role, PhoneNumber FROM Users WHERE Email=@e AND Password=@p", con))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", pass);
                    con.Open();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string name = rdr["Name"].ToString()!;
                            string role = rdr["Role"].ToString()!;
                            string phone = rdr["PhoneNumber"].ToString()!;

                            Form nextForm = null;

                            switch (role)
                            {
                                case "Manager":
                                    nextForm = new Manager.ManagerHome();
                                    break;
                                case "Reception":
                                    nextForm = new ARFMS_Reception.ReceptionMain();
                                    break;
                                case "Student":
                                    nextForm = new ARFMS.StudentApp.UI.StudentDashboardForm();
                                    break;
                                case "Maintenance":
                                    nextForm = new Maintenance_Schedule.Main_Menu(name);
                                    break;
                                default:
                                    lblError.Text = "Unknown role: " + role;
                                    return;
                            }

                            // Show next form
                            nextForm.FormClosed += (_, __) => this.Show();
                            this.Hide();
                            nextForm.Show();
                        }
                        else
                        {
                            lblError.Text = "Invalid email or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
