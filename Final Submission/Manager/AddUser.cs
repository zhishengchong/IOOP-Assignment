using Final_Submission.Manager;
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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (radMaint.Checked)
            {
                Maintenance m = new Maintenance(tbxName.Text, tbxEmail.Text, tbxPhoneNumber.Text);
                m.addMaintenance();
                tbxName.Text = String.Empty;
                tbxEmail.Text = String.Empty;
                tbxPhoneNumber.Text = String.Empty;
            }
            else if (radRecpt.Checked)
            {
                Receptionist r = new Receptionist(tbxName.Text, tbxEmail.Text, tbxPhoneNumber.Text);
                r.addReceptionist();
                tbxName.Text = String.Empty;
                tbxEmail.Text = String.Empty;
                tbxPhoneNumber.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Please select a user type.");
            }

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
