using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_Guest1 : UserControl
    {
        private Panel parentPanel;
        private Panel panelBase;
        private Random random;
        private Dashboard _dashboard;
        public List<Guest> DataBaseGuests { get; private set; }
        private bool EditPressed = false; // Flag to check if edit mode is enabled
        private bool DeletePressed = false; // Flag to check if delete mode is enabled
        private GuestUpdateForm _guestUpdateForm;

        public UC_Guest1(Dashboard dashboard, Panel parentPanel)
        {
            InitializeComponent();
            this._dashboard = dashboard;
            this.parentPanel = parentPanel;
            LoadData();
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            comboBoxFilterGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            dataGridViewGuests.ReadOnly = true;
            dataGridViewGuests.AllowUserToAddRows = false;
            dataGridViewGuests.AllowUserToDeleteRows = false;

            dataGridViewGuests.CellFormatting += dataGridViewGuests_CellFormatting;
            dataGridViewGuests.CellDoubleClick += dataGridViewGuests_CellDoubleClick;
        }

        private void LoadUserControl(UserControl userControl)
        {
            parentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void dataGridViewGuests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (EditPressed)
                {
                    if (_guestUpdateForm == null || _guestUpdateForm.IsDisposed) // Check if the form is already open
                    {
                        // Fetch the selected guest from the DataGridView
                        var selectedGuest = dataGridViewGuests.Rows[e.RowIndex].DataBoundItem as Guest;

                        if (selectedGuest != null)
                        {
                            // Open a form to update the guest details
                            _guestUpdateForm = new GuestUpdateForm(selectedGuest); // Ensure GuestUpdateForm is a form for updating guest details
                            _guestUpdateForm.FormClosed += (s, args) =>
                            {
                                _guestUpdateForm = null; // Reset the form instance when closed
                                LoadData();
                            };
                            _guestUpdateForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve guest information. Please try again.");
                        }
                    }
                }
                else if (DeletePressed)
                {
                    var selectedGuest = dataGridViewGuests.Rows[e.RowIndex].DataBoundItem as Guest;
                    if (selectedGuest != null)
                    {
                        using (DataContext context = new DataContext())
                        {
                            var guest = context.Guests.Include(g => g.Bookings).FirstOrDefault(g => g.GuestID == selectedGuest.GuestID);

                            if (guest != null)
                            {
                                // Check if the guest has any bookings with status "Check-In"
                                var hasCurrentBooking = guest.Bookings.Any(b => b.BookingStatus == "Checked-In");
                                if (hasCurrentBooking)
                                {
                                    MessageBox.Show("Cannot delete the guest because they have a current booking with status 'Checked-In'.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Confirm deletion
                                var confirmResult = MessageBox.Show($"Are you sure you want to delete the guest {selectedGuest.FirstName} {selectedGuest.LastName}?",
                                    "Confirm Delete", MessageBoxButtons.YesNo);
                                if (confirmResult == DialogResult.Yes)
                                {
                                    try
                                    {
                                        guest.IsDeleted = true;  // Soft delete
                                        context.SaveChanges();

                                        // Reload data
                                        LoadData();
                                    }
                                    catch (Microsoft.Data.Sqlite.SqliteException ex) when (ex.SqliteErrorCode == 19) // SQLite Error 19: 'FOREIGN KEY constraint failed'
                                    {
                                        MessageBox.Show("Cannot delete the guest because there are related bookings.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to retrieve guest information. Please try again.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve guest information. Please try again.");
                    }
                }
                else
                {
                    var selectedGuest = dataGridViewGuests.Rows[e.RowIndex].DataBoundItem as Guest;

                    if (selectedGuest != null)
                    {
                        _dashboard.SetSelectedGuest(selectedGuest);
                        _dashboard.ActivateBookingButton();
                        LoadUserControl(new UC_Booking1(selectedGuest, _dashboard, parentPanel));
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve guest information. Please try again.");
                    }
                }
            }
        }




        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            _dashboard.ClearSelectedGuest();
            LoadUserControl(new UC_Booking1(null, _dashboard, parentPanel));
        }

        private void labelListofGuest_Click(object sender, EventArgs e)
        {
            panelAddGuest2.Visible = true;
            panelAddaGuest.Visible = false;
            panelADD.Visible = false;
            panelListofGuest.Visible = false;
            PanelAddGuestFILL.Visible = true;
        }

        private void labelAddGuest_Click(object sender, EventArgs e)
        {
            panelListofGuest.Visible = true;
            panelADD.Visible = true;
            panelAddGuest2.Visible = false;
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            // ignore this
            // refer to GradButtonAddGuest_Click instead
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
            string searchTerm = textBoxSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var filteredGuests = DataBaseGuests.Where(g =>
                    g.FirstName.ToLower().Contains(searchTerm) ||
                    g.LastName.ToLower().Contains(searchTerm) ||
                    g.MiddleInitial.ToLower().Contains(searchTerm) ||
                    g.Gender.ToLower().Contains(searchTerm) ||
                    g.StreetAddress.ToLower().Contains(searchTerm) ||
                    g.CityAddress.ToLower().Contains(searchTerm) ||
                    g.StateAddress.ToLower().Contains(searchTerm) ||
                    g.PhoneNumber.ToLower().Contains(searchTerm) ||
                    g.Email.ToLower().Contains(searchTerm) ||
                    g.Nationality.ToLower().Contains(searchTerm)
                ).ToList();

                dataGridViewGuests.DataSource = filteredGuests;
            }
            else
            {
                LoadData(); // If the search term is empty, reload all data
            }
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditGuest_Click(object sender, EventArgs e)
        {
            EditPressed = true; // Set the flag to true when edit button is clicked
            Console.WriteLine($"Edit mode enabled: {EditPressed}"); // Debugging statement
            buttonExitEditGuest.Visible = true;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = true;
            ImportButton.Visible = false;
            ButtonImportRecords.Visible = true;
            ButtonExportRecords.Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = false;
            ImportButton.Visible = true;
            ButtonImportRecords.Visible = false;
            ButtonExportRecords.Visible = true;
        }

        private void buttonExitEditGuest_Click(object sender, EventArgs e)
        {
            EditPressed = false; // Reset the flag when exiting edit mode
            Console.WriteLine($"Edit mode disabled: {EditPressed}"); // Debugging statement
            buttonExitEditGuest.Visible = false;
            ColumnLastName.ReadOnly = true;
            ColumnFirstName.ReadOnly = true;
            ColumnMI.ReadOnly = true;
            ColumnGender.ReadOnly = true;
            ColumnBirthDate.ReadOnly = true;
            ColumnCity.ReadOnly = true;
            ColumnStreet.ReadOnly = true;
            ColumnNationality.ReadOnly = true;
            ColumnEmail.ReadOnly = true;
            ColumnPhoneNumber.ReadOnly = true;
            ColumnAge.ReadOnly = true;
        }

        private void buttonSaveEditGuest_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonExitEditGuest.Visible = false;
            ColumnLastName.ReadOnly = true;
            ColumnFirstName.ReadOnly = true;
            ColumnMI.ReadOnly = true;
            ColumnGender.ReadOnly = true;
            ColumnBirthDate.ReadOnly = true;
            ColumnCity.ReadOnly = true;
            ColumnStreet.ReadOnly = true;
            ColumnNationality.ReadOnly = true;
            ColumnEmail.ReadOnly = true;
            ColumnPhoneNumber.ReadOnly = true;
            ColumnAge.ReadOnly = true;
            Dialogue_GuestUpdated guestUpdated = new Dialogue_GuestUpdated();
            guestUpdated.Show();
        }

        private void panelAddGuest2_Paint(object sender, PaintEventArgs e)
        {
            panelAddGuest.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PanelAddGuestFILL.Visible = false;
            panelAddaGuest.Visible = true;
            panelListofGuest.Visible = true;
            panelAddGuest2.Visible = false;
            panelADD.Visible = false;
        }

        private void LoadData()
        {
            using (DataContext context = new DataContext())
            {
                DataBaseGuests = context.Guests.OrderBy(u => u.Index).ToList();
                dataGridViewGuests.DataSource = null;
                dataGridViewGuests.DataSource = DataBaseGuests;

                // Load guests, excluding soft-deleted ones
                var guests = context.Guests.Where(g => !g.IsDeleted).ToList();
                dataGridViewGuests.DataSource = guests;
            }
        }



        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        private void dataGridViewGuests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the Age column is being formatted, update the value
            if (dataGridViewGuests.Columns[e.ColumnIndex].Name == "ColumnAge")
            {
                if (e.Value == null && dataGridViewGuests.Rows[e.RowIndex].Cells["ColumnBirthDate"].Value != null)
                {
                    var birthDate = (DateTime)dataGridViewGuests.Rows[e.RowIndex].Cells["ColumnBirthDate"].Value;
                    e.Value = CalculateAge(birthDate);
                }
            }
        }

        private void gradButtonAddGuest_Click(object sender, EventArgs e)
        {
            // Add Guest to Database Code starts here
            using (DataContext context = new DataContext())
            {
                var LastName = textBoxLastName.Text;
                var FirstName = textBoxFirstName.Text;
                var MiddleInitial = textBoxMiddleInitial.Text;
                var Birthdate = dateTimePickerBirthdate.Value;
                var Gender = comboBoxGender.Text;
                var Nationality = textBoxNationality.Text;
                var CityAddress = textBoxCity.Text;
                var StateAddress = textBoxState.Text;
                var StreetAddress = textBoxStreet.Text;
                var Email = textBoxEmail.Text;
                var Contact = textBoxContactNo.Text;

                if (!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(MiddleInitial)
                     && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Nationality)
                     && !string.IsNullOrEmpty(CityAddress) && !string.IsNullOrEmpty(StateAddress) && !string.IsNullOrEmpty(StreetAddress)
                     && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Contact))
                {
                    // Create a new Guest object and add it to the database
                    int nextIndex = context.Guests.Any() ? context.Guests.Max(b => b.Index) + 1 : 1;
                    var newGuest = new Guest()
                    {
                        Index = nextIndex,
                        LastName = LastName,
                        FirstName = FirstName,
                        MiddleInitial = MiddleInitial,
                        BirthDate = Birthdate,
                        Gender = Gender,
                        Nationality = Nationality,
                        CityAddress = CityAddress,
                        StreetAddress = StateAddress,
                        StateAddress = StreetAddress,
                        Email = Email,
                        PhoneNumber = Contact,
                    };
                    context.Guests.Add(newGuest);
                    context.SaveChanges();

                    // Reset Textboxes
                    textBoxLastName.Clear();
                    textBoxFirstName.Clear();
                    textBoxMiddleInitial.Clear();
                    dateTimePickerBirthdate.ResetText();
                    comboBoxGender.SelectedIndex = -1;
                    textBoxNationality.Clear();
                    textBoxCity.Clear();
                    textBoxState.Clear();
                    textBoxStreet.Clear();
                    textBoxEmail.Clear();
                    textBoxContactNo.Clear();

                    // Reload Data
                    LoadData();
                    panelAddaGuest.Visible = false;
                    Dialogue_GuestAdded guestAdded = new Dialogue_GuestAdded();
                    guestAdded.Show();
                }
            }
        }

        private void ButtonImportRecords_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };
                    csv.Context.TypeConverterCache.AddConverter<DateTime>(new CustomDateTimeConverter());

                    var records = csv.GetRecords<Guest>().ToList();

                    using (DataContext context = new DataContext())
                    {
                        foreach (var record in records)
                        {
                            // Check if a guest with the same GuestID or unique fields already exists
                            var existingGuest = context.Guests
                                .FirstOrDefault(g => g.GuestID == record.GuestID ||
                                                     (g.FirstName == record.FirstName &&
                                                      g.LastName == record.LastName &&
                                                      g.BirthDate == record.BirthDate &&
                                                      g.Email == record.Email));

                            if (existingGuest != null)
                            {
                                // Update existing guest
                                existingGuest.LastName = record.LastName;
                                existingGuest.FirstName = record.FirstName;
                                existingGuest.MiddleInitial = record.MiddleInitial;
                                existingGuest.BirthDate = record.BirthDate;
                                existingGuest.Gender = record.Gender;
                                existingGuest.Nationality = record.Nationality;
                                existingGuest.CityAddress = record.CityAddress;
                                existingGuest.StateAddress = record.StateAddress;
                                existingGuest.StreetAddress = record.StreetAddress;
                                existingGuest.Email = record.Email;
                                existingGuest.PhoneNumber = record.PhoneNumber;
                                existingGuest.IsDeleted = record.IsDeleted;
                            }
                            else
                            {
                                // Add new guest
                                context.Guests.Add(record);
                            }
                        }
                        context.SaveChanges();
                    }

                    LoadData();
                }
            }
        }

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

        private void ButtonExportRecords_Click(object sender, EventArgs e)
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
                        csvWriter.WriteRecords(DataBaseGuests);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing CSV file: " + ex.Message);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletePressed = true; // Set the flag to true when delete button is clicked
            Console.WriteLine($"Delete mode enabled: {DeletePressed}"); // Debugging statement
            buttonExitEditDelete.Visible = true;
        }

        private void buttonExitEditDelete_Click(object sender, EventArgs e)
        {
            DeletePressed = false; // Reset the flag when exiting delete mode
            Console.WriteLine($"Delete mode disabled: {DeletePressed}"); // Debugging statement
            buttonExitEditDelete.Visible = false;
        }
    }
}
