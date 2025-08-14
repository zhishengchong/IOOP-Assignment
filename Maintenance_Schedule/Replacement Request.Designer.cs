
namespace Maintenance_Schedule
{
    partial class Replacement_Request
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
            txtBoxFacilityCode = new TextBox();
            richTxtBoxProblemDescription = new RichTextBox();
            comboBoxRequestType = new ComboBox();
            dateTimePickerDateReported = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblFacilityCode = new Label();
            lblProblemDescription = new Label();
            lblRequestType = new Label();
            lblDateReported = new Label();
            DataGridView1 = new DataGridView();
            lblFacilityName = new Label();
            txtBoxFacilityName = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxFacilityCode
            // 
            txtBoxFacilityCode.Location = new Point(192, 226);
            txtBoxFacilityCode.Name = "txtBoxFacilityCode";
            txtBoxFacilityCode.Size = new Size(100, 23);
            txtBoxFacilityCode.TabIndex = 0;
            // 
            // richTxtBoxProblemDescription
            // 
            richTxtBoxProblemDescription.Location = new Point(192, 297);
            richTxtBoxProblemDescription.Name = "richTxtBoxProblemDescription";
            richTxtBoxProblemDescription.Size = new Size(596, 27);
            richTxtBoxProblemDescription.TabIndex = 2;
            richTxtBoxProblemDescription.Text = "";
            // 
            // comboBoxRequestType
            // 
            comboBoxRequestType.FormattingEnabled = true;
            comboBoxRequestType.Location = new Point(192, 339);
            comboBoxRequestType.Name = "comboBoxRequestType";
            comboBoxRequestType.Size = new Size(121, 23);
            comboBoxRequestType.TabIndex = 3;
            // 
            // dateTimePickerDateReported
            // 
            dateTimePickerDateReported.Location = new Point(192, 376);
            dateTimePickerDateReported.Name = "dateTimePickerDateReported";
            dateTimePickerDateReported.Size = new Size(200, 23);
            dateTimePickerDateReported.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(137, 415);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(564, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFacilityCode
            // 
            lblFacilityCode.AutoSize = true;
            lblFacilityCode.Location = new Point(12, 229);
            lblFacilityCode.Name = "lblFacilityCode";
            lblFacilityCode.Size = new Size(81, 15);
            lblFacilityCode.TabIndex = 7;
            lblFacilityCode.Text = "Facility Code :";
            // 
            // lblProblemDescription
            // 
            lblProblemDescription.AutoSize = true;
            lblProblemDescription.Location = new Point(12, 300);
            lblProblemDescription.Name = "lblProblemDescription";
            lblProblemDescription.Size = new Size(121, 15);
            lblProblemDescription.TabIndex = 9;
            lblProblemDescription.Text = "Problem Description :";
            // 
            // lblRequestType
            // 
            lblRequestType.AutoSize = true;
            lblRequestType.Location = new Point(12, 342);
            lblRequestType.Name = "lblRequestType";
            lblRequestType.Size = new Size(83, 15);
            lblRequestType.TabIndex = 10;
            lblRequestType.Text = "Request Type :";
            // 
            // lblDateReported
            // 
            lblDateReported.AutoSize = true;
            lblDateReported.Location = new Point(12, 382);
            lblDateReported.Name = "lblDateReported";
            lblDateReported.Size = new Size(88, 15);
            lblDateReported.TabIndex = 11;
            lblDateReported.Text = "Date Reported :";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(776, 195);
            DataGridView1.TabIndex = 12;
            // 
            // lblFacilityName
            // 
            lblFacilityName.AutoSize = true;
            lblFacilityName.Location = new Point(12, 263);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new Size(85, 15);
            lblFacilityName.TabIndex = 13;
            lblFacilityName.Text = "Facility Name :";
            // 
            // txtBoxFacilityName
            // 
            txtBoxFacilityName.Location = new Point(192, 260);
            txtBoxFacilityName.Name = "txtBoxFacilityName";
            txtBoxFacilityName.Size = new Size(100, 23);
            txtBoxFacilityName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(419, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(278, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Replacement_Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(txtBoxFacilityName);
            Controls.Add(lblFacilityName);
            Controls.Add(DataGridView1);
            Controls.Add(lblDateReported);
            Controls.Add(lblRequestType);
            Controls.Add(lblProblemDescription);
            Controls.Add(lblFacilityCode);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(dateTimePickerDateReported);
            Controls.Add(comboBoxRequestType);
            Controls.Add(richTxtBoxProblemDescription);
            Controls.Add(txtBoxFacilityCode);
            Name = "Replacement_Request";
            Text = "Replacement Request";
            Load += Replacement_Request_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtBoxFacilityCode;
        private RichTextBox richTxtBoxProblemDescription;
        private ComboBox comboBoxRequestType;
        private DateTimePicker dateTimePickerDateReported;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblFacilityCode;
        private Label lblProblemDescription;
        private Label lblRequestType;
        private Label lblDateReported;
        private DataGridView DataGridView1;
        private Label lblFacilityName;
        private TextBox txtBoxFacilityName;
        private Button btnDelete;
        private Button btnEdit;
    }
}
