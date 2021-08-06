using AsyncHotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }

        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "AsyncInn",
                    City = "Bellingham",
                    Address = "1234 Await Lane",
                    State = "WA",
                    Country = "USA",
                    PhoneNumber = 1234567890
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    Name = "Cockroach Suite",
                    Layout = 1
                });

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    Id = 1,
                    Name = "Coffee Maker"
                },
                new Amenities
                {
                    Id = 2,
                    Name = "Iron"
                });

            modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom
                {
                    HotelId = 1,
                    RoomId = 1
                });

            modelBuilder.Entity<RoomAmenities>().HasData(
                new RoomAmenities
                {
                    RoomId = 1,
                    AmenitiesId = 2
                });

            modelBuilder.Entity<HotelRoom>().HasKey(
                hotelRoom => new { hotelRoom.HotelId, hotelRoom.RoomId }
                );

            modelBuilder.Entity<RoomAmenities>().HasKey(
                roomAmenity => new { roomAmenity.RoomId, roomAmenity.AmenitiesId }
                );
        }
    }
}