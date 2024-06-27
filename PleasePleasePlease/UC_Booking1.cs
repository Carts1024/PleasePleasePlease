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
    public partial class UC_Booking1 : UserControl
    {
        public UC_Booking1()
        {
            InitializeComponent();
        }

        private void labelListofBooking_Click(object sender, EventArgs e)
        {
            panelListofBooking.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void labelAddBook_Click(object sender, EventArgs e)
        {
            panelListofBooking.Visible = false;
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }


        private void buttonExitEditGuest_Click(object sender, EventArgs e)
        {
            buttonSaveEditBookings.Visible = false;
            buttonExitEditBookings.Visible = false;
            ColumnCheckInDate.ReadOnly = true;
            ColumnCheckInTime.ReadOnly = true;
            ColumnCheckOutDate.ReadOnly = true;
            ColumnCheckOutTime.ReadOnly = true;
        }

        private void buttonSaveEditBookings_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonSaveEditBookings.Visible = false;
            buttonExitEditBookings.Visible = false;
            ColumnCheckInDate.ReadOnly = true;
            ColumnCheckInTime.ReadOnly = true;
            ColumnCheckOutDate.ReadOnly = true;
            ColumnCheckOutTime.ReadOnly = true;
            Dialogue_BookingUpdated bookingUpdated = new Dialogue_BookingUpdated();
            bookingUpdated.Show();
        }

        private void buttonEditBookings_Click(object sender, EventArgs e)
        {
            buttonSaveEditBookings.Visible = true;
            buttonExitEditBookings.Visible = true;
            ColumnCheckInDate.ReadOnly = false;
            ColumnCheckInTime.ReadOnly = false;
            ColumnCheckOutDate.ReadOnly = false;
            ColumnCheckOutTime.ReadOnly = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelListofBooking.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Add Booking to Database Code starts here

            textBoxGuestID.Clear();
            textBoxRoomNo.Clear();
            dateTimePickerCheckIn.ResetText();
            dateTimePickerCheckout.ResetText();
            textBoxCheckInTime.Clear();
            textBoxCheckOutTime.Clear();

            Dialogue_BookingAdded bookAdded = new Dialogue_BookingAdded();
            bookAdded.Show();
        }

        private void ButtonImportRecords_Click(object sender, EventArgs e)
        {
            Dialogue_BookingImported bookingImported = new Dialogue_BookingImported();
            bookingImported.Show();
        }
    }
}