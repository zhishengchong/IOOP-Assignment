using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Maintenance_Schedule
{
    public partial class Main_Menu : Form
    {
        private int staffId;
        private string connectionString = "Data Source=localhost;Initial Catalog=Maintenance_Schedule;Integrated Security=True;TrustServerCertificate=True";
        public Main_Menu(int currentStaffId)
        {
            InitializeComponent();
            staffId = currentStaffId;
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

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

        private void btnRepairRequest_Click(object sender, EventArgs e)
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
    }
}

 