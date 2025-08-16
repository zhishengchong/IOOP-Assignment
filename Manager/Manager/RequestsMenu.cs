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
    public partial class RequestsMenu : Form
    {
        public RequestsMenu()
        {
            InitializeComponent();
        }

        private void RequestsMenu_Load(object sender, EventArgs e)
        {
            Requests r = new Requests();
            r.GetRequest(listView1);
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            string staff = listView1.SelectedItems[0].Text;   
            string request = listView1.SelectedItems[1].Text; 
            string date = listView1.SelectedItems[2].Text;    
            string status = string.Empty;
            if (radA.Checked)
            {
                status = "Approved";
            }
            else if(radR.Checked)
            {
                status = "Rejected";
            }
            else
            {
                status = "Pending";
            }

            Requests r = new Requests(staff, request, date, status);
            r.editStatus(staff, request, date, status);
        }
    }
}
