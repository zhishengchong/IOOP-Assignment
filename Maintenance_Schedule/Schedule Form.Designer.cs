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
            DataGridView = new DataGridView();
            DateTimePickerFilterScheduleByDate = new DateTimePicker();
            btnRefresh = new Button();
            lblFilterScheduleByDate = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.BackgroundColor = Color.Silver;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 78);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(776, 331);
            DataGridView.TabIndex = 0;
            DataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DateTimePickerFilterScheduleByDate
            // 
            DateTimePickerFilterScheduleByDate.Location = new Point(149, 35);
            DateTimePickerFilterScheduleByDate.Name = "DateTimePickerFilterScheduleByDate";
            DateTimePickerFilterScheduleByDate.Size = new Size(200, 23);
            DateTimePickerFilterScheduleByDate.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(347, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFilterScheduleByDate);
            Controls.Add(btnRefresh);
            Controls.Add(DateTimePickerFilterScheduleByDate);
            Controls.Add(DataGridView);
            Name = "Schedule_Form";
            Text = "Schedule Form";
            Load += Schedule_Form_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private DateTimePicker DateTimePickerFilterScheduleByDate;
        private Button btnRefresh;
        private Label lblFilterScheduleByDate;
    }
}
