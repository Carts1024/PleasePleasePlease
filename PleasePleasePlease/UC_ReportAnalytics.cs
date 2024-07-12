using Guna.Charts.WinForms;
using Mirai_Paradise_Hotel;
using System;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_ReportAnalytics : UserControl
    {
        private GunaChart gunaChart;

        public UC_ReportAnalytics()
        {
            InitializeComponent();
            loadata();
            
        }

        private void ButtonGuestDemo_Click(object sender, EventArgs e)
        {
            Details_GuestDemographics guestDemo = new Details_GuestDemographics();
            guestDemo.Show();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void loadata()
        {
            gunaChart1.Datasets.Clear();
            BasicExamples.SplineArea.Example(gunaChart1);
        }
    }
}
