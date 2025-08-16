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
                if (status == "Success")
                {
                    MessageBox.Show("Maintenance user deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error deleting maintenance user.");
                }
            }
            else if (radRecpt.Checked)
            {
                Receptionist r = new Receptionist(tbxName.Text);
                string status = r.deleteProfile();
                if (status == "Success")
                {
                    MessageBox.Show("Receptionist user deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Error deleting receptionist user.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user type to delete.");
            }
        }
    }
}
