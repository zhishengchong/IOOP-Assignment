namespace Maintenance_Schedule
{
    partial class Status_Form
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
            comboBoxSelectScheduleID = new ComboBox();
            txtBoxFacilityName = new TextBox();
            txtBoxTaskDescription = new TextBox();
            comboBoxStatus = new ComboBox();
            btnSaveStatus = new Button();
            btnCancel = new Button();
            lblSelectScheduleID = new Label();
            lblFacilityName = new Label();
            label1 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // comboBoxSelectScheduleID
            // 
            comboBoxSelectScheduleID.FormattingEnabled = true;
            comboBoxSelectScheduleID.Location = new Point(269, 92);
            comboBoxSelectScheduleID.Name = "comboBoxSelectScheduleID";
            comboBoxSelectScheduleID.Size = new Size(121, 23);
            comboBoxSelectScheduleID.TabIndex = 0;
            comboBoxSelectScheduleID.SelectedIndexChanged += comboBoxSelectScheduleID_SelectedIndexChanged;
            // 
            // txtBoxFacilityName
            // 
            txtBoxFacilityName.Location = new Point(269, 147);
            txtBoxFacilityName.Name = "txtBoxFacilityName";
            txtBoxFacilityName.Size = new Size(100, 23);
            txtBoxFacilityName.TabIndex = 1;
            // 
            // txtBoxTaskDescription
            // 
            txtBoxTaskDescription.Location = new Point(269, 205);
            txtBoxTaskDescription.Name = "txtBoxTaskDescription";
            txtBoxTaskDescription.Size = new Size(100, 23);
            txtBoxTaskDescription.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(269, 263);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnSaveStatus
            // 
            btnSaveStatus.Location = new Point(227, 361);
            btnSaveStatus.Name = "btnSaveStatus";
            btnSaveStatus.Size = new Size(75, 23);
            btnSaveStatus.TabIndex = 4;
            btnSaveStatus.Text = "Save Status";
            btnSaveStatus.UseVisualStyleBackColor = true;
            btnSaveStatus.Click += btnSaveStatus_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(429, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSelectScheduleID
            // 
            lblSelectScheduleID.AutoSize = true;
            lblSelectScheduleID.Location = new Point(81, 92);
            lblSelectScheduleID.Name = "lblSelectScheduleID";
            lblSelectScheduleID.Size = new Size(109, 15);
            lblSelectScheduleID.TabIndex = 6;
            lblSelectScheduleID.Text = "Select Schedule ID :";
            // 
            // lblFacilityName
            // 
            lblFacilityName.AutoSize = true;
            lblFacilityName.Location = new Point(81, 150);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new Size(85, 15);
            lblFacilityName.TabIndex = 7;
            lblFacilityName.Text = "Facility Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 208);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Task Description :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(81, 266);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status :";
            // 
            // Status_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(lblFacilityName);
            Controls.Add(lblSelectScheduleID);
            Controls.Add(btnSaveStatus);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxStatus);
            Controls.Add(txtBoxTaskDescription);
            Controls.Add(txtBoxFacilityName);
            Controls.Add(comboBoxSelectScheduleID);
            Name = "Status_Form";
            Text = "Status Form";
            Load += Status_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSelectScheduleID;
        private TextBox txtBoxFacilityName;
        private TextBox txtBoxTaskDescription;
        private ComboBox comboBoxStatus;
        private Button btnSaveStatus;
        private Button btnCancel;
        private Label lblSelectScheduleID;
        private Label lblFacilityName;
        private Label label1;
        private Label lblStatus;
    }
}