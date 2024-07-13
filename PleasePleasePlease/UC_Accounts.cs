using Microsoft.EntityFrameworkCore;
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
        public List<User> DatabaseUser {  get; set; }
        public UC_Accounts()
        {
            InitializeComponent();
            comboBoxFilterAccountType.Items.AddRange(new object[] { "Administrator", "Manager", "Receptionist" });
            LoadData();
        }

        public void LoadData()
        {
            // Clear the existing nodes
           
            // Load the updated data from the database
            using (var context = new DataContext())
            {
                var users = context.Users.ToList();

                // Populate the TreeView with the updated data
                var userData = users.Select(u => new
                {
                    u.UserName,
                    u.AccountType
                }).ToList();
                gridAccount.Columns.Clear();
                gridAccount.DataSource = userData;

                gridAccount.Columns["UserName"].HeaderText = "Username";
                gridAccount.Columns["AccountType"].HeaderText = "Account Type";

            }
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
            ColumnAccountType.ReadOnly = false;
        }

        private void buttonExitEditAccounts_Click(object sender, EventArgs e)
        {
            buttonSaveEditAccounts.Visible = false;
            buttonExitEditAccounts.Visible = false;
            ColumnAccountType.ReadOnly = true;
        }

        private void buttonSaveEditAccounts_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonSaveEditAccounts.Visible = false;
            buttonExitEditAccounts.Visible = false;
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
            CreateAccount createAcc = new CreateAccount(this);
            createAcc.FormClosed += (s, args) =>
            {
                LoadData();
            };
            createAcc.Show();

        }
    }
}
