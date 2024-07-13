using System;
using System.Linq;
using System.Drawing;
using Guna.Charts.WinForms;
using Microsoft.EntityFrameworkCore;

namespace Mirai_Paradise_Hotel
{
    class OccupancyChartAllRooms
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart, RoomOccupancyCalculator calculator)
        {
            // Retrieve occupancy rates
            int allRoomsOccupancy = calculator.CalculateRoomOccupancyPercentage();
            int allRoomsAvailable = calculator.CalculateRoomAvailablePercentage();
            int allRoomsMaintenance = calculator.CalculateRoomMaintenancePercentage();

            // Chart configuration
            chart.Title.Text = "All Room Occupancy Rates";
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();
            dataset.Label = "All Rooms Occupancy";

            // Add data points
            dataset.DataPoints.Add("Occupied Rooms", allRoomsOccupancy);
            dataset.DataPoints.Add("Available Rooms", allRoomsAvailable);
            dataset.DataPoints.Add("Under Maintenance Rooms", allRoomsMaintenance);



            // Add the dataset to the chart
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }
    }

    class OccupancyChartStandardRooms
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart, RoomOccupancyCalculator calculator)
        {
            // Retrieve occupancy rates
            int standardRoomsOccupancy = calculator.CalculateStandardRoomOccupancyPercentage();
            int standardRoomsAvailable = calculator.CalculateStandardRoomAvailablePercentage();
            int standardRoomsMaintenance = calculator.CalculateStandardRoomMaintenancePercentage();

            // Chart configuration
            chart.Title.Text = "Standard Room Occupancy Rates";
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();
            dataset.Label = "Standard Room Occupancy";

            // Add data points
            dataset.DataPoints.Add("Occupied Rooms", standardRoomsOccupancy);
            dataset.DataPoints.Add("Available Rooms", standardRoomsAvailable);
            dataset.DataPoints.Add("Under Maintenance Rooms", standardRoomsMaintenance);



            // Add the dataset to the chart
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }
    }

    class OccupancyChartDeluxeRooms
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart, RoomOccupancyCalculator calculator)
        {
            // Retrieve occupancy rates
            int deluxeRoomsOccupancy = calculator.CalculateDeluxeRoomOccupancyPercentage();
            int deluxedRoomsAvailable = calculator.CalculateDeluxeRoomAvailablePercentage();
            int deluxeRoomsMaintenance = calculator.CalculateDeluxeRoomMaintenancePercentage();

            // Chart configuration
            chart.Title.Text = "Deluxe Room Occupancy Rates";
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();
            dataset.Label = "Deluxe Room Occupancy";

            // Add data points
            dataset.DataPoints.Add("Occupied Rooms", deluxeRoomsOccupancy);
            dataset.DataPoints.Add("Available Rooms", deluxedRoomsAvailable);
            dataset.DataPoints.Add("Under Maintenance Rooms", deluxeRoomsMaintenance);



            // Add the dataset to the chart
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }
    }

    class OccupancyChartSuiteRooms
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart, RoomOccupancyCalculator calculator)
        {
            // Retrieve occupancy rates
            int suiteRoomsOccupancy = calculator.CalculateSuiteOccupancyPercentage();
            int suiteRoomsAvailable = calculator.CalculateSuiteAvailablePercentage();
            int suiteRoomsMaintenance = calculator.CalculateSuiteMaintenancePercentage();

            // Chart configuration
            chart.Title.Text = "Suite Occupancy Rates";
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();
            dataset.Label = "Suite Occupancy";

            // Add data points
            dataset.DataPoints.Add("Occupied Rooms", suiteRoomsOccupancy);
            dataset.DataPoints.Add("Available Rooms", suiteRoomsAvailable);
            dataset.DataPoints.Add("Under Maintenance Rooms", suiteRoomsMaintenance);



            // Add the dataset to the chart
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }
    }
}
