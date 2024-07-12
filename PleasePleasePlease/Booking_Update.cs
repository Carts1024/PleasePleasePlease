using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class Booking_Update : Form
    {
        private Booking _booking;

        public Booking_Update(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
            comboBoxBookingStatus.Items.AddRange(new object[] { "Checked-In", "Check-Out", "Cancelled" });
            PopulateBookingDetails();
        }
        private void GradButtonAddRoom_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }
        private void PopulateBookingDetails()
        {
            if (_booking != null)
            {
                textBoxRoomNo.Text = _booking.RoomNumber.ToString();
                GuestNameTxtBox.Text = $"{_booking.Guest.FirstName} {_booking.Guest.LastName}";
                GuestNameTxtBox.ReadOnly = true ;
                dateTimePickerCheckout.Value = _booking.CheckOutDate;
                dateTimePicker1CheckOutTime.Value = DateTime.Today.Add(_booking.CheckOutTime);
                comboBoxBookingStatus.SelectedItem = _booking.BookingStatus;
            }
        }
        private void UpdateRoom()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var bookingToUpdate = context.Bookings.Include(b => b.Guest).FirstOrDefault(b => b.BookingID == _booking.BookingID);
                    if (bookingToUpdate != null)
                    {
                        bookingToUpdate.RoomNumber = int.Parse(textBoxRoomNo.Text);
                        bookingToUpdate.CheckOutDate = dateTimePickerCheckout.Value.Date;
                        bookingToUpdate.CheckOutTime = dateTimePicker1CheckOutTime.Value.TimeOfDay;
                        bookingToUpdate.BookingStatus = comboBoxBookingStatus.Text;

                        context.SaveChanges();
                        var BookingUpdated = new Dialogue_BookingUpdated();
                        BookingUpdated.ShowDialog();
                        // Update the local _booking object
                        _booking.RoomNumber = bookingToUpdate.RoomNumber;
                        _booking.CheckInDate = bookingToUpdate.CheckInDate;
                        _booking.CheckInTime = bookingToUpdate.CheckInTime;
                        _booking.CheckOutDate = bookingToUpdate.CheckOutDate;
                        _booking.CheckOutTime = bookingToUpdate.CheckOutTime;
                        _booking.BookingStatus = bookingToUpdate.BookingStatus;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Booking not found.");
                    }
                }
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqliteException sqliteEx && sqliteEx.SqliteErrorCode == 19)
            {
                MessageBox.Show("Failed to update booking. The room number or guest information may be invalid. Please ensure all information is correct.", "Foreign Key Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}