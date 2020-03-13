using BLL.Interfaces;
using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class ShoppingService : IShoppingService
    {
        private IShoppingRepository _shoppingRepository;
        public ShoppingService(IShoppingRepository shoppingrepository)
        {
            this._shoppingRepository = shoppingrepository;
        }

        public async Task Create(ShoppingDTO shopping)
        {
            
            // FALTA FAZER A VALIDAÇÃO



            await _shoppingRepository.Create(shopping);
        }

        public async Task<List<ShoppingDTO>> GetShopping()
        {
            try
            {
                return await _shoppingRepository.GetShopping();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }
    }
}
