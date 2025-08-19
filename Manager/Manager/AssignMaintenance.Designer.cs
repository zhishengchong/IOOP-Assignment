namespace Manager
{
    partial class AssignMaintenance
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
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.Facility = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(318, 218);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.tbxPhoneNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(208, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date/Time:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(318, 163);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(193, 20);
            this.tbxEmail.TabIndex = 13;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(318, 111);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(193, 20);
            this.tbxName.TabIndex = 12;
            // 
            // Facility
            // 
            this.Facility.AutoSize = true;
            this.Facility.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Facility.Location = new System.Drawing.Point(251, 166);
            this.Facility.Name = "Facility";
            this.Facility.Size = new System.Drawing.Size(42, 13);
            this.Facility.TabIndex = 11;
            this.Facility.Text = "Facility:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(251, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Staff:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assign Staff";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(318, 280);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(154, 23);
            this.btnAssign.TabIndex = 16;
            this.btnAssign.Text = "Assign Staff";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // AssignMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.Facility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignMaintenance";
            this.Text = "AssignMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label Facility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssign;
    }
}