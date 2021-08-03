using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models.DTO
{
    public class HotelRoomDto
    {
        public Room Room { get; set; }
        public Hotel Hotel { get; set; }
    }
}
