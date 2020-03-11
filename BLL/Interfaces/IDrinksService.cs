using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDrinksService
    {
        Task Create(DrinkDTO drinks);
        Task<List<DrinkDTO>> GetDrinks();
    }
}
