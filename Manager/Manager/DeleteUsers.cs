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
    public partial class DeleteUsers : Form
    {
        public DeleteUsers()
        {
            InitializeComponent();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (radMaint.Checked)
            {
                Maintenance m = new Maintenance(tbxName.Text);
                string status = m.deleteProfile();
                tbxName.Text = String.Empty;
            }
            else if (radRecpt.Checked)
            {
                Receptionist r = new Receptionist(tbxName.Text);
                string status = r.deleteProfile();
                tbxName.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Please select a user type to delete.");
            }
        }
    }
}
