using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Maintenance_Schedule
{
    public partial class Main_Menu : Form
    {
        private readonly string staffName;
        public Main_Menu(string currentStaffName)
        {
            InitializeComponent();

            staffName = currentStaffName ?? throw new ArgumentNullException(nameof(currentStaffName));
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {staffName}!";
        }

        private void btnManageSupplies_Click(object sender, EventArgs e)
        {
            Equipment_Form eqForm = new Equipment_Form();
            eqForm.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Update_Profile vsForm = new Update_Profile();
            vsForm.ShowDialog();
        }
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            Status_Form vsForm = new Status_Form();
            vsForm.ShowDialog();
        }

        private void btnReplacementRequest_Click(object sender, EventArgs e)
        {
            Replacement_Request vsForm = new Replacement_Request();
            vsForm.ShowDialog();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            Schedule_Form vsForm = new Schedule_Form();
            vsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}

 