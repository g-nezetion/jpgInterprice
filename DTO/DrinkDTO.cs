using DTO.Enums;
using System;
using System.Collections.Generic;

namespace DTO
{
    public class DrinkDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CoutryDrinks CoutryDrinks { get; set; }
        public int Alcohol { get; set; }
        public QuantityPerBottle QuantityPerBottle { get; set; }
        public virtual ICollection<ClientDTO> Clientes { get; set; }
        public DrinkDTO()
        {
            this.Clientes = new List<ClientDTO>();
        }
    }
}
