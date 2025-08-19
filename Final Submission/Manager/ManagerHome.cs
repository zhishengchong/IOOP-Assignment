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
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void manUsers_Click(object sender, EventArgs e)
        {
            UserManagement uM = new UserManagement();
            uM.Show();
        }

        private void manFac_Click(object sender, EventArgs e)
        {
            FacilityManagement fM = new FacilityManagement();
            fM.Show();
        }

        private void signMaint_Click(object sender, EventArgs e)
        {
            AssignMaintenance aM = new AssignMaintenance();
            aM.Show();
        }

        private void viewReq_Click(object sender, EventArgs e)
        {
            RequestsMenu rM = new RequestsMenu();
            rM.Show();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {

        }
    }
}
