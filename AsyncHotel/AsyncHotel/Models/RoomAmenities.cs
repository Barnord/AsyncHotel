using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models
{
    public class RoomAmenities
    {
        public int RoomId { get; set; }

        public int AmenitiesId { get; set; }

        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}
