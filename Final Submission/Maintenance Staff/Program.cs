using System;
using System.Windows.Forms;

namespace Final_Submission_compile
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show login form first
            Login_Menu loginForm = new Login_Menu();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main_Menu(loginForm.CurrentStaffName!));
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
