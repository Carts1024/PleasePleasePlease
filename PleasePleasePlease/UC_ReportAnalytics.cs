using Guna.Charts.WinForms;
using Mirai_Paradise_Hotel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_ReportAnalytics : UserControl
    {
        private GunaChart gunaChart;
        private readonly DataContext _context;

        public UC_ReportAnalytics()
        {
            InitializeComponent();
            _context = new DataContext(); // Initialize the _context here

            InitializeComboBoxes();
            RegisterComboBoxEventHandlers();

            LoadInitialData();
        }

        private void InitializeComboBoxes()
        {
            ComboBoxRevenue.Items.AddRange(new object[] { "Yearly", "Monthly", "Weekly" });
            ComboBoxOccupancy.Items.AddRange(new object[] { "All Rooms", "Standard Room", "Deluxe Room", "Suite" });

            ComboBoxOccupancy.SelectedIndex = 0;
            ComboBoxRevenue.SelectedIndex = 0;
        }

        private void RegisterComboBoxEventHandlers()
        {
            ComboBoxOccupancy.SelectedIndexChanged += ComboBoxOccupancy_SelectedIndexChanged;
            ComboBoxRevenue.SelectedIndexChanged += ComboBoxRevenue_SelectedIndexChanged;
        }

        private void LoadInitialData()
        {
            LoadRevenueData();
            LoadOccupancyData();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            label5.Text = CalculateRoomCount();
            Bookings.Text = CalculateBookingCount();
            labelCheckIn.Text = CalculateCheckInCount();
            labelCheckOut.Text = CalculateOccupiedCount();
            label15.Text = CalculateStandardRoomAvailableCount();
            label13.Text = CalculateDeluxeRoomAvailableCount();
            label11.Text = CalculateSuiteAvailableCount();
        }

        private void ButtonGuestDemo_Click(object sender, EventArgs e)
        {
            Details_GuestDemographics guestDemo = new Details_GuestDemographics();
            guestDemo.Show();
        }

        private void ComboBoxOccupancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOccupancyData();
        }

        private void ComboBoxRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private string CalculateRoomCount()
        {
            return _context.Set<Room>().Count().ToString();
        }

        private string CalculateRoomAvailableCount()
        {
            return _context.Set<Room>().Count(room => room.RoomStatus == "Available").ToString();
        }

        private string CalculateStandardRoomAvailableCount()
        {
            return _context.Set<StandardRoom>().Count(room => room.RoomStatus == "Available").ToString();
        }

        private string CalculateDeluxeRoomAvailableCount()
        {
            return _context.Set<DeluxeRoom>().Count(room => room.RoomStatus == "Available").ToString();
        }

        private string CalculateSuiteAvailableCount()
        {
            return _context.Set<Suite>().Count(room => room.RoomStatus == "Available").ToString();
        }

        private string CalculateBookingCount()
        {
            return _context.Set<Booking>().Count().ToString();
        }

        private string CalculateCheckInCount()
        {
            return _context.Set<Booking>().Count(booking => booking.BookingStatus == "Checked-In").ToString();
        }

        private string CalculateOccupiedCount()
        {
            return _context.Set<Room>().Count(room => room.RoomStatus == "Occupied").ToString();
        }

        private void LoadRevenueData()
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

        private void LoadOccupancyData()
        {
            gunaChart3.Datasets.Clear();
            var calculator = new RoomOccupancyCalculator(_context);

            int roomOccupancy = calculator.CalculateRoomOccupancyPercentage();
            int standardRoomOccupancy = calculator.CalculateStandardRoomOccupancyPercentage();
            int deluxeRoomOccupancy = calculator.CalculateDeluxeRoomOccupancyPercentage();
            int suiteOccupancy = calculator.CalculateSuiteOccupancyPercentage();

            UpdateOccupancyLabels(roomOccupancy, standardRoomOccupancy, deluxeRoomOccupancy, suiteOccupancy);

            switch (ComboBoxOccupancy.SelectedIndex)
            {
                case 0:
                    OccupancyChartAllRooms.Example(gunaChart3, calculator);
                    break;

                case 1:
                    OccupancyChartStandardRooms.Example(gunaChart3, calculator);
                    break;

                case 2:
                    OccupancyChartDeluxeRooms.Example(gunaChart3, calculator);
                    break;

                case 3:
                    OccupancyChartSuiteRooms.Example(gunaChart3, calculator);
                    break;
            }

            gunaChart3.Update();
        }

        private void UpdateOccupancyLabels(int roomOccupancy, int standardRoomOccupancy, int deluxeRoomOccupancy, int suiteOccupancy)
        {
            label100.Text = $"{roomOccupancy}%";
            labelOccupancyRate.Text = $"{roomOccupancy}%";

            switch (ComboBoxOccupancy.SelectedIndex)
            {
                case 0:
                    label100.Text = $"{roomOccupancy}%";
                    break;

                case 1:
                    label100.Text = $"{standardRoomOccupancy}%";
                    break;

                case 2:
                    label100.Text = $"{deluxeRoomOccupancy}%";
                    break;

                case 3:
                    label100.Text = $"{suiteOccupancy}%";
                    break;
            }
        }
    }
}
