using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class Details_BookingHistory : Form
    {
        public List<Booking> DatabaseBookings { get; private set; }

        public Details_BookingHistory()
        {
            InitializeComponent();
            GridRead();
        }

        public void GridRead()
        {
            using (DataContext context = new DataContext())
            {
                // Retrieve bookings from the database including related guest data
                DatabaseBookings = context.Bookings
                                          .Include(b => b.Guest)
                                          .OrderBy(u => u.Index)
                                          .ToList();

                // Display the bookings in the DataGridView
                dataGridViewBookingHistory.DataSource = DatabaseBookings.Select(b => new
                {
                    GuestName = $"{b.Guest.FirstName} {b.Guest.LastName}", // Combine guest's first and last name
                    b.RoomNumber,
                    b.CheckInDate,
                    b.CheckInTime,
                    b.CheckOutDate,
                    b.CheckOutTime
                }).ToList();
            }
        }
    }
}