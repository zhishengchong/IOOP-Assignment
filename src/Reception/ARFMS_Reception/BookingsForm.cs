using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ARFMS_Reception
{
    public partial class BookingsForm : Form
    {
        private readonly Dictionary<int, decimal> _rates = new Dictionary<int, decimal>();
        private class ComboItem
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public override string ToString() => Text;
        }

        public BookingsForm()
        {
            InitializeComponent();

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.ReadOnly = true;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.MultiSelect = false;

            this.Load -= BookingsForm_Load;
            this.Load += BookingsForm_Load;

            cboBFacility.SelectedIndexChanged -= CboFacility_SelectedIndexChanged;
            cboBFacility.SelectedIndexChanged += CboFacility_SelectedIndexChanged;

            nudBHours.ValueChanged -= NudHours_ValueChanged;
            nudBHours.ValueChanged += NudHours_ValueChanged;

            dtpBStart.ValueChanged -= DtpStart_ValueChanged;
            dtpBStart.ValueChanged += DtpStart_ValueChanged;

            btnBCalc.Click -= BtnCalc_Click;
            btnBCalc.Click += BtnCalc_Click;

            btnBAccept.Click -= btnBAccept_Click;
            btnBAccept.Click += btnBAccept_Click;

            btnBSearch.Click -= btnBSearch_Click;
            btnBSearch.Click += btnBSearch_Click;
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            dtpBStart.MinDate = DateTime.Today.AddDays(1);
            dtpBStart.Value = DateTime.Today.AddDays(1).AddHours(9);
            nudBHours.Minimum = 1; nudBHours.Maximum = 8; nudBHours.Value = 1;

            LoadStudents(); 
            LoadFacilities(); 
            LoadBookings(null);
            UpdateRateTotal();
        }

        private void LoadStudents()
        {
            using (var conn = Db.Conn())
            using (var da = new SqlDataAdapter("SELECT StudentID, Name FROM dbo.Student ORDER BY Name", conn))
            {
                var dt = new DataTable(); da.Fill(dt);
                var items = new List<ComboItem>();
                foreach (DataRow r in dt.Rows)
                    items.Add(new ComboItem { Id = Convert.ToInt32(r["StudentID"]), Text = (r["Name"] ?? "").ToString() });
                cboBStudent.DataSource = items; 
                cboBStudent.DisplayMember = "Text"; 
                cboBStudent.ValueMember = "Id";
            }
        }

        private void LoadFacilities()
        {
            using (var conn = Db.Conn())
            using (var da = new SqlDataAdapter(
                "SELECT FacilityID, FacilityName, FacilityCode, RatePerHour FROM dbo.Facility ORDER BY FacilityName", conn))
            {
                var dt = new DataTable(); da.Fill(dt);
                _rates.Clear();
                var items = new List<ComboItem>();
                foreach (DataRow r in dt.Rows)
                {
                    int id = Convert.ToInt32(r["FacilityID"]);
                    string name = (r["FacilityName"] ?? "").ToString();
                    string code = (r["FacilityCode"] ?? "").ToString();
                    decimal rate = Convert.ToDecimal(r["RatePerHour"]);
                    _rates[id] = rate;
                    items.Add(new ComboItem { Id = id, Text = name + " (" + code + ")" });
                }
                cboBFacility.DataSource = items; 
                cboBFacility.DisplayMember = "Text"; 
                cboBFacility.ValueMember = "Id";
            }
        }

        private void LoadBookings(string kw)
        {
            using (var conn = Db.Conn())
            using (var cmd = new SqlCommand(@"
                SELECT b.BookingID, s.Name AS StudentName, f.FacilityCode, f.FacilityName,
                       b.StartAt, b.EndAt, b.Hours, b.RatePerHour, b.TotalCost
                FROM dbo.Booking b
                JOIN dbo.Student s ON b.StudentID=s.StudentID
                JOIN dbo.Facility f ON b.FacilityID=f.FacilityID
                WHERE (@kw IS NULL) OR (s.Name LIKE @kw OR f.FacilityCode LIKE @kw)
                ORDER BY b.BookingID DESC", conn))
            {
                if (string.IsNullOrWhiteSpace(kw))
                    cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@kw", SqlDbType.NVarChar, 100).Value = "%" + kw.Trim() + "%";

                var dt = new DataTable(); new SqlDataAdapter(cmd).Fill(dt);
                dgvBookings.DataSource = dt;
            }

            if (dgvBookings.Columns["BookingID"] != null) dgvBookings.Columns["BookingID"].HeaderText = "ID";
            if (dgvBookings.Columns["StudentName"] != null) dgvBookings.Columns["StudentName"].HeaderText = "Student";
            if (dgvBookings.Columns["RatePerHour"] != null) dgvBookings.Columns["RatePerHour"].HeaderText = "Rate/Hr";
            if (dgvBookings.Columns["TotalCost"] != null) dgvBookings.Columns["TotalCost"].HeaderText = "Total";
        }

        private void UpdateRateTotal()
        {
            var item = cboBFacility.SelectedItem as ComboItem;
            if (item != null && _rates.ContainsKey(item.Id))
            {
                var rate = _rates[item.Id];
                txtBRate.Text = rate.ToString("0.00");
                txtBTotal.Text = (rate * (int)nudBHours.Value).ToString("0.00");
            }
        }

        // 事件处理：全部只做刷新价格/合计
        private void CboFacility_SelectedIndexChanged(object s, EventArgs e) => UpdateRateTotal();
        private void NudHours_ValueChanged(object s, EventArgs e) => UpdateRateTotal();
        private void DtpStart_ValueChanged(object s, EventArgs e) => UpdateRateTotal();
        private void BtnCalc_Click(object s, EventArgs e) => UpdateRateTotal();

        private void btnBAccept_Click(object sender, EventArgs e)
        {
            var stu = cboBStudent.SelectedItem as ComboItem; if (stu == null) { MessageBox.Show("Select student."); return; }
            var fac = cboBFacility.SelectedItem as ComboItem; if (fac == null) { MessageBox.Show("Select facility."); return; }

            DateTime start = dtpBStart.Value; 
            if (start.Date <= DateTime.Today) { MessageBox.Show("At least one day in advance."); return; }
            int hours = (int)nudBHours.Value; 
            DateTime end = start.AddHours(hours);
            decimal rate = _rates.ContainsKey(fac.Id) ? _rates[fac.Id] : 0m; 
            decimal total = rate * hours;

            using (var conn = Db.Conn())
            {
                conn.Open();
                // 冲突检查：如果有重叠时间则拒绝
                using (var chk = new SqlCommand(@"
                    SELECT COUNT(*) FROM dbo.Booking
                    WHERE FacilityID=@fid AND NOT (@EndAt <= StartAt OR @StartAt >= EndAt)", conn))
                {
                    chk.Parameters.Add("@fid", SqlDbType.Int).Value = fac.Id;
                    chk.Parameters.Add("@StartAt", SqlDbType.DateTime2).Value = start;
                    chk.Parameters.Add("@EndAt", SqlDbType.DateTime2).Value = end;
                    int x = Convert.ToInt32(chk.ExecuteScalar());
                    if (x > 0) { MessageBox.Show("Time slot is not available for this facility."); return; }
                }

                using (var cmd = new SqlCommand(@"
                    INSERT INTO dbo.Booking(StudentID, FacilityID, StartAt, EndAt, Hours, RatePerHour, TotalCost)
                    VALUES(@sid,@fid,@st,@ed,@h,@r,@t)", conn))
                {
                    cmd.Parameters.Add("@sid", SqlDbType.Int).Value = stu.Id;
                    cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fac.Id;
                    cmd.Parameters.Add("@st", SqlDbType.DateTime2).Value = start;
                    cmd.Parameters.Add("@ed", SqlDbType.DateTime2).Value = end;
                    cmd.Parameters.Add("@h", SqlDbType.Int).Value = hours;

                    var pR = cmd.Parameters.Add("@r", SqlDbType.Decimal); pR.Precision = 10; pR.Scale = 2; pR.Value = rate;
                    var pT = cmd.Parameters.Add("@t", SqlDbType.Decimal); pT.Precision = 10; pT.Scale = 2; pT.Value = total;

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Booking accepted. Bill generated.");
            LoadBookings(null);
        }

        private void btnBSearch_Click(object sender, EventArgs e) => LoadBookings(txtBSearch.Text);
    }
}
