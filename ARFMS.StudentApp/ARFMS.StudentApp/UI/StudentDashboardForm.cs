using System;
using System.Linq;
using System.Windows.Forms;
using ARFMS.StudentApp.Data;
using ARFMS.StudentApp.Models;
using System.ComponentModel; // for LicenseManager

namespace ARFMS.StudentApp.UI
{
    public partial class StudentDashboardForm : Form
    {
        private Student _current;
        private readonly FacilityRepository _facilities = new FacilityRepository();
        private readonly BookingRepository _bookings = new BookingRepository();
        private readonly ReviewRepository _reviews = new ReviewRepository();
        private readonly StudentRepository _students = new StudentRepository();

        // Parameterless ctor for Designer
        public StudentDashboardForm()
        {
            InitializeComponent();
            this.Load += StudentDashboardForm_Load;
            _current = new Student();
        }

        // Real ctor used at runtime
        public StudentDashboardForm(Student current) : this()
        {
            _current = current ?? new Student();
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            this.Text = $"ARFMS - Student | Welcome, {_current?.Name}";

            // Facilities
            btnSearch.Click += (_, __) => LoadFacilities(txtType.Text.Trim(), txtLocation.Text.Trim());
            btnLoadAll.Click += (_, __) => { txtType.Clear(); txtLocation.Clear(); LoadFacilities(null, null); };
            btnBook.Click += BtnBook_Click;
            LoadFacilities(null, null);

            // Bookings
            btnEditDate.Click += BtnEditDate_Click;
            btnDeleteBooking.Click += BtnDeleteBooking_Click;
            RefreshBookings();

            // Reviews
            btnSubmitReview.Click += BtnSubmitReview_Click;
            btnDeleteReview.Click += BtnDeleteReview_Click; // NEW
            lblAddComments.Click += LblAddComments_Click;   // NEW
            LoadFacilitiesIntoCombo();

            // Profile
            btnSaveProfile.Click += BtnSaveProfile_Click;
            txtProfileName.Text = _current?.Name ?? "";
            txtProfileEmail.Text = _current?.Email ?? "";
            txtProfilePhone.Text = _current?.Phone ?? "";
            txtProfileUniversity.Text = _current?.University ?? "";
        }

        // ---------- Facilities ----------
        private void LoadFacilities(string type, string location)
        {
            try
            {
                var list = _facilities.Search(string.IsNullOrWhiteSpace(type) ? null : type,
                                              string.IsNullOrWhiteSpace(location) ? null : location);

                gridFacilities.DataSource = list.Select(f => new
                {
                    f.FacilityID,
                    f.Name,
                    f.Type,
                    f.Location,
                    Rate = f.Rate,
                    Available = f.IsAvailable
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load facilities: " + ex.Message);
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (gridFacilities.CurrentRow == null)
            {
                MessageBox.Show("Please select a facility to book.");
                return;
            }

            int facilityId = Convert.ToInt32(gridFacilities.CurrentRow.Cells["FacilityID"].Value);
            DateTime date = dtBookingDate.Value.Date;

            try
            {
                _bookings.Add(_current.StudentID, facilityId, date);
                MessageBox.Show("Booking created with status 'Pending'. Payment and receipt handled by reception.");
                RefreshBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking failed: " + ex.Message);
            }
        }

        // ---------- Bookings ----------
        private void RefreshBookings()
        {
            try
            {
                var list = _bookings.GetByStudent(_current.StudentID);
                gridBookings.DataSource = list.Select(b => new
                {
                    b.BookingID,
                    b.FacilityName,
                    BookingDate = b.BookingDate.ToString("yyyy-MM-dd"),
                    b.Status,
                    CreatedAt = b.CreatedAt.ToString("yyyy-MM-dd HH:mm")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load bookings: " + ex.Message);
            }
        }

        private void BtnEditDate_Click(object sender, EventArgs e)
        {
            if (gridBookings.CurrentRow == null)
            {
                MessageBox.Show("Select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(gridBookings.CurrentRow.Cells["BookingID"].Value);
            DateTime newDate = dtNewDate.Value.Date;

            try
            {
                _bookings.UpdateDate(bookingId, newDate);
                MessageBox.Show("Booking date updated.");
                RefreshBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void BtnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (gridBookings.CurrentRow == null)
            {
                MessageBox.Show("Select a booking first.");
                return;
            }

            int bookingId = Convert.ToInt32(gridBookings.CurrentRow.Cells["BookingID"].Value);

            if (MessageBox.Show("Delete this booking? (Only 'Pending' allowed)", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                _bookings.Delete(bookingId);
                MessageBox.Show("Booking deleted.");
                RefreshBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        // ---------- Reviews ----------
        private void LoadFacilitiesIntoCombo()
        {
            try
            {
                var list = _facilities.GetAll();
                cboFacilityForReview.DisplayMember = "Name";
                cboFacilityForReview.ValueMember = "FacilityID";
                cboFacilityForReview.DataSource = list;
                RefreshMyReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load facilities for review: " + ex.Message);
            }
        }

        private void RefreshMyReviews()
        {
            try
            {
                var list = _reviews.GetByStudent(_current.StudentID);
                gridMyReviews.DataSource = list.Select(r => new
                {
                    r.ReviewID,
                    r.FacilityName,
                    r.Rating,
                    r.Comments,
                    CreatedAt = r.CreatedAt.ToString("yyyy-MM-dd HH:mm")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reviews: " + ex.Message);
            }
        }

        private void BtnSubmitReview_Click(object sender, EventArgs e)
        {
            if (cboFacilityForReview.SelectedValue == null)
            {
                MessageBox.Show("Select a facility.");
                return;
            }

            int facilityId = Convert.ToInt32(cboFacilityForReview.SelectedValue);
            int rating = (int)numRating.Value;

            // Use any text in the comment box (can be empty)
            string comments = txtComments.Text.Trim();

            try
            {
                _reviews.Add(_current.StudentID, facilityId, rating, comments);
                MessageBox.Show("Review submitted. Thank you!");

                numRating.Value = 5;
                txtComments.Clear();
                RefreshMyReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submit failed: " + ex.Message);
            }
        }

        // Add comments
        private void LblAddComments_Click(object sender, EventArgs e)
        {
            if (cboFacilityForReview.SelectedValue == null || string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please select a facility and enter your comment.");
                return;
            }

            int facilityId = Convert.ToInt32(cboFacilityForReview.SelectedValue);
            string comments = txtComments.Text.Trim();

            try
            {
                // rating = 0 since you're only adding a comment
                _reviews.Add(_current.StudentID, facilityId, 0, comments);
                MessageBox.Show("Comment added successfully!");

                txtComments.Clear();    
                RefreshMyReviews();      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add comment: " + ex.Message);
            }
        }

        // NEW: Delete review
        private void BtnDeleteReview_Click(object sender, EventArgs e)
        {
            if (gridMyReviews.CurrentRow == null)
            {
                MessageBox.Show("Select a review to delete.");
                return;
            }

            int reviewId = Convert.ToInt32(gridMyReviews.CurrentRow.Cells["ReviewID"].Value);

            if (MessageBox.Show("Delete this review?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                _reviews.Delete(reviewId);
                MessageBox.Show("Review deleted successfully!");
                RefreshMyReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete review: " + ex.Message);
            }
        }

        // ---------- Profile ----------
        private void BtnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                _current.Name = txtProfileName.Text.Trim();
                _current.Phone = txtProfilePhone.Text.Trim();
                _current.University = txtProfileUniversity.Text.Trim();
                _students.UpdateProfile(_current);
                MessageBox.Show("Profile updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
    }
}
