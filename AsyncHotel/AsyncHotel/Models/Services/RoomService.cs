using AsyncHotel.Data;
using AsyncHotel.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models.Services
{
    public class RoomService : IRoom
    {
        private HotelDbContext _context;

        public RoomService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Room> Create(Room room)
        {
            _context.Entry(room).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return room;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                .Include(c => c.RoomAmenities)
                .ThenInclude(e => e.Amenities)
                .ToListAsync();
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms
                .Include(c => c.RoomAmenities)
                .ThenInclude(e => e.Amenities)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Room> UpdateRoom(int id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task Delete(int id)
        {
            Room room = await GetRoom(id);
            _context.Entry(room).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task AddAmenity(int roomId, int amenitiesId)
        {
            RoomAmenities roomAmenities = new()
            {
                RoomId = roomId,
                AmenitiesId = amenitiesId
            };

            _context.Entry(roomAmenities).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
}
