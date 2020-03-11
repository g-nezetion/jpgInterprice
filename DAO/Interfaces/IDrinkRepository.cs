using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IDrinkRepository
    {
        Task Create(DrinkDTO drinks);
        Task<List<DrinkDTO>> GetDrinks();
    }
}
