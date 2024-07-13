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
    public  partial class ForgotPass : Form
    {
        public List<User> DatabaseUser { get; set; }
   
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string username = username_txt.Text;
            string newPass = newPass_txt.Text;
            string confirmPass = conPass_txt.Text;

            using (DataContext context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == username);
                if (user == null)
                {
                    lblErrorResetPass.Text = "Username not found.";
                    lblErrorResetPass.Visible = true;
                    return;
                }

                if (newPass != confirmPass)
                {
                    lblErrorResetPass.Text = "Passwords do not match.";
                    lblErrorResetPass.Visible = true;
                    conPass_txt.Clear();
                }
                else
                {
                    // Update the password in the database using the username
                    user.Password = newPass;
                    context.SaveChanges();

                    // Navigate back to the LoginPage after successful password reset
                    LoginPage login = new LoginPage();
                    this.Hide();
                    login.Show();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }
    }
}
