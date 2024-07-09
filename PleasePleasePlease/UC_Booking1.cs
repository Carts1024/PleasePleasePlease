using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using Mirai_Paradise_Hotel.DB_MODELS;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PleasePleasePlease
{
    public partial class UC_Booking1 : UserControl
    {
        private Guest _guest;
        public List<Booking> DataBaseBooking { get; set; }

        public UC_Booking1(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
            InitializeGuestInfo();
            LoadData();
            CheckGuestInfo();
        }

        private void CheckGuestInfo()
        {
            if (_guest != null)
            {
                labelAddBook_Click(this, EventArgs.Empty);
            }
        }

        private void InitializeGuestInfo()
        {
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
        }

        private void LoadData()
        {
            using (var context = new DataContext())
            {
                var bookings = context.Bookings.Include(b => b.Guest).ToList();

                var bookingData = bookings.Select(b => new
                {
                    b.Index,
                    GuestName = b.Guest.FirstName + " " + b.Guest.LastName,
                    b.BookingID,
                    b.RoomNumber,
                    b.CheckInDate,
                    b.CheckInTime,
                    b.CheckOutDate,
                    b.CheckOutTime
                }).ToList();

                dataGridViewBooking.Columns.Clear();
                dataGridViewBooking.DataSource = bookingData;

                dataGridViewBooking.Columns["BookingID"].Visible = false;
                dataGridViewBooking.Columns["Index"].HeaderText = "Index";
                dataGridViewBooking.Columns["GuestName"].HeaderText = "Guest Name";
                dataGridViewBooking.Columns["RoomNumber"].HeaderText = "Room Number";
                dataGridViewBooking.Columns["CheckInDate"].HeaderText = "Check In Date";
                dataGridViewBooking.Columns["CheckInTime"].HeaderText = "Check In Time";
                dataGridViewBooking.Columns["CheckOutDate"].HeaderText = "Check Out Date";
                dataGridViewBooking.Columns["CheckOutTime"].HeaderText = "Check Out Time";
            }
        }

        private void GridRead()
        {
            LoadData();
        }

        private void ShowBookingPanels()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panelListofBooking.Visible = true;
            panelAddaGuest.Visible = true;
            panel10.Visible = true;
        }

        private void HideBookingPanels()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panelListofBooking.Visible = false;
            panelAddaGuest.Visible = false;
        }

        private void OnBookingAddedDialogClosed(object sender, FormClosedEventArgs e)
        {
            ShowBookingPanels();
            LoadData();
        }

        private void AddBooking()
        {
            if (_guest == null)
            {
                MessageBox.Show("Please select a guest before adding a booking.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxRoomNo.Text))
            {
                MessageBox.Show("Please enter a room number.");
                return;
            }

            GradButtonAddBooking.Enabled = false;

            using (DataContext context = new DataContext())
            {
                if (int.TryParse(textBoxRoomNo.Text, out int roomNumber))
                {
                    var room = context.Rooms.Find(roomNumber);

                    if (room != null)
                    {
                        int nextIndex = context.Bookings.Any() ? context.Bookings.Max(b => b.Index) + 1 : 1;

                        var newBooking = new Booking
                        {
                            Index = nextIndex,
                            RoomNumber = roomNumber,
                            GuestID = _guest.GuestID,
                            CheckInDate = dateTimePickerCheckIn.Value.Date,
                            CheckInTime = dateTimePicker1CheckInTime.Value.TimeOfDay,
                            CheckOutDate = dateTimePickerCheckout.Value.Date,
                            CheckOutTime = dateTimePicker1CheckOutTime.Value.TimeOfDay,
                        };

                        context.Bookings.Add(newBooking);
                        context.SaveChanges();

                        ResetBookingForm();
                        ShowBookingAddedDialog();
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

        private void ResetBookingForm()
        {
            GuestName_lbl.ResetText();
            textBoxRoomNo.Clear();
            dateTimePickerCheckIn.ResetText();
            dateTimePicker1CheckInTime.ResetText();
            dateTimePickerCheckout.ResetText();
            dateTimePicker1CheckOutTime.ResetText();
        }

        private void ShowBookingAddedDialog()
        {
            var bookingAddedDialog = new Dialogue_BookingAdded();
            bookingAddedDialog.FormClosed += OnBookingAddedDialogClosed;
            bookingAddedDialog.Show();
        }

        // Custom DateTime converter
        private class CustomDateTimeConverter : DateTimeConverter
        {
            private readonly string[] formats = { "dd/MM/yyyy", "MM/dd/yyyy", "yyyy-MM-dd" };

            public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
            {
                foreach (var format in formats)
                {
                    if (DateTime.TryParseExact(text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                    {
                        return date;
                    }
                }
                return base.ConvertFromString(text, row, memberMapData);
            }
        }

        private void ImportRecords()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName; // Get the selected file path

                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = args => args.Header.ToLower(),
                    HeaderValidated = null, // Disable header validation
                };

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, csvConfig))
                {
                    csv.Context.TypeConverterCache.AddConverter<DateTime>(new CustomDateTimeConverter());
                    csv.Context.RegisterClassMap<BookingMap>();

                    var records = csv.GetRecords<Booking>().ToList();  // Get the records from the CSV file

                    using (DataContext context = new DataContext())
                    {
                        // Validate foreign key references
                        var validGuestIds = context.Guests.Select(g => g.GuestID).ToHashSet();
                        var invalidRecords = records.Where(r => !validGuestIds.Contains(r.GuestID)).ToList();

                        if (invalidRecords.Any())
                        {
                            var invalidIds = string.Join(", ", invalidRecords.Select(r => r.GuestID));
                            MessageBox.Show($"Error: The following Guest IDs do not exist in the database: {invalidIds}");
                            return;
                        }

                        foreach (var record in records)
                        {
                            var existingBooking = context.Bookings.FirstOrDefault(b => b.BookingID == record.BookingID);
                            if (existingBooking != null)
                            {
                                // Update existing record
                                existingBooking.Index = record.Index;
                                existingBooking.RoomNumber = record.RoomNumber;
                                existingBooking.GuestID = record.GuestID;
                                existingBooking.CheckInDate = record.CheckInDate;
                                existingBooking.CheckInTime = record.CheckInTime;
                                existingBooking.CheckOutDate = record.CheckOutDate;
                                existingBooking.CheckOutTime = record.CheckOutTime;
                            }
                            else
                            {
                                // Add new record
                                context.Bookings.Add(record);
                            }
                        }

                        context.SaveChanges();
                    }

                    // Update the DataGridView to reflect the newly imported records
                    LoadData();
                }
            }
        }


        private void ExportRecords()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName; // Get the selected file path

                using (var writer = new StreamWriter(filePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    try
                    {
                        using (var context = new DataContext())
                        {
                            var bookings = context.Bookings.Select(b => new BookingExportDto
                            {
                                Index = b.Index,
                                BookingID = b.BookingID,
                                CheckInDate = b.CheckInDate,
                                CheckInTime = b.CheckInTime,
                                CheckOutDate = b.CheckOutDate,
                                CheckOutTime = b.CheckOutTime,
                                GuestID = b.GuestID,
                                RoomNumber = b.RoomNumber
                            }).ToList();

                            csvWriter.WriteRecords(bookings);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing CSV file: " + ex.Message);
                    }
                }
            }
        }


        // Event handlers
        private void labelListofBooking_Click(object sender, EventArgs e) => ShowBookingPanels();
        public void labelAddBook_Click(object sender, EventArgs e)
        {
            HideBookingPanels();
            panel10.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            ShowBookingPanels();
        }
        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            AddBooking();
            labelListofBooking_Click(sender, e);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e) => AddBooking();

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void ButtonImportRecords_Click(object sender, EventArgs e)
        {
            ImportRecords();
            //   var bookingImported = new Dialogue_BookingImported();
            // bookingImported.Show();
        }

        private void dataGridViewBooking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the booking ID from the DataGridView
                var bookingId = (int)dataGridViewBooking.Rows[e.RowIndex].Cells["BookingID"].Value;

                // Fetch the booking from the database
                using (var context = new DataContext())
                {
                    var selectedBooking = context.Bookings.Include(b => b.Guest).FirstOrDefault(b => b.BookingID == bookingId);
                    if (selectedBooking != null)
                    {
                        var bookingUpdateForm = new Booking_Update(selectedBooking); // Pass the Booking entity
                        bookingUpdateForm.FormClosed += (s, args) => LoadData();
                        bookingUpdateForm.Show();
                    }
                }
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = true;
            ImportButton.Visible = false;
            ButtonImportBookings.Visible = true;
            ButtonExportBookings.Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = false;
            ImportButton.Visible = true;
            ButtonImportBookings.Visible = false;
            ButtonExportBookings.Visible = true;
        }

        private void ButtonExportBookings_Click(object sender, EventArgs e)
        {
            ExportRecords();
        }
    }
}
