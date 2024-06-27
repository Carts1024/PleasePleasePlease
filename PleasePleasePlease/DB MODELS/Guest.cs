using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.Numerics; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class Guest
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("Guest Id")]                 // DataAnnotations attribute: specifies this property as the key
        public int GuestID { get; set; }     // Property for storing User ID

        [Name("First Name")]
        public string FirstName { get; set; }

        [Name("Last Name")]
        public string LastName { get; set; }

        [Name("M.I")]
        public string MiddleInitial { get; set; }

        [Name("Birthdate")]
        public DateTime BirthDate { get; set; }

        [Name("Gender")]
        public string Gender { get; set; }

        [Name("Street Address")]
        public string StreetAddress { get; set; }

        [Name("City Address")]
        public string CityAddress { get; set; }

        [Name("Zipcode")]
        public string Zipcode { get; set; }

        [Name("Phone Number")]
        public string PhoneNumber { get; set; }

        [Name("Email")]
        public string Email { get; set; }

        [Name("Nationality")]
        public string Nationality { get; set; }

        public virtual ObservableCollectionListSource<Booking> Bookings { get; } = new();

    }
}