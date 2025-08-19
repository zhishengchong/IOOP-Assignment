
namespace Maintenance_Schedule
{
    partial class Equipment_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridView1 = new DataGridView();
            txtBoxItemName = new TextBox();
            NumericUpDownQuantity = new NumericUpDown();
            txtBoxPurpose = new TextBox();
            btnAddRequest = new Button();
            btnEditRequest = new Button();
            btnDeleteRequest = new Button();
            btnSaveRequest = new Button();
            lblItemName = new Label();
            lblQuantity = new Label();
            lblPurpose = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.BackgroundColor = Color.Silver;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(22, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(756, 228);
            DataGridView1.TabIndex = 0;
            // 
            // txtBoxItemName
            // 
            txtBoxItemName.Location = new Point(135, 259);
            txtBoxItemName.Name = "txtBoxItemName";
            txtBoxItemName.Size = new Size(100, 23);
            txtBoxItemName.TabIndex = 1;
            // 
            // NumericUpDownQuantity
            // 
            NumericUpDownQuantity.Location = new Point(135, 299);
            NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            NumericUpDownQuantity.Size = new Size(120, 23);
            NumericUpDownQuantity.TabIndex = 2;
            // 
            // txtBoxPurpose
            // 
            txtBoxPurpose.Location = new Point(135, 337);
            txtBoxPurpose.Name = "txtBoxPurpose";
            txtBoxPurpose.Size = new Size(100, 23);
            txtBoxPurpose.TabIndex = 3;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(118, 398);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(104, 23);
            btnAddRequest.TabIndex = 4;
            btnAddRequest.Text = "Add Request";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // btnEditRequest
            // 
            btnEditRequest.Location = new Point(252, 398);
            btnEditRequest.Name = "btnEditRequest";
            btnEditRequest.Size = new Size(104, 23);
            btnEditRequest.TabIndex = 5;
            btnEditRequest.Text = "Edit Request";
            btnEditRequest.UseVisualStyleBackColor = true;
            btnEditRequest.Click += btnEditRequest_Click;
            // 
            // btnDeleteRequest
            // 
            btnDeleteRequest.Location = new Point(388, 398);
            btnDeleteRequest.Name = "btnDeleteRequest";
            btnDeleteRequest.Size = new Size(104, 23);
            btnDeleteRequest.TabIndex = 6;
            btnDeleteRequest.Text = "Delete Request";
            btnDeleteRequest.UseVisualStyleBackColor = true;
            btnDeleteRequest.Click += btnDeleteRequest_Click;
            // 
            // btnSaveRequest
            // 
            btnSaveRequest.Location = new Point(528, 398);
            btnSaveRequest.Name = "btnSaveRequest";
            btnSaveRequest.Size = new Size(104, 23);
            btnSaveRequest.TabIndex = 7;
            btnSaveRequest.Text = "Save Request";
            btnSaveRequest.UseVisualStyleBackColor = true;
            btnSaveRequest.Click += btnSaveRequest_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(22, 262);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(72, 15);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "Item Name :";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 301);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(59, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity :";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(22, 340);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(92, 15);
            lblPurpose.TabIndex = 10;
            lblPurpose.Text = "Purpose/Notes :";
            // 
            // Equipment_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPurpose);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Controls.Add(btnSaveRequest);
            Controls.Add(btnDeleteRequest);
            Controls.Add(btnEditRequest);
            Controls.Add(btnAddRequest);
            Controls.Add(txtBoxPurpose);
            Controls.Add(NumericUpDownQuantity);
            Controls.Add(txtBoxItemName);
            Controls.Add(DataGridView1);
            Name = "Equipment_Form";
            Text = "Equipment Form";
            Load += Equipment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView1;
        private TextBox txtBoxItemName;
        private NumericUpDown NumericUpDownQuantity;
        private TextBox txtBoxPurpose;
        private Button btnAddRequest;
        private Button btnEditRequest;
        private Button btnDeleteRequest;
        private Button btnSaveRequest;
        private Label lblItemName;
        private Label lblQuantity;
        private Label lblPurpose;
    }
}
