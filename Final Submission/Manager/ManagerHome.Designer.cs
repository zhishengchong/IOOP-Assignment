namespace Manager
{
    partial class ManagerHome
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
            this.manUsers = new System.Windows.Forms.Button();
            this.manFac = new System.Windows.Forms.Button();
            this.signMaint = new System.Windows.Forms.Button();
            this.viewReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Homepage";
            // 
            // manUsers
            // 
            this.manUsers.Location = new System.Drawing.Point(252, 93);
            this.manUsers.Name = "manUsers";
            this.manUsers.Size = new System.Drawing.Size(294, 23);
            this.manUsers.TabIndex = 1;
            this.manUsers.Text = "Manage Users";
            this.manUsers.UseVisualStyleBackColor = true;
            this.manUsers.Click += new System.EventHandler(this.manUsers_Click);
            // 
            // manFac
            // 
            this.manFac.Location = new System.Drawing.Point(252, 165);
            this.manFac.Name = "manFac";
            this.manFac.Size = new System.Drawing.Size(294, 23);
            this.manFac.TabIndex = 2;
            this.manFac.Text = "Manage Facilities";
            this.manFac.UseVisualStyleBackColor = true;
            this.manFac.Click += new System.EventHandler(this.manFac_Click);
            // 
            // signMaint
            // 
            this.signMaint.Location = new System.Drawing.Point(252, 248);
            this.signMaint.Name = "signMaint";
            this.signMaint.Size = new System.Drawing.Size(294, 23);
            this.signMaint.TabIndex = 3;
            this.signMaint.Text = "Assign Maintenance";
            this.signMaint.UseVisualStyleBackColor = true;
            this.signMaint.Click += new System.EventHandler(this.signMaint_Click);
            // 
            // viewReq
            // 
            this.viewReq.Location = new System.Drawing.Point(252, 331);
            this.viewReq.Name = "viewReq";
            this.viewReq.Size = new System.Drawing.Size(294, 23);
            this.viewReq.TabIndex = 4;
            this.viewReq.Text = "View Requests";
            this.viewReq.UseVisualStyleBackColor = true;
            this.viewReq.Click += new System.EventHandler(this.viewReq_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewReq);
            this.Controls.Add(this.signMaint);
            this.Controls.Add(this.manFac);
            this.Controls.Add(this.manUsers);
            this.Controls.Add(this.label1);
            this.Name = "ManagerHome";
            this.Text = "Manager Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manUsers;
        private System.Windows.Forms.Button manFac;
        private System.Windows.Forms.Button signMaint;
        private System.Windows.Forms.Button viewReq;
    }
}

