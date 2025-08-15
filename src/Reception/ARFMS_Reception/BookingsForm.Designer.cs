namespace ARFMS_Reception
{
    partial class BookingsForm
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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnBSearch = new System.Windows.Forms.Button();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.btnBAccept = new System.Windows.Forms.Button();
            this.btnBCalc = new System.Windows.Forms.Button();
            this.txtBTotal = new System.Windows.Forms.TextBox();
            this.lblBTotal = new System.Windows.Forms.Label();
            this.txtBRate = new System.Windows.Forms.TextBox();
            this.lblBSearch = new System.Windows.Forms.Label();
            this.lblBRate = new System.Windows.Forms.Label();
            this.nudBHours = new System.Windows.Forms.NumericUpDown();
            this.lblBHours = new System.Windows.Forms.Label();
            this.dtpBStart = new System.Windows.Forms.DateTimePicker();
            this.lblBStart = new System.Windows.Forms.Label();
            this.cboBFacility = new System.Windows.Forms.ComboBox();
            this.lblBFacility = new System.Windows.Forms.Label();
            this.cboBStudent = new System.Windows.Forms.ComboBox();
            this.gbBooking = new System.Windows.Forms.GroupBox();
            this.lblBStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBHours)).BeginInit();
            this.gbBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(54, 358);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 62;
            this.dgvBookings.RowTemplate.Height = 30;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(719, 214);
            this.dgvBookings.TabIndex = 20;
            // 
            // btnBSearch
            // 
            this.btnBSearch.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBSearch.Location = new System.Drawing.Point(645, 312);
            this.btnBSearch.Name = "btnBSearch";
            this.btnBSearch.Size = new System.Drawing.Size(128, 33);
            this.btnBSearch.TabIndex = 19;
            this.btnBSearch.Text = "Search";
            this.btnBSearch.UseVisualStyleBackColor = true;
            // 
            // txtBSearch
            // 
            this.txtBSearch.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBSearch.Location = new System.Drawing.Point(450, 310);
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(173, 35);
            this.txtBSearch.TabIndex = 18;
            // 
            // btnBAccept
            // 
            this.btnBAccept.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBAccept.Location = new System.Drawing.Point(28, 219);
            this.btnBAccept.Name = "btnBAccept";
            this.btnBAccept.Size = new System.Drawing.Size(209, 55);
            this.btnBAccept.TabIndex = 13;
            this.btnBAccept.Text = "Accept Booking";
            this.btnBAccept.UseVisualStyleBackColor = true;
            // 
            // btnBCalc
            // 
            this.btnBCalc.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBCalc.Location = new System.Drawing.Point(445, 219);
            this.btnBCalc.Name = "btnBCalc";
            this.btnBCalc.Size = new System.Drawing.Size(209, 55);
            this.btnBCalc.TabIndex = 12;
            this.btnBCalc.Text = "Calc Total";
            this.btnBCalc.UseVisualStyleBackColor = true;
            // 
            // txtBTotal
            // 
            this.txtBTotal.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBTotal.Location = new System.Drawing.Point(554, 98);
            this.txtBTotal.Name = "txtBTotal";
            this.txtBTotal.ReadOnly = true;
            this.txtBTotal.Size = new System.Drawing.Size(100, 35);
            this.txtBTotal.TabIndex = 11;
            // 
            // lblBTotal
            // 
            this.lblBTotal.AutoSize = true;
            this.lblBTotal.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBTotal.Location = new System.Drawing.Point(418, 109);
            this.lblBTotal.Name = "lblBTotal";
            this.lblBTotal.Size = new System.Drawing.Size(82, 24);
            this.lblBTotal.TabIndex = 10;
            this.lblBTotal.Text = "Total:";
            // 
            // txtBRate
            // 
            this.txtBRate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBRate.Location = new System.Drawing.Point(554, 24);
            this.txtBRate.Name = "txtBRate";
            this.txtBRate.ReadOnly = true;
            this.txtBRate.Size = new System.Drawing.Size(100, 35);
            this.txtBRate.TabIndex = 9;
            // 
            // lblBSearch
            // 
            this.lblBSearch.AutoSize = true;
            this.lblBSearch.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBSearch.Location = new System.Drawing.Point(51, 316);
            this.lblBSearch.Name = "lblBSearch";
            this.lblBSearch.Size = new System.Drawing.Size(382, 24);
            this.lblBSearch.TabIndex = 17;
            this.lblBSearch.Text = "Search (Name or Facility Code):";
            // 
            // lblBRate
            // 
            this.lblBRate.AutoSize = true;
            this.lblBRate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBRate.Location = new System.Drawing.Point(418, 30);
            this.lblBRate.Name = "lblBRate";
            this.lblBRate.Size = new System.Drawing.Size(130, 24);
            this.lblBRate.TabIndex = 8;
            this.lblBRate.Text = "Rate/hour:";
            // 
            // nudBHours
            // 
            this.nudBHours.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudBHours.Location = new System.Drawing.Point(259, 148);
            this.nudBHours.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBHours.Name = "nudBHours";
            this.nudBHours.Size = new System.Drawing.Size(120, 35);
            this.nudBHours.TabIndex = 7;
            this.nudBHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBHours
            // 
            this.lblBHours.AutoSize = true;
            this.lblBHours.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBHours.Location = new System.Drawing.Point(24, 150);
            this.lblBHours.Name = "lblBHours";
            this.lblBHours.Size = new System.Drawing.Size(82, 24);
            this.lblBHours.TabIndex = 6;
            this.lblBHours.Text = "Hours:";
            // 
            // dtpBStart
            // 
            this.dtpBStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpBStart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBStart.Location = new System.Drawing.Point(159, 102);
            this.dtpBStart.Name = "dtpBStart";
            this.dtpBStart.Size = new System.Drawing.Size(220, 35);
            this.dtpBStart.TabIndex = 5;
            // 
            // lblBStart
            // 
            this.lblBStart.AutoSize = true;
            this.lblBStart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBStart.Location = new System.Drawing.Point(24, 109);
            this.lblBStart.Name = "lblBStart";
            this.lblBStart.Size = new System.Drawing.Size(82, 24);
            this.lblBStart.TabIndex = 4;
            this.lblBStart.Text = "Start:";
            // 
            // cboBFacility
            // 
            this.cboBFacility.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBFacility.FormattingEnabled = true;
            this.cboBFacility.Location = new System.Drawing.Point(160, 65);
            this.cboBFacility.Name = "cboBFacility";
            this.cboBFacility.Size = new System.Drawing.Size(219, 32);
            this.cboBFacility.TabIndex = 3;
            this.cboBFacility.Text = "DropDownList";
            // 
            // lblBFacility
            // 
            this.lblBFacility.AutoSize = true;
            this.lblBFacility.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBFacility.Location = new System.Drawing.Point(24, 68);
            this.lblBFacility.Name = "lblBFacility";
            this.lblBFacility.Size = new System.Drawing.Size(118, 24);
            this.lblBFacility.TabIndex = 2;
            this.lblBFacility.Text = "Facility:";
            // 
            // cboBStudent
            // 
            this.cboBStudent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBStudent.FormattingEnabled = true;
            this.cboBStudent.Location = new System.Drawing.Point(159, 27);
            this.cboBStudent.Name = "cboBStudent";
            this.cboBStudent.Size = new System.Drawing.Size(220, 32);
            this.cboBStudent.TabIndex = 1;
            this.cboBStudent.Text = "DropDownList";
            // 
            // gbBooking
            // 
            this.gbBooking.Controls.Add(this.btnBAccept);
            this.gbBooking.Controls.Add(this.btnBCalc);
            this.gbBooking.Controls.Add(this.txtBTotal);
            this.gbBooking.Controls.Add(this.lblBTotal);
            this.gbBooking.Controls.Add(this.txtBRate);
            this.gbBooking.Controls.Add(this.lblBRate);
            this.gbBooking.Controls.Add(this.nudBHours);
            this.gbBooking.Controls.Add(this.lblBHours);
            this.gbBooking.Controls.Add(this.dtpBStart);
            this.gbBooking.Controls.Add(this.lblBStart);
            this.gbBooking.Controls.Add(this.cboBFacility);
            this.gbBooking.Controls.Add(this.lblBFacility);
            this.gbBooking.Controls.Add(this.cboBStudent);
            this.gbBooking.Controls.Add(this.lblBStudent);
            this.gbBooking.Location = new System.Drawing.Point(54, 12);
            this.gbBooking.Name = "gbBooking";
            this.gbBooking.Size = new System.Drawing.Size(719, 292);
            this.gbBooking.TabIndex = 16;
            this.gbBooking.TabStop = false;
            this.gbBooking.Text = "Booking";
            // 
            // lblBStudent
            // 
            this.lblBStudent.AutoSize = true;
            this.lblBStudent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBStudent.Location = new System.Drawing.Point(24, 30);
            this.lblBStudent.Name = "lblBStudent";
            this.lblBStudent.Size = new System.Drawing.Size(106, 24);
            this.lblBStudent.TabIndex = 0;
            this.lblBStudent.Text = "Student:";
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 600);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.btnBSearch);
            this.Controls.Add(this.txtBSearch);
            this.Controls.Add(this.lblBSearch);
            this.Controls.Add(this.gbBooking);
            this.Name = "BookingsForm";
            this.Text = "BookingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBHours)).EndInit();
            this.gbBooking.ResumeLayout(false);
            this.gbBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnBSearch;
        private System.Windows.Forms.TextBox txtBSearch;
        private System.Windows.Forms.Button btnBAccept;
        private System.Windows.Forms.Button btnBCalc;
        private System.Windows.Forms.TextBox txtBTotal;
        private System.Windows.Forms.Label lblBTotal;
        private System.Windows.Forms.TextBox txtBRate;
        private System.Windows.Forms.Label lblBSearch;
        private System.Windows.Forms.Label lblBRate;
        private System.Windows.Forms.NumericUpDown nudBHours;
        private System.Windows.Forms.Label lblBHours;
        private System.Windows.Forms.DateTimePicker dtpBStart;
        private System.Windows.Forms.Label lblBStart;
        private System.Windows.Forms.ComboBox cboBFacility;
        private System.Windows.Forms.Label lblBFacility;
        private System.Windows.Forms.ComboBox cboBStudent;
        private System.Windows.Forms.GroupBox gbBooking;
        private System.Windows.Forms.Label lblBStudent;
    }
}