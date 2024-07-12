using Microsoft.EntityFrameworkCore;
using PleasePleasePlease;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class CreateAccount : Form
    {
        private UC_Accounts _Accounts;
        // Constructor
        public CreateAccount(UC_Accounts accounts)
        {
            InitializeComponent();
            _Accounts = accounts;
            comboAccType.Items.AddRange(new object[] { "Administrator", "Manager", "Receptionist" });
            InitializeDataGridView(); // Initialize DataGridView
             // Load accounts on initialization
        }

        private void InitializeDataGridView()
        {
            dataGridViewAccounts = new DataGridView
            {
                Location = new System.Drawing.Point(12, 150), // Adjust location as needed
                Size = new System.Drawing.Size(400, 200), // Adjust size as needed
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dataGridViewAccounts);
        }


        private void ResetErrorLabels()
        {
            labelErrorAccountExist.Visible = false;
            labelErrorPassword.Visible = false;
            labelErrorUsername.Visible = false;
        }

        public static bool CheckUsernameExistence(string usernameInput)
        {
            using (var context = new DataContext())
            {
                return context.Users.Any(u => u.UserName == usernameInput);
            }
        }

        private void CreateNewUser(string username, string password)
        {
            using (var context = new DataContext())
            {
                var newUser = new User
                {
                    UserName = username,
                    Password = password, // Hashing the password before saving
                    AccountType = comboAccType.Text
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }





        private void buttonBack_Click(object sender, EventArgs e)
        {
            _Accounts.LoadData(); // Refresh the TreeView

            this.Hide();
        }
    }
}
