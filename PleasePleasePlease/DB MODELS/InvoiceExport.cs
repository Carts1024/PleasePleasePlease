using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

public class InvoiceExport
{
    [Name("Index")]
    public int Index { get; set; }

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

    [Name("Guest Id")]
    public int GuestID { get; set; } 

    [Name("Booking Id")]
    public int BookingID { get; set; } 
}
