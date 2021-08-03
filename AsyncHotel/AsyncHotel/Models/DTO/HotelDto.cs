using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotel.Models.DTO
{
    public class HotelDto
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int PhoneNumber { get; set; }
    }
}
