
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
            TxtBoxFacilityCode = new TextBox();
            TxtBoxFacilityName = new TextBox();
            RichTxtBoxProblemDescription = new RichTextBox();
            ComboBoxRequestType = new ComboBox();
            DateTimePickerDateReported = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblFacilityCode = new Label();
            lblFacilityName = new Label();
            lblProblemDescription = new Label();
            lblRequestType = new Label();
            lblDateReported = new Label();
            SuspendLayout();
            // 
            // TxtBoxFacilityCode
            // 
            TxtBoxFacilityCode.Location = new Point(192, 37);
            TxtBoxFacilityCode.Name = "TxtBoxFacilityCode";
            TxtBoxFacilityCode.Size = new Size(100, 23);
            TxtBoxFacilityCode.TabIndex = 0;
            TxtBoxFacilityCode.TextChanged += TxtBoxFacilityCode_TextChanged;
            // 
            // TxtBoxFacilityName
            // 
            TxtBoxFacilityName.Location = new Point(192, 90);
            TxtBoxFacilityName.Name = "TxtBoxFacilityName";
            TxtBoxFacilityName.Size = new Size(100, 23);
            TxtBoxFacilityName.TabIndex = 1;
            // 
            // RichTxtBoxProblemDescription
            // 
            RichTxtBoxProblemDescription.Location = new Point(192, 147);
            RichTxtBoxProblemDescription.Name = "RichTxtBoxProblemDescription";
            RichTxtBoxProblemDescription.Size = new Size(100, 96);
            RichTxtBoxProblemDescription.TabIndex = 2;
            RichTxtBoxProblemDescription.Text = "";
            // 
            // ComboBoxRequestType
            // 
            ComboBoxRequestType.FormattingEnabled = true;
            ComboBoxRequestType.Location = new Point(192, 279);
            ComboBoxRequestType.Name = "ComboBoxRequestType";
            ComboBoxRequestType.Size = new Size(121, 23);
            ComboBoxRequestType.TabIndex = 3;
            // 
            // DateTimePickerDateReported
            // 
            DateTimePickerDateReported.Location = new Point(192, 334);
            DateTimePickerDateReported.Name = "DateTimePickerDateReported";
            DateTimePickerDateReported.Size = new Size(200, 23);
            DateTimePickerDateReported.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(267, 390);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Request";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(415, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblFacilityCode
            // 
            lblFacilityCode.AutoSize = true;
            lblFacilityCode.Location = new Point(43, 40);
            lblFacilityCode.Name = "lblFacilityCode";
            lblFacilityCode.Size = new Size(81, 15);
            lblFacilityCode.TabIndex = 7;
            lblFacilityCode.Text = "Facility Code :";
            // 
            // lblFacilityName
            // 
            lblFacilityName.AutoSize = true;
            lblFacilityName.Location = new Point(43, 90);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new Size(85, 15);
            lblFacilityName.TabIndex = 8;
            lblFacilityName.Text = "Facility Name :";
            // 
            // lblProblemDescription
            // 
            lblProblemDescription.AutoSize = true;
            lblProblemDescription.Location = new Point(43, 150);
            lblProblemDescription.Name = "lblProblemDescription";
            lblProblemDescription.Size = new Size(121, 15);
            lblProblemDescription.TabIndex = 9;
            lblProblemDescription.Text = "Problem Description :";
            // 
            // lblRequestType
            // 
            lblRequestType.AutoSize = true;
            lblRequestType.Location = new Point(43, 282);
            lblRequestType.Name = "lblRequestType";
            lblRequestType.Size = new Size(83, 15);
            lblRequestType.TabIndex = 10;
            lblRequestType.Text = "Request Type :";
            // 
            // lblDateReported
            // 
            lblDateReported.AutoSize = true;
            lblDateReported.Location = new Point(43, 340);
            lblDateReported.Name = "lblDateReported";
            lblDateReported.Size = new Size(88, 15);
            lblDateReported.TabIndex = 11;
            lblDateReported.Text = "Date Reported :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDateReported);
            Controls.Add(lblRequestType);
            Controls.Add(lblProblemDescription);
            Controls.Add(lblFacilityName);
            Controls.Add(lblFacilityCode);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(DateTimePickerDateReported);
            Controls.Add(ComboBoxRequestType);
            Controls.Add(RichTxtBoxProblemDescription);
            Controls.Add(TxtBoxFacilityName);
            Controls.Add(TxtBoxFacilityCode);
            Name = "Replacement_Request";
            Text = "Replacement Request";
            Load += Replacement_Request_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtBoxFacilityCode_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox TxtBoxFacilityCode;
        private TextBox TxtBoxFacilityName;
        private RichTextBox RichTxtBoxProblemDescription;
        private ComboBox ComboBoxRequestType;
        private DateTimePicker DateTimePickerDateReported;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblFacilityCode;
        private Label lblFacilityName;
        private Label lblProblemDescription;
        private Label lblRequestType;
        private Label lblDateReported;
    }
}
