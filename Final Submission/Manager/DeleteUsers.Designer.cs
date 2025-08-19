namespace Manager
{
    partial class DeleteUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRecpt = new System.Windows.Forms.RadioButton();
            this.radMaint = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(356, 163);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(343, 291);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(75, 23);
            this.btnDelUser.TabIndex = 3;
            this.btnDelUser.Text = "Delete User";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRecpt);
            this.groupBox1.Controls.Add(this.radMaint);
            this.groupBox1.Location = new System.Drawing.Point(268, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 43);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role:";
            // 
            // radRecpt
            // 
            this.radRecpt.AutoSize = true;
            this.radRecpt.Location = new System.Drawing.Point(151, 19);
            this.radRecpt.Name = "radRecpt";
            this.radRecpt.Size = new System.Drawing.Size(84, 17);
            this.radRecpt.TabIndex = 1;
            this.radRecpt.TabStop = true;
            this.radRecpt.Text = "Receptionist";
            this.radRecpt.UseVisualStyleBackColor = true;
            // 
            // radMaint
            // 
            this.radMaint.AutoSize = true;
            this.radMaint.Location = new System.Drawing.Point(26, 19);
            this.radMaint.Name = "radMaint";
            this.radMaint.Size = new System.Drawing.Size(87, 17);
            this.radMaint.TabIndex = 0;
            this.radMaint.TabStop = true;
            this.radMaint.Text = "Maintenance";
            this.radMaint.UseVisualStyleBackColor = true;
            // 
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUsers";
            this.Text = "DeleteUsers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRecpt;
        private System.Windows.Forms.RadioButton radMaint;
    }
}