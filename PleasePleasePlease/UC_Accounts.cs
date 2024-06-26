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
    public partial class UC_Accounts : UserControl
    {
        public UC_Accounts()
        {
            InitializeComponent();
            comboBoxFilterAccountType.Items.AddRange(new object[] { "Administrator", "Manager", "Receptionist" });
        }

        private void buttonAddAcc_Click(object sender, EventArgs e)
        {
            //ignore this
            // refer to GradButtonAddAccount instead
        }

        private void buttonEditAccounts_Click(object sender, EventArgs e)
        {
            buttonSaveEditAccounts.Visible = true;
            buttonExitEditAccounts.Visible = true;
            ColumnUsername.ReadOnly = false;
            ColumnPassword.ReadOnly = false;
            ColumnAccountType.ReadOnly = false;
        }

        private void buttonExitEditAccounts_Click(object sender, EventArgs e)
        {
            buttonSaveEditAccounts.Visible = false;
            buttonExitEditAccounts.Visible = false;
            ColumnUsername.ReadOnly = true;
            ColumnPassword.ReadOnly = true;
            ColumnAccountType.ReadOnly = true;
        }

        private void buttonSaveEditAccounts_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonSaveEditAccounts.Visible = false;
            buttonExitEditAccounts.Visible = false;
            ColumnUsername.ReadOnly = true;
            ColumnPassword.ReadOnly = true;
            ColumnAccountType.ReadOnly = true;
            Dialogue_AccountUpdated accUpdated = new Dialogue_AccountUpdated();
            accUpdated.Show();
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Search code starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void GradButtonAddAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAcc = new CreateAccount();
            createAcc.Show();
        }
    }
}
