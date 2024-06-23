using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Booking
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Booking Id")]                 // DataAnnotations attribute: specifies this property as the key
        public int BookingtID { get; set; }     // Property for storing User ID

        [Name("Check In Date")]
        public DateTime CheckInDate { get; set; }

        [Name("Check In Time")]
        public DateTime CheckInTime { get; set; }

        [Name("Check Out Date")]
        public DateTime CheckOutDate { get; set; }

        [Name("Check Out Time")]
        public DateTime CheckOutTime { get; set; }

        [Name("Guest Id")]
        public int GuestID { get; set; }

        [Name("Room Number")]
        public int RoomNumber { get; set; }

        public virtual Guest Guests { get; set; } = null!;



    }
}
