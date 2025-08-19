namespace ARFMS_Reception
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            btnDeleteStudent = new Button();
            btnAddStudent = new Button();
            txtUniversity = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblUniversity = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.Info;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(9, 268);
            dgvStudents.Margin = new Padding(2, 2, 2, 2);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.RowTemplate.Height = 30;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(594, 201);
            dgvStudents.TabIndex = 21;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(34, 210);
            btnDeleteStudent.Margin = new Padding(2, 2, 2, 2);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(170, 46);
            btnDeleteStudent.TabIndex = 20;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(257, 210);
            btnAddStudent.Margin = new Padding(2, 2, 2, 2);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(170, 46);
            btnAddStudent.TabIndex = 19;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // txtUniversity
            // 
            txtUniversity.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUniversity.Location = new Point(257, 156);
            txtUniversity.Margin = new Padding(2, 2, 2, 2);
            txtUniversity.Name = "txtUniversity";
            txtUniversity.Size = new Size(171, 30);
            txtUniversity.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtPhone.Location = new Point(257, 104);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(171, 30);
            txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtEmail.Location = new Point(257, 59);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 30);
            txtEmail.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtName.Location = new Point(257, 10);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 30);
            txtName.TabIndex = 15;
            // 
            // lblUniversity
            // 
            lblUniversity.AutoSize = true;
            lblUniversity.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblUniversity.Location = new Point(30, 166);
            lblUniversity.Margin = new Padding(2, 0, 2, 0);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(119, 20);
            lblUniversity.TabIndex = 14;
            lblUniversity.Text = "University:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblPhone.Location = new Point(30, 114);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(69, 20);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblEmail.Location = new Point(30, 69);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("SimSun", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblName.Location = new Point(30, 20);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 20);
            lblName.TabIndex = 11;
            lblName.Text = "Name:";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 470);
            Controls.Add(dgvStudents);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(txtUniversity);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblUniversity);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
    }
}