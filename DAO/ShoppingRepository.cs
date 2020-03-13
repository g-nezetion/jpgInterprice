using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ShoppingRepository : IShoppingRepository
    {
        private JPGContext _contex;
        public ShoppingRepository(JPGContext context)
        {
            this._contex = context;

        }
        public async Task Create(ShoppingDTO shopping)
        {
            this._contex.Shopping.Add(shopping);
            await this._contex.SaveChangesAsync();

        }

        public async Task<List<ShoppingDTO>> GetShopping()
        {
            return await _contex.Shopping.ToListAsync();
        }
    }
}
