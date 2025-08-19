using Final_Submission.Receptionist;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ARFMS_Reception
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();

            // 表格外观
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;

            // 事件：先解绑再绑定，避免重复
            this.Load -= StudentsForm_Load;
            this.Load += StudentsForm_Load;

            btnAddStudent.Click -= btnAddStudent_Click;
            btnAddStudent.Click += btnAddStudent_Click;

            btnDeleteStudent.Click -= btnDeleteStudent_Click;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
        }

        private void StudentsForm_Load(object sender, EventArgs e) => LoadStudents();

        private void LoadStudents()
        {
            using (var conn = Db.Conn())
            using (var da = new SqlDataAdapter(
                "SELECT StudentID, Name, Email, Phone, University FROM dbo.Student ORDER BY StudentID DESC", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;
            }
            if (dgvStudents.Columns["StudentID"] != null)
                dgvStudents.Columns["StudentID"].HeaderText = "ID";
        }

        private static bool LooksLikeEmail(string s) => Regex.IsMatch(s ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        private static bool LooksLikePhone(string s) => Regex.IsMatch(s ?? "", @"^[0-9+\-\s]{6,20}$");

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Name is required."); txtName.Focus(); return; }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !LooksLikeEmail(txtEmail.Text))
            { MessageBox.Show("Invalid email."); txtEmail.Focus(); return; }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && !LooksLikePhone(txtPhone.Text))
            { MessageBox.Show("Invalid phone."); txtPhone.Focus(); return; }

            using (var conn = Db.Conn())
            using (var cmd = new SqlCommand(
                "INSERT INTO dbo.Student(Name,Email,Phone,University) VALUES(@n,@e,@p,@u)", conn))
            {
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 50).Value = txtName.Text.Trim();
                cmd.Parameters.Add("@e", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim();
                cmd.Parameters.Add("@p", SqlDbType.NVarChar, 20).Value =
                    string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim();
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(txtUniversity.Text) ? (object)DBNull.Value : txtUniversity.Text.Trim();

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadStudents();
            txtName.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtUniversity.Clear();
            txtName.Focus();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) { MessageBox.Show("Select a row."); return; }

            var idObj = dgvStudents.Columns.Contains("StudentID")
                ? dgvStudents.CurrentRow.Cells["StudentID"].Value
                : dgvStudents.CurrentRow.Cells[0].Value;

            int id;
            if (idObj == null || !int.TryParse(idObj.ToString(), out id))
            { MessageBox.Show("Invalid id."); return; }

            if (MessageBox.Show($"Delete StudentID={id}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            using (var conn = Db.Conn())
            using (var cmd = new SqlCommand("DELETE FROM dbo.Student WHERE StudentID=@id", conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadStudents();
        }

        private void StudentsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
