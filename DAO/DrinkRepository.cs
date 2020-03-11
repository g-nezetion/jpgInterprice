using DAO.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAO
{
    public class DrinkRepository : IDrinkRepository
    {
        private JPGContext _contex;
        public DrinkRepository(JPGContext context)
        {
            this._contex = context;
        }

        public async Task Create(DrinkDTO drink)
        {
            this._contex.Drinks.Add(drink);
            await this._contex.SaveChangesAsync();
        }

        public async Task<List<DrinkDTO>> GetDrinks()
        {
            return await _contex.Drinks.ToListAsync();
        }
    }
}
