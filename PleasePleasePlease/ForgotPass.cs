using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ForgotPass : Form
    {
  //      private User currentUser;
        public ForgotPass()
        {
            InitializeComponent();
     //       this.currentUser = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                lblErrorResetPass.Visible = true;
                txtConfirmPass.Clear();
            }
            else
            {
                //CONDITION KAPAG SUCCESSFULLY NAPALITAN YUNG PASSWORD
                //BALE UPDATE NA TO SA DATABASE
                LoginPage login = new LoginPage();
                this.Hide();
                login.Show();
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
