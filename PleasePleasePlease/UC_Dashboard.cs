using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private Form currentDetailsForm;

        private void labelViewDeetsAvailRoom_Click(object sender, EventArgs e)
        {
            // Close the current form if it's not null
            if (currentDetailsForm != null && !currentDetailsForm.IsDisposed)
            {
                currentDetailsForm.Close();
            }

            // Create and show the new form
            Details_AvailRooms detailsAvailRooms = new Details_AvailRooms();
            detailsAvailRooms.Show();

            // Update the currentDetailsForm to the newly shown form
            currentDetailsForm = detailsAvailRooms;
        }

        private void labelViewDetailsBookings_Click(object sender, EventArgs e)
        {
            if (currentDetailsForm != null && !currentDetailsForm.IsDisposed)
            {
                currentDetailsForm.Close();
            }

            Details_Bookings detailsBookings = new Details_Bookings();
            detailsBookings.Show();

            currentDetailsForm = detailsBookings;
        }

        private void labelViewDetailsOccRooms_Click(object sender, EventArgs e)
        {
            if (currentDetailsForm != null && !currentDetailsForm.IsDisposed)
            {
                currentDetailsForm.Close();
            }

            Details_OccRooms detailsOccRooms = new Details_OccRooms();
            detailsOccRooms.Show();

            currentDetailsForm = detailsOccRooms;
        }

        private void labelViewDetailsPendingPayments_Click(object sender, EventArgs e)
        {
            if (currentDetailsForm != null && !currentDetailsForm.IsDisposed)
            {
                currentDetailsForm.Close();
            }

            Details_PendingPayments detailsPendingPayments = new Details_PendingPayments();
            detailsPendingPayments.Show();

            currentDetailsForm = detailsPendingPayments;
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Search code starts here
        }

        private void ButtonBookingHistory_Click(object sender, EventArgs e)
        {
            Details_BookingHistory bookingHistory = new Details_BookingHistory();
            bookingHistory.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Details_AvailRooms detailsAvailRooms = new Details_AvailRooms();
            detailsAvailRooms.Show();
        }
    }
}
