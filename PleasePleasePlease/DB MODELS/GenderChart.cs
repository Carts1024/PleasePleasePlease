using System;
using System.Collections.Generic;
using Guna.Charts.WinForms;
using Mirai_Paradise_Hotel;  // Namespace where your Guest class and GuestDataProcessor are defined

namespace BasicExamples
{
    class Pie
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart, IEnumerable<Guest> guests)
        {
           /* // Retrieve gender counts
            var genderCounts = GuestDataProcessor.GetGenderCounts(guests);

            // Chart configuration  
            chart.Legend.Position = LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            // Create a new dataset 
            var dataset = new GunaPieDataset();

            foreach (var genderCount in genderCounts)
            {
                dataset.DataPoints.Add(genderCount.Key, genderCount.Value);
            }

            // Add the dataset to the chart
            chart.Datasets.Add(dataset);

            // Update the chart to re-render
            chart.Update();*/
        }
    }
}
