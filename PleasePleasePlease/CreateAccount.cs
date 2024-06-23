using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            comboBoxAccountType.Items.AddRange(new object[] { "Administrator", "Manager", "Receptionist" });
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // CONDITION FOR CREATING ACCOUNT
            /*if (username already in the system)
            {
                labelErrorUsername.Visible = true;
                textBoxUsername.Clear();
            }
            else if (textBoxPassword != textBoxConfirmPassword)
            {
                labelErrorPassword.Visible = true;
            }
            else if (account already exist)
            {
                labelErrorAccountExist.Visible = true;
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();
                comboBoxAccountType.SelectedIndex = -1;
            }
            else 
            { 
                // Add Account to Database code starts here

                LoginPage login = new LoginPage();
                this.Hide();
                login.Show();
            }*/
            Dialogue_AccAdded addAccConfirm = new Dialogue_AccAdded();
            this.Hide();
            addAccConfirm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }
    }
}
