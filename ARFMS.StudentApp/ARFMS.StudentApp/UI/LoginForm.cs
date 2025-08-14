using System;
using System.Windows.Forms;
using ARFMS.StudentApp.Data;

namespace ARFMS.StudentApp.UI
{
    public partial class LoginForm : Form
    {
        private readonly StudentRepository _students = new StudentRepository();

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // pressing Enter triggers login
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            var email = txtEmail.Text.Trim();
            var pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                lblError.Text = "Please enter email and password.";
                return;
            }

            try
            {
                var s = _students.Login(email, pass);
                if (s == null)
                {
                    lblError.Text = "Invalid email or password.";
                    return;
                }

                // open dashboard
                var dash = new StudentDashboardForm(s);
                dash.FormClosed += (_, __) => this.Show();
                this.Hide();
                dash.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }
    }
}
