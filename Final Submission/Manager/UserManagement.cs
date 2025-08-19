using Final_Submission.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            AddUser aU = new AddUser();
            aU.Show();
        }

        private void delUsers_Click(object sender, EventArgs e)
        {
            DeleteUsers dU = new DeleteUsers();
            dU.Show();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            ArrayList maintenance = new ArrayList();
            ArrayList receptionist = new ArrayList();

            maintenance = Maintenance.viewAll();
            foreach (var itemM in maintenance)
            {
                listBox1.Items.Add(itemM);
            }

            receptionist = Receptionist.viewAll();
            foreach (var itemR in receptionist)
            {
                listBox2.Items.Add(itemR);
            }
        }
    }
}
