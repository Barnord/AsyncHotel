using AsyncHotel.Data;
using AsyncHotel.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AsyncHotel.Models.Services
{
    public class HotelService : IHotel
    {

        private HotelDbContext _context;

        public HotelService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> Create(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return hotel;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels
                .Include(s => s.HotelRooms)
                .ThenInclude(e => e.Room)
                .ToListAsync();
        }

        public async Task<Hotel> GetHotel(int id)
        {
            Hotel hotel = await _context.Hotels.FindAsync(id);
            return hotel;
        }

        public async Task<Hotel> UpdateHotel(int id, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task Delete(int id)
        {
            Hotel hotel = await GetHotel(id);
            _context.Entry(hotel).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task AddRoom(int hotelId, int roomId)
        {
            HotelRoom hotelRoom = new HotelRoom()
            {
                HotelId = hotelId,
                RoomId = roomId
            };

            _context.Entry(hotelRoom).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
}
