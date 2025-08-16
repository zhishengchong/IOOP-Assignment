namespace Manager
{
    partial class RequestsMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radR = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.btnStat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(721, 293);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Staff";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Request";
            this.columnHeader2.Width = 525;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date/Time";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radR);
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Location = new System.Drawing.Point(62, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 43);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            // 
            // radR
            // 
            this.radR.AutoSize = true;
            this.radR.Location = new System.Drawing.Point(151, 19);
            this.radR.Name = "radR";
            this.radR.Size = new System.Drawing.Size(68, 17);
            this.radR.TabIndex = 1;
            this.radR.TabStop = true;
            this.radR.Text = "Rejected";
            this.radR.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(26, 19);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(71, 17);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.Text = "Approved";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(347, 402);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(129, 23);
            this.btnStat.TabIndex = 7;
            this.btnStat.Text = "Change Status";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // RequestsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "RequestsMenu";
            this.Text = "RequestsMenu";
            this.Load += new System.EventHandler(this.RequestsMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radR;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Button btnStat;
    }
}