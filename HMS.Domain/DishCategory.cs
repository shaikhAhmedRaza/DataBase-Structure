using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Domain
{
    class DishCategory : BaseEntity
    {
        public string Name { get; set; }

        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }
    }
}
