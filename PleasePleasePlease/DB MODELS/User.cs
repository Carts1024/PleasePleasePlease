using CsvHelper.Configuration.Attributes;   // Using CsvHelper attributes for CSV mapping
using System.ComponentModel.DataAnnotations; // Using DataAnnotations for data validation

namespace Mirai_Paradise_Hotel
{
    public class User
    {
        [Name("Index")]                        // CSVHelper attribute: maps "Index" column to this property
        public int Index { get; set; }         // Property for storing Index

        [Key, Name("User Id")]                 // DataAnnotations attribute: specifies this property as the key
        public Guid UserID { get; set; }     // Property for storing User ID

        [Name("UserName")]
        public string UserName { get; set; }

        [Name("Phone Number")]
        public int PhoneNumber { get; set; }

        [Name("isManager?")]
        public bool isManager { get; set; }

        [Name("Password")]
        public string Password { get; set; }
    }
}