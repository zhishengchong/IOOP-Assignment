using System;
using System.Windows.Forms;

namespace ARFMS_Reception
{
    public partial class ReceptionMain : Form
    {
        public ReceptionMain()
        {
            InitializeComponent();

            // 先解绑再绑定，避免重复订阅
            if (btnStudents != null)
            {
                btnStudents.Click -= BtnStudents_Click;
                btnStudents.Click += BtnStudents_Click;
            }
            if (btnBookings != null)
            {
                btnBookings.Click -= BtnBookings_Click;
                btnBookings.Click += BtnBookings_Click;
            }
            if (btnPayments != null)
            {
                btnPayments.Click -= BtnPayments_Click;
                btnPayments.Click += BtnPayments_Click;
            }
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            using (var f = new StudentsForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void BtnBookings_Click(object sender, EventArgs e)
        {
            using (var f = new BookingsForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new PaymentsForm())
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Payments window:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceptionMain_Load(object sender, EventArgs e)
        {

        }
    }
}
