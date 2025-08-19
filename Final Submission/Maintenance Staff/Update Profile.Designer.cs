namespace Maintenance_Schedule
{
    partial class Update_Profile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxName = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxPhone = new TextBox();
            txtBoxPassword = new TextBox();
            btnSaveProfile = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblPassword = new Label();
            DataGridViewStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(162, 239);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(343, 23);
            txtBoxName.TabIndex = 0;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(162, 286);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(343, 23);
            txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(162, 334);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(343, 23);
            txtBoxPhone.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(162, 387);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(343, 23);
            txtBoxPassword.TabIndex = 3;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Location = new Point(647, 269);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(120, 23);
            btnSaveProfile.TabIndex = 4;
            btnSaveProfile.Text = "Save Profile";
            btnSaveProfile.UseVisualStyleBackColor = true;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(646, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 242);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 289);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(28, 337);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(28, 390);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password :";
            // 
            // DataGridViewStaff
            // 
            DataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewStaff.Location = new Point(12, 12);
            DataGridViewStaff.Name = "DataGridViewStaff";
            DataGridViewStaff.Size = new Size(776, 196);
            DataGridViewStaff.TabIndex = 10;
            // 
            // Update_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridViewStaff);
            Controls.Add(lblPassword);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProfile);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxPhone);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxName);
            Name = "Update_Profile";
            Text = "Update Profile";
            Load += Update_Profile_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPhone;
        private TextBox txtBoxPassword;
        private Button btnSaveProfile;
        private Button btnCancel;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblPassword;
        private DataGridView DataGridViewStaff;
    }
}
