using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsyncHotel.Data;
using AsyncHotel.Models;
using AsyncHotel.Models.Interfaces;

namespace AsyncHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        private readonly IAmenities _amenities;

        public AmenitiesController(IAmenities context)
        {
            _amenities = context;
        }

        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAmenities()
        {
            var list = await _amenities.GetAmenities();
            return Ok(list);
        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amenities>> GetAmenities(int id)
        {
            Amenities amenity = await _amenities.GetAmenity(id);
            return amenity;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenities(int id, Amenities amenities)
        {
            if (id != amenities.Id)
            {
                return BadRequest();
            }

            var updatedAmenity = await _amenities.UpdateAmenities(id, amenities);

            return Ok(updatedAmenity);
        }

        // POST: api/Amenities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Amenities>> PostAmenities(Amenities amenities)
        {
            await _amenities.Create(amenities);

            return CreatedAtAction("GetAmenities", new { id = amenities.Id }, amenities);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmenities(int id)
        {
            await _amenities.Delete(id);
            return NoContent();
        }
    }
}
