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
            label1 = new Label();
            manUsers = new Button();
            manFac = new Button();
            signMaint = new Button();
            viewReq = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 36);
            label1.TabIndex = 0;
            label1.Text = "Manager Homepage";
            // 
            // manUsers
            // 
            manUsers.Location = new Point(294, 107);
            manUsers.Margin = new Padding(4, 3, 4, 3);
            manUsers.Name = "manUsers";
            manUsers.Size = new Size(343, 27);
            manUsers.TabIndex = 1;
            manUsers.Text = "Manage Users";
            manUsers.UseVisualStyleBackColor = true;
            manUsers.Click += manUsers_Click;
            // 
            // manFac
            // 
            manFac.Location = new Point(294, 190);
            manFac.Margin = new Padding(4, 3, 4, 3);
            manFac.Name = "manFac";
            manFac.Size = new Size(343, 27);
            manFac.TabIndex = 2;
            manFac.Text = "Manage Facilities";
            manFac.UseVisualStyleBackColor = true;
            manFac.Click += manFac_Click;
            // 
            // signMaint
            // 
            signMaint.Location = new Point(294, 286);
            signMaint.Margin = new Padding(4, 3, 4, 3);
            signMaint.Name = "signMaint";
            signMaint.Size = new Size(343, 27);
            signMaint.TabIndex = 3;
            signMaint.Text = "Assign Maintenance";
            signMaint.UseVisualStyleBackColor = true;
            signMaint.Click += signMaint_Click;
            // 
            // viewReq
            // 
            viewReq.Location = new Point(294, 382);
            viewReq.Margin = new Padding(4, 3, 4, 3);
            viewReq.Name = "viewReq";
            viewReq.Size = new Size(343, 27);
            viewReq.TabIndex = 4;
            viewReq.Text = "View Requests";
            viewReq.UseVisualStyleBackColor = true;
            viewReq.Click += viewReq_Click;
            // 
            // ManagerHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(viewReq);
            Controls.Add(signMaint);
            Controls.Add(manFac);
            Controls.Add(manUsers);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManagerHome";
            Text = "Manager Homepage";
            Load += ManagerHome_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manUsers;
        private System.Windows.Forms.Button manFac;
        private System.Windows.Forms.Button signMaint;
        private System.Windows.Forms.Button viewReq;
    }
}

