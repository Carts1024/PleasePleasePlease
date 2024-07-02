using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Room
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }

        [Key, Name("Room Number")]                 // DataAnnotations attribute: specifies this property as the key
        public int RoomNumber { get; set; }     // Property for storing User ID}

        [Name("Room Status")]
        public string RoomStatus { get; set; }

        [Name("Room Type")]
        public string RoomType { get; set; }

        [Name("Room Price")]
        public decimal RoomPrice { get; set; }

        [Name("Floor Number")]
        public int FloorNumber { get; set; }

        public virtual ObservableCollectionListSource<Booking> Bookingss { get; } = new();
    }

    public class StandardRoom : Room
    {
        [Name("Bed Type")]
        public string BedType { get; set; }
        [Name("Capacity")]
        public int Capacity { get; set; }
    }

    public class DeluxeRoom : Room
    {
        [Name("Bed Type")]
        public string BedType { get; set; }

        [Name("Capacity")]
        public int Capacity { get; set; }
  //      public bool Minibar { get; set; }
    }

    public class Suite : Room
    {
        [Name("Bed Type")]
        public string BedType { get; set; }

        [Name("Capacity")]
        public int Capacity { get; set; }
      //  public bool LivingRoom { get; set; }
    }
}
