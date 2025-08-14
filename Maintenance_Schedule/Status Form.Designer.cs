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
            txtBoxFacilityName = new TextBox();
            txtBoxTaskDescription = new TextBox();
            comboBoxStatus = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            lblFacilityName = new Label();
            label1 = new Label();
            lblStatus = new Label();
            DataGridView1 = new DataGridView();
            dateTimePickerDate = new DateTimePicker();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxFacilityName
            // 
            txtBoxFacilityName.Location = new Point(188, 329);
            txtBoxFacilityName.Name = "txtBoxFacilityName";
            txtBoxFacilityName.Size = new Size(100, 23);
            txtBoxFacilityName.TabIndex = 1;
            // 
            // txtBoxTaskDescription
            // 
            txtBoxTaskDescription.Location = new Point(188, 358);
            txtBoxTaskDescription.Name = "txtBoxTaskDescription";
            txtBoxTaskDescription.Size = new Size(100, 23);
            txtBoxTaskDescription.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(188, 385);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(100, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(249, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(413, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblFacilityName
            // 
            lblFacilityName.AutoSize = true;
            lblFacilityName.Location = new Point(58, 332);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new Size(85, 15);
            lblFacilityName.TabIndex = 7;
            lblFacilityName.Text = "Facility Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 361);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Task Description :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(98, 388);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status :";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(776, 282);
            DataGridView1.TabIndex = 10;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(188, 300);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 23);
            dateTimePickerDate.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(106, 306);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date :";
            // 
            // Status_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDate);
            Controls.Add(dateTimePickerDate);
            Controls.Add(DataGridView1);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(lblFacilityName);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxStatus);
            Controls.Add(txtBoxTaskDescription);
            Controls.Add(txtBoxFacilityName);
            Name = "Status_Form";
            Text = "Status Form";
            Load += Status_Form_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxFacilityName;
        private TextBox txtBoxTaskDescription;
        private ComboBox comboBoxStatus;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblFacilityName;
        private Label label1;
        private Label lblStatus;
        private DataGridView DataGridView1;
        private DateTimePicker dateTimePickerDate;
        private Label lblDate;
    }
}