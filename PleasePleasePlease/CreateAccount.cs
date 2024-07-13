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
        public List<User> DatabaseUser { get; set; }
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

        public void ResetErrorLabels()
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

        private void CreateNewUser(string username, string password, string accountType)
        {
            using (DataContext context = new DataContext())
            {
                var newUser = new User
                {
                    UserName = username,
                    Password = password,
                    AccountType = accountType
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

        private void createAcc_btn_Click(object sender, EventArgs e)
        {
            ResetErrorLabels();

            string username = username_txt.Text;
            string password = password_txt.Text;
            string confirmPass = conPass_txt.Text;
            string accountType = comboAccType.Text;

            if (CheckUsernameExistence(username))
            {
                labelErrorUsername.Visible = true;
            }
            else if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match");
                labelErrorPassword.Visible = true;
            }
            else
            {
                try
                {
                    CreateNewUser(username, password, accountType);
                    MessageBox.Show("Account created successfully");
                    _Accounts.LoadData(); // Refresh the TreeView
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while creating the account: {ex.Message}");
                }
            }
        }
    }
}
