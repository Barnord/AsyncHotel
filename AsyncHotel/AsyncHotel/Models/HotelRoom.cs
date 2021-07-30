using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models
{
    public class HotelRoom
    {
        public int HotelId { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }
        public Hotel Hotel { get; set; }
    }
}
