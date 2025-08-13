
namespace Maintenance_Schedule
{
    partial class Main_Menu
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
            lblWelcome = new Label();
            btnViewSchedule = new Button();
            btnUpdateStatus = new Button();
            btnManageSupplies = new Button();
            btnReplacementRequest = new Button();
            btnUpdateProfile = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(144, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(327, 59);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "\"Welcome\"";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.White;
            btnViewSchedule.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSchedule.Location = new Point(40, 204);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(179, 66);
            btnViewSchedule.TabIndex = 3;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += btnViewSchedule_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.Transparent;
            btnUpdateStatus.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = Color.Black;
            btnUpdateStatus.Location = new Point(292, 204);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(179, 66);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnManageSupplies
            // 
            btnManageSupplies.BackColor = Color.White;
            btnManageSupplies.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageSupplies.Location = new Point(536, 204);
            btnManageSupplies.Name = "btnManageSupplies";
            btnManageSupplies.Size = new Size(179, 66);
            btnManageSupplies.TabIndex = 5;
            btnManageSupplies.Text = "Manage Supplies";
            btnManageSupplies.UseVisualStyleBackColor = false;
            btnManageSupplies.Click += btnManageSupplies_Click;
            // 
            // btnReplacementRequest
            // 
            btnReplacementRequest.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplacementRequest.Location = new Point(40, 312);
            btnReplacementRequest.Name = "btnReplacementRequest";
            btnReplacementRequest.Size = new Size(179, 66);
            btnReplacementRequest.TabIndex = 6;
            btnReplacementRequest.Text = "Replacement Request";
            btnReplacementRequest.UseVisualStyleBackColor = true;
            btnReplacementRequest.Click += btnReplacementRequest_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfile.Location = new Point(292, 312);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(179, 66);
            btnUpdateProfile.TabIndex = 7;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(536, 312);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(179, 66);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnReplacementRequest);
            Controls.Add(btnManageSupplies);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnViewSchedule);
            Controls.Add(lblWelcome);
            Name = "Main_Menu";
            Load += Main_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcome;
        private Button btnViewSchedule;
        private Button btnUpdateStatus;
        private Button btnManageSupplies;
        private Button btnReplacementRequest;
        private Button btnUpdateProfile;
        private Button btnLogout;
    }
}
