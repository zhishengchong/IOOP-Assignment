using System;
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
    }
}
