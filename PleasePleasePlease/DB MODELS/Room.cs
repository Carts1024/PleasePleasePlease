using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Room
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Room Number")]                 // DataAnnotations attribute: specifies this property as the key
        public int RoomNumber { get; set; }     // Property for storing User ID}

        [Name("Room Type")]
        public String RoomType { get; set; }

        [Name("Room Status")]
        public int RoomStatus { get; set; }

        [Name("Room Price")]
        public decimal RoomPrice { get; set; }

        [Name("Floor Number")]
        public int FloorNumber { get; set; }

        [Name("Capacity")]
        public int Capacity { get; set; }

        public virtual ObservableCollectionListSource<Booking> Bookingss { get; } = new();
    }
}