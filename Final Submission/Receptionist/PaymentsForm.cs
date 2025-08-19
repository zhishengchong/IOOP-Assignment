using Final_Submission.Receptionist;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ARFMS_Reception
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.ReadOnly = true;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.MultiSelect = false;

            dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipts.ReadOnly = true;

            this.Load -= PaymentsForm_Load;
            this.Load += PaymentsForm_Load;

            dgvBookings.SelectionChanged -= DgvBookings_SelectionChanged;
            dgvBookings.SelectionChanged += DgvBookings_SelectionChanged;

            btnAcceptPayment.Click -= btnAcceptPayment_Click;
            btnAcceptPayment.Click += btnAcceptPayment_Click;

            btnPreviewReceipt.Click -= btnPreviewReceipt_Click;
            btnPreviewReceipt.Click += btnPreviewReceipt_Click;
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            cboPMethod.Items.Clear();
            cboPMethod.Items.AddRange(new object[] { "Cash", "Card", "E-Wallet" });
            if (cboPMethod.Items.Count > 0) cboPMethod.SelectedIndex = 0;

            LoadBookings();
            LoadReceipts();
            UpdatePanel();
        }

        private void LoadBookings()
        {
            using (var conn = Db.Conn())
            using (var da = new SqlDataAdapter(@"
                SELECT b.BookingID, s.Name AS Student, f.FacilityCode AS Code, f.FacilityName AS Facility,
                       b.StartAt, b.EndAt, b.Hours, b.RatePerHour, b.TotalCost,
                       CASE WHEN r.ReceiptID IS NULL THEN 0 ELSE 1 END AS Paid
                FROM dbo.Booking b
                JOIN dbo.Student s ON b.StudentID=s.StudentID
                JOIN dbo.Facility f ON b.FacilityID=f.FacilityID
                LEFT JOIN dbo.Receipt r ON r.BookingID=b.BookingID
                ORDER BY b.BookingID DESC", conn))
            {
                var dt = new DataTable(); da.Fill(dt);
                dgvBookings.DataSource = dt;
            }
            if (dgvBookings.Columns["Paid"] != null) dgvBookings.Columns["Paid"].HeaderText = "Paid";
        }

        private void LoadReceipts()
        {
            using (var conn = Db.Conn())
            using (var da = new SqlDataAdapter(@"
                SELECT r.ReceiptID, r.BookingID, s.Name AS Student, f.FacilityCode AS Code,
                       r.PaymentMethod AS Method, r.AmountPaid AS Amount, r.PaidAt
                FROM dbo.Receipt r
                JOIN dbo.Booking b ON r.BookingID=b.BookingID
                JOIN dbo.Student s ON b.StudentID=s.StudentID
                JOIN dbo.Facility f ON b.FacilityID=f.FacilityID
                ORDER BY r.ReceiptID DESC", conn))
            {
                var dt = new DataTable(); da.Fill(dt);
                dgvReceipts.DataSource = dt;
            }
        }

        private void DgvBookings_SelectionChanged(object sender, EventArgs e) => UpdatePanel();

        private void UpdatePanel()
        {
            if (dgvBookings.CurrentRow == null)
            {
                txtPBookingID.Text = ""; txtPTotal.Text = ""; txtPAmount.Text = "";
                btnAcceptPayment.Enabled = false; return;
            }

            var idObj = dgvBookings.Columns.Contains("BookingID")
                ? dgvBookings.CurrentRow.Cells["BookingID"].Value
                : dgvBookings.CurrentRow.Cells[0].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int bid))
            { btnAcceptPayment.Enabled = false; return; }
            txtPBookingID.Text = bid.ToString();

            object totObj = dgvBookings.Columns.Contains("TotalCost")
                ? dgvBookings.CurrentRow.Cells["TotalCost"].Value
                : dgvBookings.CurrentRow.Cells[dgvBookings.ColumnCount - 1].Value;

            if (!decimal.TryParse(totObj?.ToString() ?? "0", out decimal total)) total = 0m;
            txtPTotal.Text = total.ToString("0.00");
            txtPAmount.Text = total.ToString("0.00");

            object paidObj = dgvBookings.Columns.Contains("Paid")
                ? dgvBookings.CurrentRow.Cells["Paid"].Value
                : null;

            bool paid = paidObj != null && paidObj.ToString() == "1";
            btnAcceptPayment.Enabled = !paid;
        }

        private void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPBookingID.Text, out int bid)) { MessageBox.Show("Select a booking."); return; }
            if (!decimal.TryParse(txtPAmount.Text, out decimal amount) || amount <= 0) { MessageBox.Show("Enter valid amount."); return; }
            string method = cboPMethod.SelectedItem?.ToString() ?? "Cash";

            // 防重复：有唯一索引，也先查一次友好提示
            using (var c0 = Db.Conn())
            using (var z = new SqlCommand("SELECT COUNT(*) FROM dbo.Receipt WHERE BookingID=@id", c0))
            {
                z.Parameters.Add("@id", SqlDbType.Int).Value = bid;
                c0.Open();
                if (Convert.ToInt32(z.ExecuteScalar()) > 0) { MessageBox.Show("Already paid."); return; }
            }

            using (var conn = Db.Conn())
            using (var cmd = new SqlCommand(
                "INSERT INTO dbo.Receipt(BookingID,AmountPaid,PaymentMethod) VALUES(@b,@a,@m)", conn))
            {
                cmd.Parameters.Add("@b", SqlDbType.Int).Value = bid;

                var pAmt = cmd.Parameters.Add("@a", SqlDbType.Decimal);
                pAmt.Precision = 10; pAmt.Scale = 2; pAmt.Value = amount;

                cmd.Parameters.Add("@m", SqlDbType.NVarChar, 20).Value = method;

                conn.Open(); cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Payment accepted & receipt created.");
            LoadBookings(); LoadReceipts(); UpdatePanel();
        }

        private void btnPreviewReceipt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPBookingID.Text, out int bid)) { MessageBox.Show("Select a booking."); return; }

            using (var conn = Db.Conn())
            using (var cmd = new SqlCommand(@"
                SELECT TOP 1 r.ReceiptID, r.AmountPaid, r.PaymentMethod, r.PaidAt,
                       s.Name AS Student, f.FacilityName, f.FacilityCode,
                       b.StartAt, b.EndAt, b.Hours, b.RatePerHour, b.TotalCost
                FROM dbo.Receipt r
                JOIN dbo.Booking b ON r.BookingID=b.BookingID
                JOIN dbo.Student s ON b.StudentID=s.StudentID
                JOIN dbo.Facility f ON b.FacilityID=f.FacilityID
                WHERE r.BookingID=@bid", conn))
            {
                cmd.Parameters.Add("@bid", SqlDbType.Int).Value = bid;
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) { MessageBox.Show("No receipt yet."); return; }

                    string text =
                        "RECEIPT\n" +
                        "------------------------------\n" +
                        $"Receipt#: {rd["ReceiptID"]}\n" +
                        $"Student : {rd["Student"]}\n" +
                        $"Facility: {rd["FacilityName"]} ({rd["FacilityCode"]})\n" +
                        $"Period  : {((DateTime)rd["StartAt"]):yyyy-MM-dd HH:mm} ~ {((DateTime)rd["EndAt"]):HH:mm}\n" +
                        $"Hours   : {rd["Hours"]}\n" +
                        $"Rate/Hr : {Convert.ToDecimal(rd["RatePerHour"]):0.00}\n" +
                        $"Total   : {Convert.ToDecimal(rd["TotalCost"]):0.00}\n" +
                        $"Paid    : {Convert.ToDecimal(rd["AmountPaid"]):0.00}\n" +
                        $"Method  : {rd["PaymentMethod"]}\n" +
                        $"PaidAt  : {((DateTime)rd["PaidAt"]).ToLocalTime():yyyy-MM-dd HH:mm}\n";
                    MessageBox.Show(text, "Receipt Preview");
                }
            }
        }
    }
}
