using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jpgInterprice.Models.Insert
{
    public class ShoppingInsertViewModel
    {
        public int ID { get; set; }
        public List<DrinkDTO> Drinks { get; set; }
    }
}
