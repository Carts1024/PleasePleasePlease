using Microsoft.EntityFrameworkCore;
using System;

namespace Mirai_Paradise_Hotel
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StandardRoom> StandardRooms { get; set; }
        public DbSet<DeluxeRoom> DeluxeRooms { get; set; }
        public DbSet<Suite> Suites { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; } // Added Invoice DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UserData.db");
            optionsBuilder.EnableSensitiveDataLogging();
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
                new User { UserID = Guid.NewGuid(), UserName = "Admin", AccountType = "Administrator", Password = "123" },
                new User { UserID = Guid.NewGuid(), UserName = "Manag", AccountType = "Manager", Password = "321" },
                new User { UserID = Guid.NewGuid(), UserName = "Recep", AccountType = "Receptionist", Password = "4321" });

            // Configure Guest entity
            modelBuilder.Entity<Guest>()
                .HasKey(g => g.GuestID);

            modelBuilder.Entity<Guest>()
                .Property(g => g.GuestID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Guest>()
                .HasQueryFilter(g => !g.IsDeleted); // Global query filter for soft delete


            /*  modelBuilder.Entity<Guest>().HasData(
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
                      StateAddress = "Ohio"
                  }); */

            // Configure Room entity
            modelBuilder.Entity<Room>()
                .HasKey(r => r.RoomNumber);

            modelBuilder.Entity<Room>()
                .Property(r => r.RoomNumber)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Room>()
                .Property(r => r.Index);

            // Configure StandardRoom entity
            modelBuilder.Entity<StandardRoom>().ToTable("StandardRooms");

            // Configure DeluxeRoom entity
            modelBuilder.Entity<DeluxeRoom>().ToTable("DeluxeRooms");

            // Configure Suite entity
            modelBuilder.Entity<Suite>().ToTable("Suites");

            // Seed data for derived types


            // Configure Booking entity
            modelBuilder.Entity<Booking>()
                .HasKey(b => b.BookingID);

            modelBuilder.Entity<Booking>()
                .Property(b => b.BookingID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Guest)
                .WithMany(g => g.Bookings)
                .HasForeignKey(b => b.GuestID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany(r => r.Bookings)
                .HasForeignKey(b => b.RoomNumber)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Booking>()
                .HasQueryFilter(b => !b.IsDeleted); // Global query filter for soft delete


            modelBuilder.Entity<OrderItem>()
       .HasKey(oi => oi.OrderItemId);
            //    modelBuilder.Entity<Address>().Ignore();


            /*      modelBuilder.Entity<Booking>().HasData(
                       new Booking
                       {
                           BookingID = 1,
                           CheckInDate = DateTime.Now,
                           CheckInTime = DateTime.Now.TimeOfDay,
                           CheckOutDate = DateTime.Now,
                           CheckOutTime = DateTime.Now.TimeOfDay,
                           GuestID = 1,
                           RoomNumber = 1
                       });*/
            modelBuilder.Entity<InvoiceModel>()
                .HasKey(b => b.InvoiceNumber);

            base.OnModelCreating(modelBuilder);
        }
    }
}
