using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Booking
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Booking Id")]                 // DataAnnotations attribute: specifies this property as the key
        public Guid BookingID { get; set; }     // Property for storing User ID

        [Name("Check In Date")]
        public DateTime CheckInDate { get; set; }

        [Name("Check In Time")]
        public TimeSpan CheckInTime { get; set; }

        [Name("Check Out Date")]
        public DateTime CheckOutDate { get; set; }

        [Name("Check Out Time")]
        public TimeSpan CheckOutTime { get; set; }

        [Name("Guest Id")]
        public int GuestID { get; set; }

        [Name("Room Number")]
        public int RoomNumber { get; set; }

        [ForeignKey("GuestID")]
        public virtual Guest Guest{ get; set; } = null!;
        [ForeignKey("RoomNumber")]
        public virtual Room Room { get; set; } = null!;
    }
}