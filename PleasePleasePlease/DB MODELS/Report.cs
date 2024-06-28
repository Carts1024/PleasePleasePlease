using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Report
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Report ID")]                 // DataAnnotations attribute: specifies this property as the key
        public int ReportID { get; set; }     // Property for storing User ID}

        [Name("Occupancy Rate")]
        public decimal OccupancyRates { get; set; }

        [Name("Revenue")]
        public decimal Revenue { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
    }
}