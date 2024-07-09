using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mirai_Paradise_Hotel
{
    public partial class GuestUpdateForm : Form
    {
        private Guest _guest;

        public GuestUpdateForm(Guest selectedGuest)
        {
            InitializeComponent();
            _guest = selectedGuest;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
            PopulateGuestDetails();

        }

        private void PopulateGuestDetails()
        {
            if (_guest != null)
            {
                // Assuming you have TextBoxes or other controls to display guest information
                textBoxLastName.Text = _guest.LastName;
                textBoxFirstName.Text = _guest.FirstName;
                textBoxMiddleInitial.Text = _guest.MiddleInitial;
                dateTimePickerBirthdate.Value = _guest.BirthDate;
                comboBoxGender.SelectedItem = _guest.Gender;
                textBoxNationality.Text = _guest.Nationality;
                textBoxStreet.Text = _guest.StreetAddress;
                textBoxCity.Text = _guest.CityAddress;
                textBoxState.Text = _guest.StateAddress;
                textBoxEmail.Text = _guest.Email;
                textBoxContactNo.Text = _guest.PhoneNumber;

                // Populate other controls as needed
            }
        }

        // Event handler for saving updated guest details
        private void gradButtonUpdateGuest_Click(object sender, EventArgs e)
        {
            UpdateGuestDetails();
        }
        private void UpdateGuestDetails()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var guestToUpdate = context.Guests.FirstOrDefault(g => g.GuestID == _guest.GuestID);
                    if (guestToUpdate != null)
                    {
                        guestToUpdate.LastName = textBoxLastName.Text;
                        guestToUpdate.FirstName = textBoxFirstName.Text;
                        guestToUpdate.MiddleInitial = textBoxMiddleInitial.Text;
                        guestToUpdate.BirthDate = dateTimePickerBirthdate.Value;
                        guestToUpdate.Gender = comboBoxGender.Text;
                        guestToUpdate.Nationality = textBoxNationality.Text;
                        guestToUpdate.StreetAddress = textBoxStreet.Text;
                        guestToUpdate.CityAddress = textBoxCity.Text;
                        guestToUpdate.StateAddress = textBoxState.Text;
                        guestToUpdate.Email = textBoxEmail.Text;
                        guestToUpdate.PhoneNumber = textBoxContactNo.Text;

                        context.SaveChanges();
                        var DialogueUpdated = new Dialogue_GuestUpdated();
                        DialogueUpdated.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Guest not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
