using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manager
{
    public partial class EditFacility : Form
    {
        public EditFacility()
        {
            InitializeComponent();
        }

        private void EditFacility_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Facilities f = new Facilities(tbxFac.Text, tbxFacType.Text, tbxMaintRate.Text);
            f.editFacility(tbxFacType.Text,tbxMaintRate.Text);
            tbxFac.Text = String.Empty;
            tbxFacType.Text = String.Empty;
            tbxMaintRate.Text = String.Empty;
        }
    }
}
