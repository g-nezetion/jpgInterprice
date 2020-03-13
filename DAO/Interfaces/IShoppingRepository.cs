using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IShoppingRepository
    {
        Task Create(ShoppingDTO shopping);
        Task<List<ShoppingDTO>> GetShopping();
    }
}
