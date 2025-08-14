using System;
using System.Windows.Forms;

namespace ARFMS.StudentApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the login screen
            Application.Run(new UI.LoginForm());
        }
    }
}
