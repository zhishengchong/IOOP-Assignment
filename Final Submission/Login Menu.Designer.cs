namespace Final_Submission_compile
{
    partial class Login_Menu
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtBoxEmail = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(123, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(123, 258);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password :";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(258, 183);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(280, 23);
            txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(258, 255);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(280, 23);
            txtBoxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(258, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(463, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 66);
            label1.Name = "label1";
            label1.Size = new Size(173, 59);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // lblError
            lblError = new Label();
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(258, 300);
            lblError.Name = "lblError";
            lblError.Size = new Size(300, 15);
            lblError.Text = "";
            Controls.Add(lblError);
            // 
            // Login_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "Login_Menu";
            Text = "Login_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label label1;
        private Label lblError;
    }
}