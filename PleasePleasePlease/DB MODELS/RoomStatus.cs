using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class RoomStatus
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Room Status ID")]                 // DataAnnotations attribute: specifies this property as the key
        public string RoomStatusID { get; set; }     // Property for storing User ID}

        [Name("Room Status")]
        public string RoomStatusName { get; set; }

        public virtual ObservableCollectionListSource<Room> Rooms { get; } = new();
    }
}