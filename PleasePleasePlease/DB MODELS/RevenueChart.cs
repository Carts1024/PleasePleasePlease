using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class SplineArea
    {
        public static void Example(GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] values = { 4500, 6700, 3400, 7800, 5600, 8000, 1000, 5000, 10000, 2000, 5000, 3000 }; // Predefined values for each month

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

            for (int i = 0; i < months.Length; i++)
            {
                // Use predefined values instead of random numbers
                dataset.DataPoints.Add(months[i], values[i]);
            }

            // Add a new dataset to the chart's Datasets
            chart.Datasets.Add(dataset);

            // An update was made to re-render the chart
            chart.Update();
        }
    }
}
