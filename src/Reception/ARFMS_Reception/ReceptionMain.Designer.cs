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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStudents.Location = new System.Drawing.Point(27, 60);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(165, 50);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBookings.Location = new System.Drawing.Point(27, 132);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(165, 50);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPayments.Location = new System.Drawing.Point(27, 204);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(165, 50);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // ReceptionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnStudents);
            this.Name = "ReceptionMain";
            this.Text = "ReceptionMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnPayments;
    }
}