using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Invoice
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Invoice Number")]                 // DataAnnotations attribute: specifies this property as the key
        public int InvoiceNumber { get; set; }     // Property for storing User ID}

        [Name("Issue Date")]
        public DateTime IssueDate { get; set; }

        [Name("Due Date")]
        public DateTime DueDate { get; set; }

        [Name("Payment Status")]
        public string PaymentStatus { get; set; }

        [Name("Payment Method")]
        public int PaymentMethod { get; set; }

        [Name("Total Amount")]
        public decimal TotalAmount { get; set; }

        public virtual Booking Booking { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
