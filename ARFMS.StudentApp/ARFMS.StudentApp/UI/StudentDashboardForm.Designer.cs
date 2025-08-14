namespace ARFMS.StudentApp.UI
{
    partial class StudentDashboardForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabFacilities = new System.Windows.Forms.TabPage();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dtBookingDate = new System.Windows.Forms.DateTimePicker();
            this.gridFacilities = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditDate = new System.Windows.Forms.Button();
            this.dtNewDate = new System.Windows.Forms.DateTimePicker();
            this.gridBookings = new System.Windows.Forms.DataGridView();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.cboFacilityForReview = new System.Windows.Forms.ComboBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.gridMyReviews = new System.Windows.Forms.DataGridView();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReviewFacility = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.txtProfileUniversity = new System.Windows.Forms.TextBox();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfileUniversity = new System.Windows.Forms.Label();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabFacilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacilities)).BeginInit();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).BeginInit();
            this.tabReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReviews)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabFacilities);
            this.tabMain.Controls.Add(this.tabBookings);
            this.tabMain.Controls.Add(this.tabReviews);
            this.tabMain.Controls.Add(this.tabProfile);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(884, 561);
            this.tabMain.TabIndex = 0;
            // 
            // tabFacilities
            // 
            this.tabFacilities.Controls.Add(this.btnBook);
            this.tabFacilities.Controls.Add(this.btnLoadAll);
            this.tabFacilities.Controls.Add(this.txtLocation);
            this.tabFacilities.Controls.Add(this.lblLocation);
            this.tabFacilities.Controls.Add(this.dtBookingDate);
            this.tabFacilities.Controls.Add(this.gridFacilities);
            this.tabFacilities.Controls.Add(this.btnSearch);
            this.tabFacilities.Controls.Add(this.txtType);
            this.tabFacilities.Controls.Add(this.lblType);
            this.tabFacilities.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFacilities.Location = new System.Drawing.Point(4, 22);
            this.tabFacilities.Name = "tabFacilities";
            this.tabFacilities.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacilities.Size = new System.Drawing.Size(876, 535);
            this.tabFacilities.TabIndex = 0;
            this.tabFacilities.Text = "Search / Book";
            this.tabFacilities.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(454, 477);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(80, 26);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book Selected";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(368, 477);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(80, 26);
            this.btnLoadAll.TabIndex = 7;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(363, 398);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(180, 23);
            this.txtLocation.TabIndex = 6;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(268, 401);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 16);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location:";
            // 
            // dtBookingDate
            // 
            this.dtBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBookingDate.Location = new System.Drawing.Point(338, 438);
            this.dtBookingDate.Name = "dtBookingDate";
            this.dtBookingDate.Size = new System.Drawing.Size(150, 23);
            this.dtBookingDate.TabIndex = 4;
            // 
            // gridFacilities
            // 
            this.gridFacilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacilities.Location = new System.Drawing.Point(10, 10);
            this.gridFacilities.MultiSelect = false;
            this.gridFacilities.Name = "gridFacilities";
            this.gridFacilities.ReadOnly = true;
            this.gridFacilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFacilities.Size = new System.Drawing.Size(860, 330);
            this.gridFacilities.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 477);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(363, 364);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(180, 23);
            this.txtType.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(268, 364);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.btnDeleteBooking);
            this.tabBookings.Controls.Add(this.btnEditDate);
            this.tabBookings.Controls.Add(this.dtNewDate);
            this.tabBookings.Controls.Add(this.gridBookings);
            this.tabBookings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(876, 535);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "My Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(352, 454);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // btnEditDate
            // 
            this.btnEditDate.Location = new System.Drawing.Point(352, 418);
            this.btnEditDate.Name = "btnEditDate";
            this.btnEditDate.Size = new System.Drawing.Size(120, 30);
            this.btnEditDate.TabIndex = 2;
            this.btnEditDate.Text = "Change Date";
            this.btnEditDate.UseVisualStyleBackColor = true;
            // 
            // dtNewDate
            // 
            this.dtNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNewDate.Location = new System.Drawing.Point(339, 376);
            this.dtNewDate.Name = "dtNewDate";
            this.dtNewDate.Size = new System.Drawing.Size(150, 23);
            this.dtNewDate.TabIndex = 1;
            // 
            // gridBookings
            // 
            this.gridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookings.Location = new System.Drawing.Point(12, 12);
            this.gridBookings.MultiSelect = false;
            this.gridBookings.Name = "gridBookings";
            this.gridBookings.ReadOnly = true;
            this.gridBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookings.Size = new System.Drawing.Size(860, 330);
            this.gridBookings.TabIndex = 0;
            // 
            // tabReviews
            // 
            this.tabReviews.Controls.Add(this.cboFacilityForReview);
            this.tabReviews.Controls.Add(this.numRating);
            this.tabReviews.Controls.Add(this.gridMyReviews);
            this.tabReviews.Controls.Add(this.btnSubmitReview);
            this.tabReviews.Controls.Add(this.txtComments);
            this.tabReviews.Controls.Add(this.lblRating);
            this.tabReviews.Controls.Add(this.lblReviewFacility);
            this.tabReviews.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReviews.Location = new System.Drawing.Point(4, 22);
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabReviews.Size = new System.Drawing.Size(876, 535);
            this.tabReviews.TabIndex = 2;
            this.tabReviews.Text = "Reviews";
            this.tabReviews.UseVisualStyleBackColor = true;
            // 
            // cboFacilityForReview
            // 
            this.cboFacilityForReview.FormattingEnabled = true;
            this.cboFacilityForReview.Location = new System.Drawing.Point(347, 390);
            this.cboFacilityForReview.Name = "cboFacilityForReview";
            this.cboFacilityForReview.Size = new System.Drawing.Size(180, 24);
            this.cboFacilityForReview.TabIndex = 11;
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(347, 420);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(180, 23);
            this.numRating.TabIndex = 10;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // gridMyReviews
            // 
            this.gridMyReviews.AllowUserToResizeRows = false;
            this.gridMyReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMyReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyReviews.Location = new System.Drawing.Point(10, 10);
            this.gridMyReviews.Name = "gridMyReviews";
            this.gridMyReviews.ReadOnly = true;
            this.gridMyReviews.Size = new System.Drawing.Size(860, 330);
            this.gridMyReviews.TabIndex = 9;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(361, 463);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(150, 30);
            this.btnSubmitReview.TabIndex = 8;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(668, 482);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(180, 23);
            this.txtComments.TabIndex = 7;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(258, 420);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(58, 16);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating:";
            // 
            // lblReviewFacility
            // 
            this.lblReviewFacility.AutoSize = true;
            this.lblReviewFacility.Location = new System.Drawing.Point(258, 393);
            this.lblReviewFacility.Name = "lblReviewFacility";
            this.lblReviewFacility.Size = new System.Drawing.Size(65, 16);
            this.lblReviewFacility.TabIndex = 5;
            this.lblReviewFacility.Text = "Facility:";
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.txtProfileUniversity);
            this.tabProfile.Controls.Add(this.txtProfilePhone);
            this.tabProfile.Controls.Add(this.txtProfileEmail);
            this.tabProfile.Controls.Add(this.lblProfileUniversity);
            this.tabProfile.Controls.Add(this.lblProfilePhone);
            this.tabProfile.Controls.Add(this.lblProfileEmail);
            this.tabProfile.Controls.Add(this.txtProfileName);
            this.tabProfile.Controls.Add(this.lblProfileName);
            this.tabProfile.Controls.Add(this.btnSaveProfile);
            this.tabProfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(876, 535);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // txtProfileUniversity
            // 
            this.txtProfileUniversity.Location = new System.Drawing.Point(415, 277);
            this.txtProfileUniversity.Multiline = true;
            this.txtProfileUniversity.Name = "txtProfileUniversity";
            this.txtProfileUniversity.Size = new System.Drawing.Size(200, 23);
            this.txtProfileUniversity.TabIndex = 14;
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Location = new System.Drawing.Point(415, 248);
            this.txtProfilePhone.Multiline = true;
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(200, 23);
            this.txtProfilePhone.TabIndex = 13;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(415, 219);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(200, 23);
            this.txtProfileEmail.TabIndex = 12;
            // 
            // lblProfileUniversity
            // 
            this.lblProfileUniversity.AutoSize = true;
            this.lblProfileUniversity.Location = new System.Drawing.Point(295, 280);
            this.lblProfileUniversity.Name = "lblProfileUniversity";
            this.lblProfileUniversity.Size = new System.Drawing.Size(86, 16);
            this.lblProfileUniversity.TabIndex = 11;
            this.lblProfileUniversity.Text = "University:";
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Location = new System.Drawing.Point(295, 251);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.Size = new System.Drawing.Size(57, 16);
            this.lblProfilePhone.TabIndex = 10;
            this.lblProfilePhone.Text = "Phone:";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Location = new System.Drawing.Point(295, 222);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(52, 16);
            this.lblProfileEmail.TabIndex = 9;
            this.lblProfileEmail.Text = "Email:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(415, 187);
            this.txtProfileName.Multiline = true;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(200, 23);
            this.txtProfileName.TabIndex = 8;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(295, 190);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(54, 16);
            this.lblProfileName.TabIndex = 6;
            this.lblProfileName.Text = "Name:";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(376, 333);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(120, 30);
            this.btnSaveProfile.TabIndex = 4;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabMain);
            this.Name = "StudentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARFMS - Student Dashboard";
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabFacilities.ResumeLayout(false);
            this.tabFacilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacilities)).EndInit();
            this.tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookings)).EndInit();
            this.tabReviews.ResumeLayout(false);
            this.tabReviews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReviews)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabFacilities;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabReviews;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DateTimePicker dtNewDate;
        private System.Windows.Forms.DataGridView gridBookings;
        private System.Windows.Forms.Button btnEditDate;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.DateTimePicker dtBookingDate;
        private System.Windows.Forms.DataGridView gridFacilities;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblReviewFacility;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.DataGridView gridMyReviews;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label lblProfileUniversity;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.TextBox txtProfileUniversity;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.ComboBox cboFacilityForReview;
    }
}