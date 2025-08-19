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
            datePicker = new DateTimePicker();
            lblDate = new Label();
            timePicker = new DateTimePicker();
            lblTime = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxFacilityName
            // 
            txtBoxFacilityName.Location = new Point(123, 91);
            txtBoxFacilityName.Name = "txtBoxFacilityName";
            txtBoxFacilityName.Size = new Size(100, 23);
            txtBoxFacilityName.TabIndex = 1;
            // 
            // txtBoxTaskDescription
            // 
            txtBoxTaskDescription.Location = new Point(123, 141);
            txtBoxTaskDescription.Name = "txtBoxTaskDescription";
            txtBoxTaskDescription.Size = new Size(100, 23);
            txtBoxTaskDescription.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(123, 186);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(100, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(208, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFacilityName
            // 
            lblFacilityName.AutoSize = true;
            lblFacilityName.Location = new Point(12, 99);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new Size(85, 15);
            lblFacilityName.TabIndex = 7;
            lblFacilityName.Text = "Facility Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 149);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Task Description :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 194);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status :";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(366, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(422, 426);
            DataGridView1.TabIndex = 10;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(123, 50);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 56);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date :";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(123, 239);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(200, 23);
            timePicker.TabIndex = 13;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(12, 245);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(40, 15);
            lblTime.TabIndex = 14;
            lblTime.Text = "Time :";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(48, 384);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(208, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Status_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblTime);
            Controls.Add(timePicker);
            Controls.Add(lblDate);
            Controls.Add(datePicker);
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
        private DateTimePicker datePicker;
        private Label lblDate;
        private DateTimePicker timePicker;
        private Label lblTime;
        private Button btnEdit;
        private Button btnDelete;
    }
}