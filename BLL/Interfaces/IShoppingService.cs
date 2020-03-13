using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IShoppingService
    {
        Task Create(ShoppingDTO shopping);
        Task<List<ShoppingDTO>> GetShopping();
    }
}
