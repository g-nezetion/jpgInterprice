using DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jpgInterprice.Models.Insert
{
    public class DrinkInsertViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoutryDrinks { get; set; }
        public int Alcohol { get; set; }
        public string QuantityPerBottle { get; set; }
    }
}
