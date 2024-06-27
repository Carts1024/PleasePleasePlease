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
    public partial class Welcome : Form
    {
        private User currentUser;
        public Welcome(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }
    }
}
