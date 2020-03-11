using DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ClientDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public CoutryDrinks CoutryDrinks { get; set; }
        public QuantityPerBottle QuantityPerBottle { get; set; }
        public string Senha { get; set; }
        public virtual DrinkDTO Drinks { get; set; }
        public int DrinkID { get; set; }
    }
}
