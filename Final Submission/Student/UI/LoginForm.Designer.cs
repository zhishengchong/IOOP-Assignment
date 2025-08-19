namespace ARFMS.StudentApp.UI
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblTitle = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(454, 197);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(306, 193);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(408, 345);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(306, 227);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(454, 232);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(310, 46);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "ARFMS – Student Login";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(468, 313);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lblError);
            Controls.Add(lblTitle);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
    }
}