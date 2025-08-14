namespace Maintenance_Schedule
{
    partial class Schedule_Form
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
            DataGridView1 = new DataGridView();
            DateTimePickerFilterScheduleByDate = new DateTimePicker();
            lblFilterScheduleByDate = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.BackgroundColor = Color.Silver;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 78);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(776, 360);
            DataGridView1.TabIndex = 0;
            // 
            // DateTimePickerFilterScheduleByDate
            // 
            DateTimePickerFilterScheduleByDate.Location = new Point(149, 35);
            DateTimePickerFilterScheduleByDate.Name = "DateTimePickerFilterScheduleByDate";
            DateTimePickerFilterScheduleByDate.Size = new Size(200, 23);
            DateTimePickerFilterScheduleByDate.TabIndex = 1;
            DateTimePickerFilterScheduleByDate.ValueChanged += DateTimePickerFilterScheduleByDate_ValueChanged;
            // 
            // lblFilterScheduleByDate
            // 
            lblFilterScheduleByDate.AutoSize = true;
            lblFilterScheduleByDate.Location = new Point(12, 38);
            lblFilterScheduleByDate.Name = "lblFilterScheduleByDate";
            lblFilterScheduleByDate.Size = new Size(131, 15);
            lblFilterScheduleByDate.TabIndex = 3;
            lblFilterScheduleByDate.Text = "Filter schedule by date :";
            // 
            // Schedule_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFilterScheduleByDate);
            Controls.Add(DateTimePickerFilterScheduleByDate);
            Controls.Add(DataGridView1);
            Name = "Schedule_Form";
            Text = "Schedule Form";
            Load += Schedule_Form_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView1;
        private DateTimePicker DateTimePickerFilterScheduleByDate;
        private Label lblFilterScheduleByDate;
    }
}
