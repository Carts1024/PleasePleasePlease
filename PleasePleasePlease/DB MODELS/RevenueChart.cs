using System;
using System.Linq;
using System.Drawing;
using Guna.Charts.WinForms;
using Microsoft.EntityFrameworkCore;

namespace Mirai_Paradise_Hotel
{
    class RevenueChartYear
    {
        public static void Example(GunaChart chart)
        {
            // Retrieve data from the database
            var monthlyRevenues = GetMonthlyRevenues();

            // Chart configuration 
            chart.YAxes.GridLines.Display = false;

            // Create a new dataset 
            var dataset = new GunaSplineAreaDataset
            {
                Label = "Revenue", // Set the label to "Revenue"
                PointRadius = 3,
                PointStyle = PointStyle.Circle,
                FillColor = Color.White,
                BorderColor = Color.White,
            };

            foreach (var monthRevenue in monthlyRevenues)
            {
                dataset.DataPoints.Add(monthRevenue.Month, monthRevenue.Revenue);
            }

            // Add a new dataset to the chart's Datasets
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }

        // Method to retrieve monthly revenues from the database
        private static (string Month, int Revenue)[] GetMonthlyRevenues()
        {
            using (var context = new DataContext())
            {
                var startDate = DateTime.Now.AddMonths(-11); // 11 months ago (to include the current month)
                var endDate = DateTime.Now; // today

                var monthlyRevenues = context.Invoices
                    .Where(i => i.IssueDate >= startDate && i.IssueDate <= endDate) // Filter for the last 12 months
                    .GroupBy(i => new { i.IssueDate.Year, i.IssueDate.Month })
                    .Select(g => new
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        Revenue = g.Sum(i => (int)i.TotalAmount)
                    })
                    .ToList();

                // Create a complete list of months in the range with zero revenue by default
                var completeMonthlyRevenues = Enumerable.Range(0, 12)
                    .Select(i => startDate.AddMonths(i))
                    .Select(date => new
                    {
                        Year = date.Year,
                        Month = date.Month,
                        Revenue = monthlyRevenues
                            .FirstOrDefault(m => m.Year == date.Year && m.Month == date.Month)?.Revenue ?? 0
                    })
                    .OrderBy(m => new DateTime(m.Year, m.Month, 1))
                    .Select(m => (
                        Month: new DateTime(m.Year, m.Month, 1).ToString("MMMM yyyy"),
                        Revenue: m.Revenue
                    ))
                    .ToArray();

                return completeMonthlyRevenues;
            }
        }
    }

    class RevenueChartMonth
    {
        public static void Example(GunaChart chart)
        {
            // Retrieve data from the database
            var dailyRevenues = GetDailyRevenues();

            // Chart configuration 
            chart.YAxes.GridLines.Display = false;

            // Create a new dataset 
            var dataset = new GunaSplineAreaDataset
            {
                Label = "Revenue", // Set the label to "Revenue"
                PointRadius = 3,
                PointStyle = PointStyle.Circle,
                FillColor = Color.White,
                BorderColor = Color.White,
            };

            foreach (var dailyRevenue in dailyRevenues)
            {
                dataset.DataPoints.Add(dailyRevenue.Date, dailyRevenue.Revenue);
            }

            // Add a new dataset to the chart's Datasets
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }

        // Method to retrieve daily revenues for the current month from the database
        private static (string Date, int Revenue)[] GetDailyRevenues()
        {
            using (var context = new DataContext())
            {
                var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1); // Last day of the current month

                var dailyRevenues = context.Invoices
                    .Where(i => i.IssueDate >= startDate && i.IssueDate <= endDate) // Filter for the current month
                    .GroupBy(i => i.IssueDate.Day)
                    .Select(g => new
                    {
                        Day = g.Key,
                        Revenue = g.Sum(i => (int)i.TotalAmount)
                    })
                    .ToList();

                // Create a complete list of days in the current month with zero revenue by default
                var completeDailyRevenues = Enumerable.Range(1, endDate.Day)
                    .Select(day => new
                    {
                        Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day).ToString("dd MMM yyyy"),
                        Revenue = dailyRevenues
                            .FirstOrDefault(d => d.Day == day)?.Revenue ?? 0
                    })
                    .Select(d => (
                        Date: d.Date,
                        Revenue: d.Revenue
                    ))
                    .ToArray();

                return completeDailyRevenues;
            }
        }
    }
    class RevenueChartCustomWeek
    {
        public static void Example(GunaChart chart)
        {
            // Retrieve data from the database
            var customWeekRevenues = GetCustomWeekRevenues();

            // Chart configuration 
            chart.YAxes.GridLines.Display = false;

            // Create a new dataset 
            var dataset = new GunaSplineAreaDataset
            {
                Label = "Revenue", // Set the label to "Revenue"
                PointRadius = 3,
                PointStyle = PointStyle.Circle,
                FillColor = Color.White,
                BorderColor = Color.White,
            };

            foreach (var dailyRevenue in customWeekRevenues)
            {
                dataset.DataPoints.Add(dailyRevenue.Date, dailyRevenue.Revenue);
            }

            // Add a new dataset to the chart's Datasets
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }

        // Method to retrieve daily revenues from today up to the same day last week
        private static (string Date, int Revenue)[] GetCustomWeekRevenues()
        {
            using (var context = new DataContext())
            {
                var endDate = DateTime.Now.Date; // Today
                var startDate = endDate.AddDays(-7); // Same day last week

                var dailyRevenues = context.Invoices
                    .Where(i => i.IssueDate >= startDate && i.IssueDate <= endDate) // Filter for the last week
                    .GroupBy(i => i.IssueDate.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        Revenue = g.Sum(i => (int)i.TotalAmount)
                    })
                    .ToList();

                // Create a complete list of days in the custom range with zero revenue by default
                var completeDailyRevenues = Enumerable.Range(0, 8)
                    .Select(i => startDate.AddDays(i))
                    .Select(date => new
                    {
                        Date = date.ToString("dd MMM yyyy"),
                        Revenue = dailyRevenues
                            .FirstOrDefault(d => d.Date == date)?.Revenue ?? 0
                    })
                    .Select(d => (
                        Date: d.Date,
                        Revenue: d.Revenue
                    ))
                    .ToArray();

                return completeDailyRevenues;
            }
        }
    }
}
