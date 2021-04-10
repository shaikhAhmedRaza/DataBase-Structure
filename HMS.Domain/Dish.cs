using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Domain
{
    public class Dish : BaseEntity
    {
     
        public string Name { get; set; }
        public int Description { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int MainCategoryId { get; set; }
    }
}
