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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.btnPreviewReceipt = new System.Windows.Forms.Button();
            this.btnAcceptPayment = new System.Windows.Forms.Button();
            this.cboPMethod = new System.Windows.Forms.ComboBox();
            this.lblPMethod = new System.Windows.Forms.Label();
            this.txtPAmount = new System.Windows.Forms.TextBox();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.txtPTotal = new System.Windows.Forms.TextBox();
            this.lblPTotal = new System.Windows.Forms.Label();
            this.txtPBookingID = new System.Windows.Forms.TextBox();
            this.lblPBookingId = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceipts
            // 
            this.dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipts.Location = new System.Drawing.Point(568, 366);
            this.dgvReceipts.MultiSelect = false;
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.RowHeadersWidth = 62;
            this.dgvReceipts.RowTemplate.Height = 30;
            this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipts.Size = new System.Drawing.Size(679, 321);
            this.dgvReceipts.TabIndex = 37;
            // 
            // btnPreviewReceipt
            // 
            this.btnPreviewReceipt.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewReceipt.Location = new System.Drawing.Point(312, 511);
            this.btnPreviewReceipt.Name = "btnPreviewReceipt";
            this.btnPreviewReceipt.Size = new System.Drawing.Size(230, 115);
            this.btnPreviewReceipt.TabIndex = 36;
            this.btnPreviewReceipt.Text = "Receipt Preview";
            this.btnPreviewReceipt.UseVisualStyleBackColor = true;
            // 
            // btnAcceptPayment
            // 
            this.btnAcceptPayment.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptPayment.Location = new System.Drawing.Point(58, 511);
            this.btnAcceptPayment.Name = "btnAcceptPayment";
            this.btnAcceptPayment.Size = new System.Drawing.Size(230, 115);
            this.btnAcceptPayment.TabIndex = 35;
            this.btnAcceptPayment.Text = "Accept Payment";
            this.btnAcceptPayment.UseVisualStyleBackColor = true;
            // 
            // cboPMethod
            // 
            this.cboPMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPMethod.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPMethod.FormattingEnabled = true;
            this.cboPMethod.Location = new System.Drawing.Point(382, 274);
            this.cboPMethod.Name = "cboPMethod";
            this.cboPMethod.Size = new System.Drawing.Size(160, 59);
            this.cboPMethod.TabIndex = 34;
            // 
            // lblPMethod
            // 
            this.lblPMethod.AutoSize = true;
            this.lblPMethod.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMethod.Location = new System.Drawing.Point(62, 282);
            this.lblPMethod.Name = "lblPMethod";
            this.lblPMethod.Size = new System.Drawing.Size(167, 51);
            this.lblPMethod.TabIndex = 33;
            this.lblPMethod.Text = "Method:";
            // 
            // txtPAmount
            // 
            this.txtPAmount.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAmount.Location = new System.Drawing.Point(382, 195);
            this.txtPAmount.Name = "txtPAmount";
            this.txtPAmount.Size = new System.Drawing.Size(160, 58);
            this.txtPAmount.TabIndex = 32;
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAmount.Location = new System.Drawing.Point(59, 202);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(172, 51);
            this.lblPAmount.TabIndex = 31;
            this.lblPAmount.Text = "Amount:";
            // 
            // txtPTotal
            // 
            this.txtPTotal.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTotal.Location = new System.Drawing.Point(382, 117);
            this.txtPTotal.Name = "txtPTotal";
            this.txtPTotal.ReadOnly = true;
            this.txtPTotal.Size = new System.Drawing.Size(160, 58);
            this.txtPTotal.TabIndex = 30;
            // 
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotal.Location = new System.Drawing.Point(62, 124);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(122, 51);
            this.lblPTotal.TabIndex = 29;
            this.lblPTotal.Text = "Total:";
            // 
            // txtPBookingID
            // 
            this.txtPBookingID.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPBookingID.Location = new System.Drawing.Point(382, 39);
            this.txtPBookingID.Name = "txtPBookingID";
            this.txtPBookingID.ReadOnly = true;
            this.txtPBookingID.Size = new System.Drawing.Size(160, 58);
            this.txtPBookingID.TabIndex = 28;
            // 
            // lblPBookingId
            // 
            this.lblPBookingId.AutoSize = true;
            this.lblPBookingId.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPBookingId.Location = new System.Drawing.Point(62, 42);
            this.lblPBookingId.Name = "lblPBookingId";
            this.lblPBookingId.Size = new System.Drawing.Size(226, 51);
            this.lblPBookingId.TabIndex = 27;
            this.lblPBookingId.Text = "BookingID:";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.Location = new System.Drawing.Point(568, 12);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 62;
            this.dgvBookings.RowTemplate.Height = 30;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(679, 321);
            this.dgvBookings.TabIndex = 38;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 699);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.btnPreviewReceipt);
            this.Controls.Add(this.btnAcceptPayment);
            this.Controls.Add(this.cboPMethod);
            this.Controls.Add(this.lblPMethod);
            this.Controls.Add(this.txtPAmount);
            this.Controls.Add(this.lblPAmount);
            this.Controls.Add(this.txtPTotal);
            this.Controls.Add(this.lblPTotal);
            this.Controls.Add(this.txtPBookingID);
            this.Controls.Add(this.lblPBookingId);
            this.Name = "PaymentsForm";
            this.Text = "PaymentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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