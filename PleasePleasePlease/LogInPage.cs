using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class LoginPage : Form
    {
      //  private User currentUser;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Initialize the database context
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            // Uncomment to ensure the database is deleted and recreated on every load
            //facade.EnsureDeleted();
            facade.EnsureCreated();
        }

        public LoginPage()
        {
            InitializeComponent();
        //    this.currentUser = user;
            this.FormClosed += LoginPage_FormClosed;
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass fp = new ForgotPass();
            this.Hide();
            fp.Show();
            fp.FormClosed += (s, args) => this.Show(); // Show the login page again when the forgot password form is closed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Text;

            using (DataContext context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == Username && u.Password == Password);
                if (user != null)
                {
                    lblErrorCredentials.Visible = false;

                    // Update the currentUser properties with the logged-in user's details
                    UserSession.CurrentUser = user;

                    Dashboard ds = new Dashboard();
                    this.Hide();
                    ds.Show();
                    ds.FormClosed += (s, args) => this.Show(); // Show the login page again when the dashboard form is closed
                }
                else
                {
                    lblErrorCredentials.Visible = true;
                    txtPassword.Clear();
                }
            }
        }
    }
}
