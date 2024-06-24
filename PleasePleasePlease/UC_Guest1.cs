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
    public partial class UC_Guest1 : UserControl
    {
        public UC_Guest1()
        {
            InitializeComponent();
            comboBoxGender.Items.AddRange(new object[] {"Male", "Female", "Prefer not to say"});
            comboBoxFilterGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
        }

        private void labelListofGuest_Click(object sender, EventArgs e)
        {
            panelListofGuest.Visible = true;
        }

        private void labelAddGuest_Click(object sender, EventArgs e)
        {
            panelListofGuest.Visible = false;
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            // Add Guest to Database Code starts here

            textBoxGuestID.Clear();
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxMiddleInitial.Clear();
            dateTimePickerBirthdate.ResetText();
            comboBoxGender.SelectedIndex = -1;
            textBoxNationality.Clear();
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxContactNo.Clear();

            Dialogue_GuestAdded guestAdded = new Dialogue_GuestAdded();
            guestAdded.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }
    }
}
