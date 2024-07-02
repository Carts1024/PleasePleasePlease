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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UserData.db");
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
                new User { UserID = Guid.NewGuid(), UserName = "Admin", AccountType = "Administator", Password = "123" },
                new User { UserID = Guid.NewGuid(), UserName = "Manag", AccountType = "Manager", Password = "321" },
                new User { UserID = Guid.NewGuid(), UserName = "Recep", AccountType = "Receptionist", Password = "4321" });

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

            modelBuilder.Entity<Room>()
                .Property(r => r.Index);

            modelBuilder.Entity<Room>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Room>("Room")
                .HasValue<StandardRoom>("StandardRoom")
                .HasValue<DeluxeRoom>("DeluxeRoom")
                .HasValue<Suite>("Suite");

            // Seed data for derived types
            modelBuilder.Entity<StandardRoom>().HasData(
                new StandardRoom
                {
                    RoomNumber = 1,
                    Index = 1, // Add initial value for index
                    RoomType = "Standard",
                    RoomStatus = "Available",
                    RoomPrice = 100.00m,
                    FloorNumber = 2,
                    BedType = "Double/Twin",
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
                .WithMany(g => g.Bookings)
                .HasForeignKey(b => b.GuestID)
                .OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Booking>()
				.HasOne(b => b.Room)
				.WithMany(r => r.Bookingss)
				.HasForeignKey(b => b.RoomNumber)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Booking>().HasData(
				new Booking
				{
                    BookingID = Guid.NewGuid(),
                    CheckInDate = DateTime.Now,           // Current date and time
                    CheckInTime = DateTime.Now.TimeOfDay, // Current time of the day as TimeSpan
                    CheckOutDate = DateTime.Now,          // Current date and time
                    CheckOutTime = DateTime.Now.TimeOfDay,// Current time of the day as TimeSpan
                    GuestID = 1,    // Ensure this GuestID exists in the Guest table
                    RoomNumber = 1  // Ensure this RoomNumber exists in the Room table
                });
        }
    }
}
