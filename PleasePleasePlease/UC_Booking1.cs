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
        }

        private void labelAddBook_Click(object sender, EventArgs e)
        {
            panelListofBooking.Visible = false;
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            // Add Booking to Database Code starts here

            textBoxGuestID.Clear();
            textBoxRoomNo.Clear();
            dateTimePickerCheckIn.ResetText();
            dateTimePickerCheckout.ResetText();
            textBoxCheckInTime.Clear();
            textBoxCheckOutTime.Clear();

            Dialogue_BookAdded bookAdded = new Dialogue_BookAdded();
            bookAdded.Show();
        }

        private void buttonBookingImport_Click(object sender, EventArgs e)
        {
            // Import Booking Records code starts here

            Dialogue_BookImported impBook = new Dialogue_BookImported();
            impBook.Show();
        }
    }
}
