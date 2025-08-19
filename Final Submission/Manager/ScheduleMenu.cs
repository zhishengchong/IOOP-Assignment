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
    public partial class ScheduleMenu : Form
    {
        public ScheduleMenu()
        {
            InitializeComponent();
        }

        private void ScheduleMenu_Load(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.GetSchedule(listView1);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            AssignMaintenance aM = new AssignMaintenance();
            aM.Show();
        }
    }
}
