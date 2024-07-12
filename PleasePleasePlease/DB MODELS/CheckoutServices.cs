using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Mirai_Paradise_Hotel
{
    public class CheckoutService
    {
        private readonly DataContext _context;

        public CheckoutService(DataContext context)
        {
            _context = context;
        }

        public void Checkout(int bookingId)
        {
            var booking = _context.Bookings
                .Include(b => b.Room)
                .Include(b => b.Guest)
                .FirstOrDefault(b => b.BookingID == bookingId);

            if (booking == null)
            {
                throw new Exception("Booking not found.");
            }

            // Generate and save the invoice
            var billingService = new BillingService(_context);
            var invoice = billingService.GenerateInvoice(bookingId, "GradButtonCheckOut_Click");
            billingService.SaveInvoice(invoice, $"Invoice_{bookingId}.pdf");

            // Update booking status to 'Checked Out'
            booking.BookingStatus = "Check-Out";

            // Update room status to 'Available'
            booking.Room.RoomStatus = "Available";

            // Save changes to the database
            _context.SaveChanges();
        }
    }
}
