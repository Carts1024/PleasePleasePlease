using Microsoft.EntityFrameworkCore;   // Using Entity Framework Core for database operations
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirai_Paradise_Hotel
{
    public class DataContext : DbContext   // DataContext class inherits from DbContext
    {
        public DbSet<User> Users { get; set; }  // DbSet representing the "Users" table in the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuring the DbContext to use SQLite with a specific database file
            optionsBuilder.UseSqlite("Data Source = Hotel Management.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID); // Setting UserID as the primary key

            modelBuilder.Entity<User>()
                .Property(u => u.UserID)
                .ValueGeneratedOnAdd(); // Configure UserID to be auto-generated on add

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "Admin", Password = "123" });

            // No need to reconfigure Property(u => u.UserID).ValueGeneratedOnAdd() here
        }
    }
}
