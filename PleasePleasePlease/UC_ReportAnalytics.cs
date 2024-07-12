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
            ComboBoxRevenue.Items.AddRange(new object[] { "Yearly", "Monthly", "Weekly" });
            ComboBoxRevenue.SelectedIndexChanged += ComboBoxRevenue_SelectedIndexChanged;
            ComboBoxRevenue.SelectedIndex = 0;
            loadata();
            loadOccupancy();


        }

        private void ButtonGuestDemo_Click(object sender, EventArgs e)
        {
            Details_GuestDemographics guestDemo = new Details_GuestDemographics();
            guestDemo.Show();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadata();
        }

        private void loadata()
        {
            gunaChart1.Datasets.Clear();

            switch (ComboBoxRevenue.SelectedIndex)
            {
                case 0: // Yearly
                    RevenueChartYear.Example(gunaChart1);
                    break;

                case 1: // Monthly
                    RevenueChartMonth.Example(gunaChart1);
                    break;

                case 2: // Weekly
                    RevenueChartCustomWeek.Example(gunaChart1);
                    break;
            }

            gunaChart1.Update();
        }

        private void loadOccupancy()
        {
            using (var context = new DataContext())
            {
                var calculator = new RoomOccupancyCalculator(context);
                decimal standardRoomOccupancy = calculator.CalculateStandardRoomOccupancyPercentage();
                label100.Text = $"{standardRoomOccupancy}%";
            }
        }
    }
}