using AsyncHotel.Data;
using AsyncHotel.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models.Services
{
    public class AmenitiesService : IAmenities
    {

        private HotelDbContext _context;

        public AmenitiesService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<Amenities> Create(Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return amenities;
        }

        public async Task<List<Amenities>> GetAmenities()
        {
            var amenities = await _context.Amenities.ToListAsync();
            return amenities;
        }

        public async Task<Amenities> GetAmenity(int id)
        {
            Amenities amenity = await _context.Amenities.FindAsync(id);
            return amenity;
        }

        public async Task<Amenities> UpdateAmenities(int id, Amenities amenity)
        {
            _context.Entry(amenity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return amenity;
        }

        public async Task Delete(int id)
        {
            Amenities amenity = await GetAmenity(id);
            _context.Entry(amenity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
