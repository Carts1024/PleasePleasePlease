using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            comboBoxFilterGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
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
            ColumnAge.ReadOnly = false;
            ColumnNationality.ReadOnly = false;
            ColumnAddress.ReadOnly = false;
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
            ColumnAge.ReadOnly = true;
            ColumnNationality.ReadOnly = true;
            ColumnAddress.ReadOnly = true;
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
            ColumnAge.ReadOnly = true;
            ColumnNationality.ReadOnly = true;
            ColumnAddress.ReadOnly = true;
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

        private void gradButtonAddGuest_Click(object sender, EventArgs e)
        {
            // Add Guest to Database Code starts here

            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxMiddleInitial.Clear();
            dateTimePickerBirthdate.ResetText();
            comboBoxGender.SelectedIndex = -1;
            textBoxNationality.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            textBoxContactNo.Clear();

            Dialogue_GuestAdded guestAdded = new Dialogue_GuestAdded();
            guestAdded.Show();
        }
    }
}