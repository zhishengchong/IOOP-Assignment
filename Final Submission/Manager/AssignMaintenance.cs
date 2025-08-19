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
    public partial class AssignMaintenance : Form
    {
        public AssignMaintenance()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule(tbxName.Text, tbxEmail.Text, tbxPhoneNumber.Text);
            s.AddSchedule();
            tbxName.Text = String.Empty;
            tbxEmail.Text = String.Empty;
            tbxPhoneNumber.Text = String.Empty;
        }
    }
}
