
namespace Maintenance_Schedule
{
    partial class Form1
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
            lblInfo = new Label();
            btnViewSchedule = new Button();
            btnUpdateStatus = new Button();
            btnManageSupplies = new Button();
            btnRepairRequest = new Button();
            btnUpdateProfile = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(68, 68);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(639, 59);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Welcome [Staff Name]";
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.White;
            btnViewSchedule.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSchedule.Location = new Point(68, 204);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(151, 66);
            btnViewSchedule.TabIndex = 3;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += button4_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.Transparent;
            btnUpdateStatus.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = Color.Black;
            btnUpdateStatus.Location = new Point(300, 204);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(148, 66);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += button2_Click;
            // 
            // btnManageSupplies
            // 
            btnManageSupplies.BackColor = Color.White;
            btnManageSupplies.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageSupplies.Location = new Point(536, 204);
            btnManageSupplies.Name = "btnManageSupplies";
            btnManageSupplies.Size = new Size(148, 66);
            btnManageSupplies.TabIndex = 5;
            btnManageSupplies.Text = "Manage Supplies";
            btnManageSupplies.UseVisualStyleBackColor = false;
            // 
            // btnRepairRequest
            // 
            btnRepairRequest.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRepairRequest.Location = new Point(68, 312);
            btnRepairRequest.Name = "btnRepairRequest";
            btnRepairRequest.Size = new Size(151, 66);
            btnRepairRequest.TabIndex = 6;
            btnRepairRequest.Text = "Repair Request";
            btnRepairRequest.UseVisualStyleBackColor = true;
            btnRepairRequest.Click += button4_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.Location = new Point(300, 312);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(151, 66);
            btnUpdateProfile.TabIndex = 7;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(536, 312);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(151, 66);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnRepairRequest);
            Controls.Add(btnManageSupplies);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnViewSchedule);
            Controls.Add(lblInfo);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schedule_Form vsForm = new Schedule_Form();
            vsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lblInfo;
        private Button btnViewSchedule;
        private Button btnUpdateStatus;
        private Button btnManageSupplies;
        private Button btnRepairRequest;
        private Button btnUpdateProfile;
        private Button btnLogout;
    }
}
