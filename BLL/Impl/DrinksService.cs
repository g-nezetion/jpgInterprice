using BLL.Interfaces;
using DAO.Interfaces;
using Common;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class DrinksService : BaseService, IDrinksService
    {
        private IDrinkRepository _drinkRepository;
        public DrinksService(IDrinkRepository drinkRepository)
        {
            this._drinkRepository = drinkRepository;

        }

        public async Task Create(DrinkDTO drink)
        {
            if (drink.Name == "")
            {
                throw new Exception("o nome deve ser informado");
            }
            else
            {
                drink.Name = drink.Name.Trim();

                if (drink.Name.Length < 2 || drink.Name.Length > 50)
                {
                    throw new Exception("o nome deve conter de 2 a 50 caracteres");
                }
            }
            if (drink.Description == "")
            {
                throw new Exception("a descirção deve ser informada");
            }
            else
            {
                if (drink.Description.Length < 2 || drink.Description.Length > 100)
                {
                    throw new Exception("o descirção deve conter de 2 a 100 caracteres");
                }
            }

        }

        public async Task<List<DrinkDTO>> GetDrinks()
        {
            try
            {
                return await _drinkRepository.GetDrinks();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }
    }
}
