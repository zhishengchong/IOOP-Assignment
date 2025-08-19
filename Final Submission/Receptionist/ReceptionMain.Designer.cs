namespace ARFMS_Reception
{
    partial class ReceptionMain
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
            btnStudents = new Button();
            btnBookings = new Button();
            btnPayments = new Button();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStudents.Location = new Point(21, 50);
            btnStudents.Margin = new Padding(2, 2, 2, 2);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(128, 42);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            btnBookings.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBookings.Location = new Point(21, 110);
            btnBookings.Margin = new Padding(2, 2, 2, 2);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(128, 42);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("SimSun", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnPayments.Location = new Point(21, 170);
            btnPayments.Margin = new Padding(2, 2, 2, 2);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(128, 42);
            btnPayments.TabIndex = 2;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // ReceptionMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 295);
            Controls.Add(btnPayments);
            Controls.Add(btnBookings);
            Controls.Add(btnStudents);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReceptionMain";
            Text = "ReceptionMainMenu";
            Load += ReceptionMain_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnPayments;
    }
}