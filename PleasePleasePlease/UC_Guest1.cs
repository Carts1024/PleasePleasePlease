using Mirai_Paradise_Hotel;
using Practice;
using System;
using System.Collections.Generic;
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
            dataGridViewGuests.CellDoubleClick += dataGridViewGuests_CellContentDoubleClick;
        }

        private void LoadUserControl(UserControl userControl)
        {
            parentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void dataGridViewGuests_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedGuest = dataGridViewGuests.Rows[e.RowIndex].DataBoundItem as Guest;
                _dashboard.SetSelectedGuest(selectedGuest);
                _dashboard.ActivateBookingButton();
                LoadUserControl(new UC_Booking1(selectedGuest));
            }
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            _dashboard.ClearSelectedGuest();
            LoadUserControl(new UC_Booking1(null));
        }

        private void labelListofGuest_Click(object sender, EventArgs e)
        {
            panelListofGuest.Visible = true;
            panelListOfGuests2.Visible = true;
            panelAddGuest2.Visible = true;
        }

        private void labelAddGuest_Click(object sender, EventArgs e)
        {
            panelAddGuest2.Visible = false;
            panelListOfGuests2.Visible = false;
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            // ignore this
            // refer to GradButtonAddGuest_Click instead
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditGuest_Click(object sender, EventArgs e)
        {
            buttonSaveEditGuest.Visible = true;
            buttonExitEditGuest.Visible = true;
            ColumnLastName.ReadOnly = false;
            ColumnFirstName.ReadOnly = false;
            ColumnMI.ReadOnly = false;
            ColumnGender.ReadOnly = false;
            ColumnBirthDate.ReadOnly = false;
            ColumnCity.ReadOnly = false;
            ColumnStreet.ReadOnly = false;
            ColumnNationality.ReadOnly = false;
            ColumnEmail.ReadOnly = false;
            ColumnPhoneNumber.ReadOnly = false;
            ColumnAge.ReadOnly = false;
        }

        private void buttonExitEditGuest_Click(object sender, EventArgs e)
        {
            buttonSaveEditGuest.Visible = false;
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

            buttonSaveEditGuest.Visible = false;
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
            panelListofGuest.Visible = false;
            panelAddGuest2.Visible = false;
            panelListOfGuests2.Visible = false;
        }

        private void LoadData()
        {
            using (DataContext context = new DataContext())
            {
                DataBaseGuests = context.Guests.OrderBy(u => u.Index).ToList();
                dataGridViewGuests.DataSource = null;
                dataGridViewGuests.DataSource = DataBaseGuests;

                foreach (DataGridViewRow row in dataGridViewGuests.Rows)
                {
                    if (row.Cells["ColumnBirthDate"].Value != null)
                    {
                        DateTime birthDate = Convert.ToDateTime(row.Cells["ColumnBirthDate"].Value);
                        int age = CalculateAge(birthDate);
                        row.Cells["ColumnAge"].Value = age;
                    }
                }
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
                var Zipcode = textBoxZipcode.Text;
                var Email = textBoxEmail.Text;
                var Contact = textBoxContactNo.Text;

                if (!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(MiddleInitial)
                     && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Nationality)
                     && !string.IsNullOrEmpty(CityAddress) && !string.IsNullOrEmpty(StateAddress) && !string.IsNullOrEmpty(Zipcode)
                     && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Contact))
                {
                    // Create a new Guest object and add it to the database
                    var newGuest = new Guest()
                    {
                        LastName = LastName,
                        FirstName = FirstName,
                        MiddleInitial = MiddleInitial,
                        BirthDate = Birthdate,
                        Gender = Gender,
                        Nationality = Nationality,
                        CityAddress = CityAddress,
                        StreetAddress = StateAddress,
                        Zipcode = Zipcode,
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
                    textBoxZipcode.Clear();
                    textBoxEmail.Clear();
                    textBoxContactNo.Clear();

                    Dialogue_GuestAdded guestAdded = new Dialogue_GuestAdded();
                    guestAdded.Show();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.");
                }
            }
        }


    }
}

