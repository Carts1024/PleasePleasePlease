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
        private Panel parentPanel;
        private Dashboard _dashboard;
        private bool EditPressed = false;
        private Booking_Update _bookingUpdate;

        public List<Booking> DataBaseBooking { get; set; }

        public UC_Booking1(Guest guest, Dashboard dashboard, Panel parentPanel)
        {
            InitializeComponent();
            _guest = guest;
            _dashboard = dashboard;
            this.parentPanel = parentPanel;
            InitializeGuestInfo();
            LoadData();
            comboBoxBookingStatus.Items.AddRange(new object[] { "Checked-In", "Check-Out", "Cancelled" });
            CheckGuestInfo();
            dataGridViewBooking.CellContentDoubleClick += dataGridViewBooking_CellContentDoubleClick;
        }

        private void LoadUserControl(UserControl userControl)
        {
            parentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(userControl);
            userControl.BringToFront();
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
                    b.CheckOutTime,
                    b.BookingStatus
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
                dataGridViewBooking.Columns["BookingStatus"].HeaderText = "Booking Status";
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
                        // Check the room status
                        if (room.RoomStatus == "Occupied" || room.RoomStatus == "Under Maintenance")
                        {
                            MessageBox.Show("The specified room is currently occupied or under maintenance and cannot be booked.");
                            GradButtonAddBooking.Enabled = true;
                            return;
                        }

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
                            BookingStatus = comboBoxBookingStatus.Text
                        };

                        context.Bookings.Add(newBooking);
                        context.SaveChanges();

                        // Update room status to "Occupied" if the booking is successfully created
                        room.RoomStatus = "Occupied";
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

                        List<Booking> validRecords = new List<Booking>();
                        List<string> errors = new List<string>();

                        foreach (var record in records)
                        {
                            // Log each record
                            Console.WriteLine($"Processing record: BookingID={record.BookingID}, BookingStatus={record.BookingStatus}");

                            try
                            {
                                // Ensure BookingStatus is not null or empty
                                if (string.IsNullOrWhiteSpace(record.BookingStatus))
                                {
                                    throw new Exception($"Booking ID {record.BookingID} has an empty BookingStatus.");
                                }

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
                                    existingBooking.BookingStatus = record.BookingStatus;
                                }
                                else
                                {
                                    // Add new record
                                    context.Bookings.Add(record);
                                }
                                validRecords.Add(record);
                            }
                            catch (Exception ex)
                            {
                                errors.Add($"Error importing Booking ID {record.BookingID}: {ex.Message}");
                            }
                        }

                        if (errors.Any())
                        {
                            var errorMessage = string.Join(Environment.NewLine, errors);
                            MessageBox.Show($"The following errors occurred during import:\n{errorMessage}");
                        }

                        if (validRecords.Any())
                        {
                            context.SaveChanges();
                        }
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
                                BookingStatus = b.BookingStatus,
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
            // var bookingImported = new Dialogue_BookingImported();
            // bookingImported.Show();
        }

        private void dataGridViewBooking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HandleBookingCellDoubleClick(e.RowIndex);
            }
        }

        private void HandleBookingCellDoubleClick(int rowIndex)
        {
            if (!EditPressed)
            {
                UpdateBooking(rowIndex);
            }
            else
            {
                OpenBillingPage(rowIndex);
            }
        }

        private void UpdateBooking(int rowIndex)
        {
            if (_bookingUpdate == null || _bookingUpdate.IsDisposed) // Check if the form is already open
            {
                var bookingStatus = GetCellValue(rowIndex, "BookingStatus");

                // Check if the booking status is "Cancelled" or "Check-Out"
                if (bookingStatus == "Cancelled" || "Check-Out".Equals(bookingStatus, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Cannot update a booking with status 'Cancelled' or 'Check-Out'.");
                    return;
                }

                var bookingId = GetBookingId(rowIndex);

                if (bookingId != null)
                {
                    using (var context = new DataContext())
                    {
                        var selectedBooking = context.Bookings.Include(b => b.Guest).FirstOrDefault(b => b.BookingID == bookingId.Value);
                        if (selectedBooking != null)
                        {
                            _bookingUpdate = new Booking_Update(selectedBooking); // Pass the Booking entity
                            _bookingUpdate.FormClosed += (s, args) =>
                            {
                                _bookingUpdate = null;
                                LoadData();
                            };
                            _bookingUpdate.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve booking information. Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The Booking ID is null. Please check the data source.");
                }
            }
        }

        private void OpenBillingPage(int rowIndex)
        {
             var bookingId = GetBookingId(rowIndex);

            if (bookingId != null)
            {
                using (var context = new DataContext())
                {
                    var selectedBooking = context.Bookings.Include(b => b.Guest).FirstOrDefault(b => b.BookingID == bookingId.Value);
                    if (selectedBooking != null)
                    {
                        _dashboard.SetSelectedBooking(selectedBooking);
                        _dashboard.SetSelectedGuest(selectedBooking.Guest); // Set the selected guest
                        _dashboard.ActivateBillingButton();
                        LoadUserControl(new UC_Billing(selectedBooking, selectedBooking.Guest)); // Pass both booking and guest
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve booking information. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("The Booking ID is null. Please check the data source.");
            }
        }

        private int? GetBookingId(int rowIndex)
        {
            if (dataGridViewBooking.Rows[rowIndex].Cells["BookingID"].Value != null)
            {
                return (int)dataGridViewBooking.Rows[rowIndex].Cells["BookingID"].Value;
            }

            return null;
        }

        private string GetCellValue(int rowIndex, string columnName)
        {
            return dataGridViewBooking.Rows[rowIndex].Cells[columnName].Value.ToString();
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

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            EditPressed = true; // Set the flag to true when edit button is clicked
            Console.WriteLine($"Edit mode enabled: {EditPressed}"); // Debugging statement
            buttonExitCheckOut.Visible = true;
        }

        private void buttonExitCheckOut_Click(object sender, EventArgs e)
        {
            EditPressed = false; // Reset the flag when exiting edit mode
            Console.WriteLine($"Edit mode disabled: {EditPressed}"); // Debugging statement
            buttonExitCheckOut.Visible = false;
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
    }
}
