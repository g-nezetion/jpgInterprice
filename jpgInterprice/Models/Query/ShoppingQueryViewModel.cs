using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jpgInterprice.Models.Query
{
    public class ShoppingQueryViewModel
    {
        public int ID { get; set; }
        public List<DrinkDTO> Drinks { get; set; }
    }
}
