using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Layout { get; set; }

        public List<HotelRoom> HotelRooms { get; set; }

        public List<RoomAmenities> RoomAmenities { get; set; }
    }
}
