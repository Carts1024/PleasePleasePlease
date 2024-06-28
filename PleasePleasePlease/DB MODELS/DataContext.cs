using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Proxies; // Add this namespace for lazy loading proxies
using System;

namespace Mirai_Paradise_Hotel
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UserData.db");
       //     optionsBuilder.UseLazyLoadingProxies(); // Enable lazy loading proxies
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure User entity
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);

            modelBuilder.Entity<User>()
                .Property(u => u.UserID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>().HasData(
                new User { UserID = Guid.NewGuid(), UserName = "Admin", isManager = true, Password = "123" },
                new User { UserID = Guid.NewGuid(), UserName = "Recep", isManager = false, Password = "321" });

            // Configure Guest entity
            modelBuilder.Entity<Guest>()
                .HasKey(g => g.GuestID);

            modelBuilder.Entity<Guest>()
                .Property(g => g.GuestID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    GuestID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    MiddleInitial = "M",
                    Gender = "Male",
                    StreetAddress = "123 Main St",
                    CityAddress = "Anytown",
                    PhoneNumber = "2014",
                    Email = "carl@gmail.com",
                    Nationality = "US",
                    BirthDate = DateTime.Now,
                    Zipcode = "3023"

                });

            // Configure Room entity
            modelBuilder.Entity<Room>()
                .HasKey(r => r.RoomNumber);

            modelBuilder.Entity<Room>()
                .Property(r => r.RoomNumber)
                .ValueGeneratedOnAdd();

        /*    modelBuilder.Entity<Room>()
                .HasOne(b => b.RoomStatus)
                .WithMany() // Make sure to establish the relationship correctly
                .HasForeignKey(b => b.RoomStatusID)
                .OnDelete(DeleteBehavior.Cascade); */

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomNumber = 1,
                    RoomType = "Standard",
                    RoomStatusID = "1",
                    RoomPrice = 100.00m,
                    FloorNumber = 2,
                    Capacity = 2
                });

            // Configure Booking entity
            modelBuilder.Entity<Booking>()
                .HasKey(b => b.BookingID);

            modelBuilder.Entity<Booking>()
                .Property(b => b.BookingID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Guest)
                .WithMany(g => g.Bookings) // Make sure to establish the relationship correctly
                .HasForeignKey(b => b.GuestID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany()
                .HasForeignKey(b => b.RoomNumber)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    CheckInDate = DateTime.Now,
                    CheckInTime = DateTime.Now,
                    CheckOutDate = DateTime.Now,
                    CheckOutTime = DateTime.Now,
                    GuestID = 1,    // Ensure this GuestID exists in the Guest table
                    RoomNumber = 1  // Ensure this RoomNumber exists in the Room table
                });

            modelBuilder.Entity<RoomStatus>().HasData(
                new RoomStatus { RoomStatusID = "1", RoomStatusName = "Available" },
                new RoomStatus { RoomStatusID = "2", RoomStatusName = "Occupied" },
                new RoomStatus { RoomStatusID = "3", RoomStatusName = "UnderMaintenance" }

                );
        }
    }
}
