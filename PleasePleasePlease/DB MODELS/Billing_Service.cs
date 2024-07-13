using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirai_Paradise_Hotel
{
    public class BillingService
    {
        private readonly DataContext _context;

        public BillingService(DataContext context)
        {
            _context = context;
        }

        public InvoiceModel GenerateInvoice(int bookingId, string eventType)
        {
            var booking = _context.Bookings
                .Include(b => b.Room)
                .Include(b => b.Guest)
                .FirstOrDefault(b => b.BookingID == bookingId);

            if (booking == null)
            {
                throw new Exception("Booking not found.");
            }

            var guest = booking.Guest;
            if (guest == null)
            {
                throw new Exception("Guest not found.");
            }

            var paymentStatus = eventType switch
            {
                "ButtonGenerateInvo_Click" => "Pending",
                "GradButtonCheckOut_Click" => "Paid",
                _ => "Pending"
            };

            // Log the booking and guest details
            Console.WriteLine($"BookingID: {bookingId}, GuestID: {guest.GuestID}");

            // Debugging: Check all invoices in the database
            var allInvoices = _context.Invoices.ToList();
            Console.WriteLine("All Invoices in the Database:");
            foreach (var invoice in allInvoices)
            {
                Console.WriteLine($"InvoiceID: {invoice.InvoiceNumber}, BookingID: {invoice.BookingID}, GuestID: {invoice.GuestID}, PaymentStatus: {invoice.PaymentStatus}");
            }

            // Check for existing invoice with the same booking ID and guest ID
            var existingInvoice = _context.Invoices
                .Include(i => i.Items) // Include items to ensure they are tracked
                .FirstOrDefault(i => i.BookingID == bookingId && i.GuestID == guest.GuestID);

            if (existingInvoice == null)
            {
                // Log if no existing invoice is found
                Console.WriteLine("No existing invoice found. Creating a new one.");
                existingInvoice = new InvoiceModel
                {
                    BookingID = booking.BookingID,
                    GuestID = guest.GuestID,
                    Booking = booking,
                    Guest = guest,
                    Items = new List<OrderItem>()
                };
                _context.Invoices.Add(existingInvoice);
            }
            else
            {
                // Log if an existing invoice is found
                Console.WriteLine($"Existing Invoice ID: {existingInvoice.InvoiceNumber} found. Updating it.");

                // Ensure items list is initialized
                if (existingInvoice.Items == null)
                {
                    existingInvoice.Items = new List<OrderItem>();
                }

                // Attach the existing invoice if it is not being tracked
                if (!_context.Invoices.Local.Any(i => i.InvoiceNumber == existingInvoice.InvoiceNumber))
                {
                    _context.Invoices.Attach(existingInvoice);
                }
            }

            // Update the invoice details
            existingInvoice.IssueDate = DateTime.Now;
            existingInvoice.DueDate = DateTime.Now.AddDays(30);
            existingInvoice.PaymentStatus = paymentStatus;
            existingInvoice.PaymentMethod = "Cash";
            existingInvoice.TotalAmount = CalculateTotalAmount(booking);
            existingInvoice.Comments = "Thank you for staying with us!";
            existingInvoice.Items.Clear();
            existingInvoice.Items.Add(new OrderItem { Name = "Room Charge", Price = booking.Room.RoomPrice, Quantity = (booking.CheckOutDate - booking.CheckInDate).Days });
            // Add more items if needed

            // Save changes to the database
            _context.SaveChanges();

            return existingInvoice;
        }

        private decimal CalculateTotalAmount(Booking booking)
        {
            // Assuming room price is per night, calculate total amount for the booking duration
            var nights = (booking.CheckOutDate - booking.CheckInDate).Days;
            return booking.Room.RoomPrice * nights;
        }

        public void SaveInvoice(InvoiceModel invoice, string filePath)
        {
            var document = new InvoiceDocument(invoice, invoice.Guest);
            document.GeneratePdfAndShow();
        }

        public void SaveQuotation(InvoiceModel invoice, string filePath)
        {
            var document = new QuotationDocument(invoice, invoice.Guest);
            document.GeneratePdfAndShow();
        }
    }
}
