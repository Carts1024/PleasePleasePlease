using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;
using System.ComponentModel.DataAnnotations;


namespace Mirai_Paradise_Hotel
{
    public class Booking
    {
        [Name("Index")]
        public int Index { get; set; }

        [Key, Name("Booking Id")]
        public int BookingID { get; set; }

        [Name("Check In Date")]
        public DateTime CheckInDate { get; set; }

        [Name("Check In Time")]
        public TimeSpan CheckInTime { get; set; }

        [Name("Check Out Date")]
        public DateTime CheckOutDate { get; set; }

        [Name("Check Out Time")]
        public TimeSpan CheckOutTime { get; set; }

        [Name("Booking Status")]
        public string BookingStatus { get; set; }

        [Name("Guest Id")]
        public int GuestID { get; set; }

        [Name("Room Number")]
        public int RoomNumber { get; set; }

     //   [Name("Is Deleted")]
   //     public bool IsDeleted { get; set; } // Soft delete property

        public virtual Guest Guest { get; set; } = null!;
        public virtual Room Room { get; set; } = null!;

        
    }

    public class BookingMap : ClassMap<Booking>
    {
        public BookingMap()
        {
            Map(m => m.Index).Name("Index");
            Map(m => m.BookingID).Name("Booking Id");
            Map(m => m.CheckInDate).Name("Check In Date");
            Map(m => m.CheckInTime).Name("Check In Time");
            Map(m => m.CheckOutDate).Name("Check Out Date");
            Map(m => m.CheckOutTime).Name("Check Out Time");
            Map(m => m.BookingStatus).Name("Booking Status");
            Map(m => m.GuestID).Name("Guest Id");
            Map(m => m.RoomNumber).Name("Room Number");
    //        Map(m => m.IsDeleted).Name("Is Deleted");
        }
    }
}
