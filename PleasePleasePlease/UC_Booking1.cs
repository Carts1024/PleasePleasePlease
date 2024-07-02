using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Mirai_Paradise_Hotel;
using Mirai_Paradise_Hotel.DB_MODELS;
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
        // Stores an instance of a guest within the class 
        private Guest _guest;
        public List<Booking> DataBaseBooking { get; set; }
        public UC_Booking1(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
            if (_guest != null)
            {
                name_lbl.Visible = true;
                GuestName_lbl.Text = $"{_guest.FirstName} {_guest.LastName}";
            }
            else
            {
                name_lbl.Visible = false;
                GuestName_lbl.Visible = false;
            }
            LoadData();

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

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            // ignore this
            // refer to  guna2GradientButton1_Click instead
            // sorry forgot to rename the button
        }

        /*        private void buttonExitEditGuest_Click(object sender, EventArgs e)
                {
                    buttonSaveEditBookings.Visible = false;
                    buttonExitEditBookings.Visible = false;
                    ColumnCheckInDate.ReadOnly = true;
                    ColumnCheckInTime.ReadOnly = true;
                    ColumnCheckOutDate.ReadOnly = true;
                    ColumnCheckOutTime.ReadOnly = true;
                }*/

        /*       private void buttonSaveEditBookings_Click(object sender, EventArgs e)
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
               }*/

        /*       private void buttonEditBookings_Click(object sender, EventArgs e)
               {
                   buttonSaveEditBookings.Visible = true;
                   buttonExitEditBookings.Visible = true;
                   ColumnCheckInDate.ReadOnly = false;
                   ColumnCheckInTime.ReadOnly = false;
                   ColumnCheckOutDate.ReadOnly = false;
                   ColumnCheckOutTime.ReadOnly = false;
               }*/

        private void label1_Click(object sender, EventArgs e)
        {
            panelListofBooking.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        // Load data into the data grid view
        private void LoadData()
        {
            using (DataContext context = new DataContext())
            {
                var query = from booking in context.Bookings
                            join guest in context.Guests on booking.GuestID equals guest.GuestID
                            orderby booking.Index
                            select new
                            {
                                Index = booking.Index,
                                GuestName = guest.FirstName + " " + guest.LastName,
                                RoomNumber = booking.RoomNumber,
                                CheckInDate = booking.CheckInDate.Date,
                                CheckInTime = booking.CheckInTime,
                                CheckOutDate = booking.CheckOutDate.Date,
                                CheckOutTime = booking.CheckOutTime
                            };

                // Clear existing columns before setting new data source
                dataGridViewBooking.Columns.Clear();

                // Set the data source to the LINQ query result
                dataGridViewBooking.DataSource = query.ToList();

                // Optionally, you can set column headers programmatically
                dataGridViewBooking.Columns["Index"].HeaderText = "Index";
                dataGridViewBooking.Columns["GuestName"].HeaderText = "Guest Name";
                dataGridViewBooking.Columns["RoomNumber"].HeaderText = "Room Number";
                dataGridViewBooking.Columns["CheckInDate"].HeaderText = "Check In Date";
                dataGridViewBooking.Columns["CheckInTime"].HeaderText = "Check In Time";
                dataGridViewBooking.Columns["CheckOutDate"].HeaderText = "Check Out Date";
                dataGridViewBooking.Columns["CheckOutTime"].HeaderText = "Check Out Time";
            }
        }

        private void OnBookingAddedDialogClosed(object sender, FormClosedEventArgs e)
        {
            // Show panel2 when the dialog is closed
            panel1.Visible = true;
            panel2.Visible = true;
            panelListofBooking.Visible = true;
            LoadData();
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (_guest == null)
            {
                MessageBox.Show("Please select a guest before adding a booking.");
                return;
            }

            // Check if room number is provided
            if (string.IsNullOrEmpty(textBoxRoomNo.Text))
            {
                MessageBox.Show("Please enter a room number.");
                return;
            }

            // Disable the button to prevent multiple submissions
            GradButtonAddBooking.Enabled = false;

            using (DataContext context = new DataContext())
            {
                var roomNumberText = textBoxRoomNo.Text;
                var checkInDate = dateTimePickerCheckIn.Value.Date;
                var checkInTime = dateTimePicker1CheckInTime.Value.TimeOfDay;
                var checkOutDate = dateTimePickerCheckout.Value;
                var checkOutTime = dateTimePicker1CheckOutTime.Value.TimeOfDay;

                if (int.TryParse(roomNumberText, out int roomNumber))
                {
                    // Find the maximum index in the Bookings table and increment by 1
                    int nextIndex = context.Bookings.Any() ? context.Bookings.Max(b => b.Index) + 1 : 1;

                    var room = context.Rooms.Find(roomNumber);

                    if (room != null)
                    {
                        var newBooking = new Booking()
                        {
                            Index = nextIndex,
                            RoomNumber = roomNumber,
                            GuestID = _guest.GuestID,
                            CheckInDate = checkInDate,
                            CheckInTime = checkInTime,
                            CheckOutDate = checkOutDate,
                            CheckOutTime = checkOutTime,
                        };

                        context.Bookings.Add(newBooking);
                        context.SaveChanges();

                        // Reset UI elements
                        GuestName_lbl.ResetText();
                        textBoxRoomNo.Clear();
                        dateTimePickerCheckIn.ResetText();
                        dateTimePicker1CheckInTime.ResetText();
                        dateTimePickerCheckout.ResetText();
                        dateTimePicker1CheckOutTime.ResetText();

                        Dialogue_BookingAdded bookAdded = new Dialogue_BookingAdded();
                        bookAdded.FormClosed += OnBookingAddedDialogClosed;
                        bookAdded.Show();
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("The specified Room does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields with valid data.");
                }
            }
            GradButtonAddBooking.Enabled = true;


        }


        private void ButtonImportRecords_Click(object sender, EventArgs e)
        {
            Dialogue_BookingImported bookingImported = new Dialogue_BookingImported();
            bookingImported.Show();
        }

    }
}