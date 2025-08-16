namespace Manager
{
    partial class UserManagement
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
            this.addUsers = new System.Windows.Forms.Button();
            this.delUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // addUsers
            // 
            this.addUsers.Location = new System.Drawing.Point(270, 194);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(269, 23);
            this.addUsers.TabIndex = 1;
            this.addUsers.Text = "Add Users";
            this.addUsers.UseVisualStyleBackColor = true;
            this.addUsers.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // delUsers
            // 
            this.delUsers.Location = new System.Drawing.Point(270, 276);
            this.delUsers.Name = "delUsers";
            this.delUsers.Size = new System.Drawing.Size(269, 23);
            this.delUsers.TabIndex = 2;
            this.delUsers.Text = "Delete Users";
            this.delUsers.UseVisualStyleBackColor = true;
            this.delUsers.Click += new System.EventHandler(this.delUsers_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delUsers);
            this.Controls.Add(this.addUsers);
            this.Controls.Add(this.label1);
            this.Name = "UserManagement";
            this.Text = "User Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUsers;
        private System.Windows.Forms.Button delUsers;
    }
}