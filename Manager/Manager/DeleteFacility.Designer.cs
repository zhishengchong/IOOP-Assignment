namespace Manager
{
    partial class DeleteFacility
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
            this.tbxFac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelFac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Facility";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxFac
            // 
            this.tbxFac.Location = new System.Drawing.Point(365, 135);
            this.tbxFac.Name = "tbxFac";
            this.tbxFac.Size = new System.Drawing.Size(100, 20);
            this.tbxFac.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facility";
            // 
            // btnDelFac
            // 
            this.btnDelFac.Location = new System.Drawing.Point(300, 211);
            this.btnDelFac.Name = "btnDelFac";
            this.btnDelFac.Size = new System.Drawing.Size(175, 23);
            this.btnDelFac.TabIndex = 5;
            this.btnDelFac.Text = "Delete Facility";
            this.btnDelFac.UseVisualStyleBackColor = true;
            this.btnDelFac.Click += new System.EventHandler(this.btnDelFac_Click);
            // 
            // DeleteFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelFac);
            this.Controls.Add(this.tbxFac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteFacility";
            this.Text = "DeleteFacility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelFac;
    }
}