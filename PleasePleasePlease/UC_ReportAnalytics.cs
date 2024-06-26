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
    public partial class UC_ReportAnalytics : UserControl
    {
        public UC_ReportAnalytics()
        {
            InitializeComponent();
        }

        private void ButtonGuestDemo_Click(object sender, EventArgs e)
        {
            Details_GuestDemographics guestDemo = new Details_GuestDemographics();
            guestDemo.Show();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }
    }
}
