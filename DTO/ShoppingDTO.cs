using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ShoppingDTO
    {
        public int ID { get; set; }
        public List<DrinkDTO> Drinks { get; set; }
    }
}