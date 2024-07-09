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
    public partial class UC_Billing : UserControl
    {
        public List<User> DataBaseUsers { get; private set; }

        public UC_Billing()
        {
            InitializeComponent();
            comboBoxFilterPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid" });
        }

        private void buttonGenerateInvoice_Click(object sender, EventArgs e)
        {
            // ignore this
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditBillings_Click(object sender, EventArgs e)
        {
            buttonSaveEditBillings.Visible = true;
            buttonExitEditBillings.Visible = true;

        }

        private void buttonExitEditBookings_Click(object sender, EventArgs e)
        {
            buttonSaveEditBillings.Visible = false;
            buttonExitEditBillings.Visible = false;

        }

        private void buttonSaveEditBillings_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonSaveEditBillings.Visible = false;
            buttonExitEditBillings.Visible = false;
            Dialogue_BillingUpdated billUpdated = new Dialogue_BillingUpdated();
            billUpdated.Show();
        }

        private void ButtonGenerateInvo_Click(object sender, EventArgs e)
        {
            // Code for Generating Invoice starts here
        }
    }
}
