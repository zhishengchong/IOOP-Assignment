namespace ARFMS_Reception
{
    partial class PaymentsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvReceipts = new DataGridView();
            btnPreviewReceipt = new Button();
            btnAcceptPayment = new Button();
            cboPMethod = new ComboBox();
            lblPMethod = new Label();
            txtPAmount = new TextBox();
            lblPAmount = new Label();
            txtPTotal = new TextBox();
            lblPTotal = new Label();
            txtPBookingID = new TextBox();
            lblPBookingId = new Label();
            dgvBookings = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // dgvReceipts
            // 
            dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReceipts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvReceipts.Location = new Point(442, 305);
            dgvReceipts.Margin = new Padding(2, 2, 2, 2);
            dgvReceipts.MultiSelect = false;
            dgvReceipts.Name = "dgvReceipts";
            dgvReceipts.ReadOnly = true;
            dgvReceipts.RowHeadersWidth = 62;
            dgvReceipts.RowTemplate.Height = 30;
            dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceipts.Size = new Size(528, 268);
            dgvReceipts.TabIndex = 37;
            // 
            // btnPreviewReceipt
            // 
            btnPreviewReceipt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreviewReceipt.Location = new Point(243, 426);
            btnPreviewReceipt.Margin = new Padding(2, 2, 2, 2);
            btnPreviewReceipt.Name = "btnPreviewReceipt";
            btnPreviewReceipt.Size = new Size(179, 96);
            btnPreviewReceipt.TabIndex = 36;
            btnPreviewReceipt.Text = "Receipt Preview";
            btnPreviewReceipt.UseVisualStyleBackColor = true;
            // 
            // btnAcceptPayment
            // 
            btnAcceptPayment.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceptPayment.Location = new Point(45, 426);
            btnAcceptPayment.Margin = new Padding(2, 2, 2, 2);
            btnAcceptPayment.Name = "btnAcceptPayment";
            btnAcceptPayment.Size = new Size(179, 96);
            btnAcceptPayment.TabIndex = 35;
            btnAcceptPayment.Text = "Accept Payment";
            btnAcceptPayment.UseVisualStyleBackColor = true;
            // 
            // cboPMethod
            // 
            cboPMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPMethod.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPMethod.FormattingEnabled = true;
            cboPMethod.Location = new Point(297, 228);
            cboPMethod.Margin = new Padding(2, 2, 2, 2);
            cboPMethod.Name = "cboPMethod";
            cboPMethod.Size = new Size(125, 41);
            cboPMethod.TabIndex = 34;
            // 
            // lblPMethod
            // 
            lblPMethod.AutoSize = true;
            lblPMethod.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPMethod.Location = new Point(48, 235);
            lblPMethod.Margin = new Padding(2, 0, 2, 0);
            lblPMethod.Name = "lblPMethod";
            lblPMethod.Size = new Size(116, 34);
            lblPMethod.TabIndex = 33;
            lblPMethod.Text = "Method:";
            // 
            // txtPAmount
            // 
            txtPAmount.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPAmount.Location = new Point(297, 162);
            txtPAmount.Margin = new Padding(2, 2, 2, 2);
            txtPAmount.Name = "txtPAmount";
            txtPAmount.Size = new Size(125, 41);
            txtPAmount.TabIndex = 32;
            // 
            // lblPAmount
            // 
            lblPAmount.AutoSize = true;
            lblPAmount.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPAmount.Location = new Point(46, 168);
            lblPAmount.Margin = new Padding(2, 0, 2, 0);
            lblPAmount.Name = "lblPAmount";
            lblPAmount.Size = new Size(120, 34);
            lblPAmount.TabIndex = 31;
            lblPAmount.Text = "Amount:";
            // 
            // txtPTotal
            // 
            txtPTotal.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPTotal.Location = new Point(297, 98);
            txtPTotal.Margin = new Padding(2, 2, 2, 2);
            txtPTotal.Name = "txtPTotal";
            txtPTotal.ReadOnly = true;
            txtPTotal.Size = new Size(125, 41);
            txtPTotal.TabIndex = 30;
            // 
            // lblPTotal
            // 
            lblPTotal.AutoSize = true;
            lblPTotal.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPTotal.Location = new Point(48, 103);
            lblPTotal.Margin = new Padding(2, 0, 2, 0);
            lblPTotal.Name = "lblPTotal";
            lblPTotal.Size = new Size(83, 34);
            lblPTotal.TabIndex = 29;
            lblPTotal.Text = "Total:";
            // 
            // txtPBookingID
            // 
            txtPBookingID.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPBookingID.Location = new Point(297, 32);
            txtPBookingID.Margin = new Padding(2, 2, 2, 2);
            txtPBookingID.Name = "txtPBookingID";
            txtPBookingID.ReadOnly = true;
            txtPBookingID.Size = new Size(125, 41);
            txtPBookingID.TabIndex = 28;
            // 
            // lblPBookingId
            // 
            lblPBookingId.AutoSize = true;
            lblPBookingId.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPBookingId.Location = new Point(48, 35);
            lblPBookingId.Margin = new Padding(2, 0, 2, 0);
            lblPBookingId.Name = "lblPBookingId";
            lblPBookingId.Size = new Size(154, 34);
            lblPBookingId.TabIndex = 27;
            lblPBookingId.Text = "BookingID:";
            // 
            // dgvBookings
            // 
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.Location = new Point(442, 10);
            dgvBookings.Margin = new Padding(2, 2, 2, 2);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 62;
            dgvBookings.RowTemplate.Height = 30;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(528, 268);
            dgvBookings.TabIndex = 38;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 582);
            Controls.Add(dgvBookings);
            Controls.Add(dgvReceipts);
            Controls.Add(btnPreviewReceipt);
            Controls.Add(btnAcceptPayment);
            Controls.Add(cboPMethod);
            Controls.Add(lblPMethod);
            Controls.Add(txtPAmount);
            Controls.Add(lblPAmount);
            Controls.Add(txtPTotal);
            Controls.Add(lblPTotal);
            Controls.Add(txtPBookingID);
            Controls.Add(lblPBookingId);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PaymentsForm";
            Text = "PaymentsForm";
            Load += PaymentsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceipts;
        private System.Windows.Forms.Button btnPreviewReceipt;
        private System.Windows.Forms.Button btnAcceptPayment;
        private System.Windows.Forms.ComboBox cboPMethod;
        private System.Windows.Forms.Label lblPMethod;
        private System.Windows.Forms.TextBox txtPAmount;
        private System.Windows.Forms.Label lblPAmount;
        private System.Windows.Forms.TextBox txtPTotal;
        private System.Windows.Forms.Label lblPTotal;
        private System.Windows.Forms.TextBox txtPBookingID;
        private System.Windows.Forms.Label lblPBookingId;
        private System.Windows.Forms.DataGridView dgvBookings;
    }
}