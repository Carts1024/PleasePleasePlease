using CsvHelper.Configuration.Attributes; // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation
using System.ComponentModel.DataAnnotations.Schema;

namespace Mirai_Paradise_Hotel
{
    public class InvoiceModel
    {
        [Name("Index")]
        public int Index { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Name("Invoice Number")]
        public int InvoiceNumber { get; set; }

        [Name("Issue Date")]
        public DateTime IssueDate { get; set; }

        [Name("Due Date")]
        public DateTime DueDate { get; set; }

        [Name("Payment Status")]
        public string PaymentStatus { get; set; }

        [Name("Payment Method")]
        public string PaymentMethod { get; set; }

        [Name("Total Amount")]
        public decimal TotalAmount { get; set; }

        [Name("Comments")]
        public string Comments { get; set; }

        [ForeignKey("Guest")]
        [Name("Guest Id")]
        public int GuestID { get; set; } // Changed to int to match the GuestID type

        [ForeignKey("Booking")]
        [Name("Booking Id")]
        public int BookingID { get; set; } // Changed to int to match the GuestID type

        public List<OrderItem> Items { get; set; }

        public virtual Booking Booking { get; set; } = null!;

        public virtual Guest Guest { get; set; } = null!;
    }

    public class OrderItem
    {
        [NotMapped]
        public int OrderItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
