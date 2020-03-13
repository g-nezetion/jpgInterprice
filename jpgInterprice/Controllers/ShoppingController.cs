using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using Common;
using DTO;
using jpgInterprice.Models.Insert;
using Microsoft.AspNetCore.Mvc;

namespace jpgInterprice.Controllers
{
    public class ShoppingController : Controller
    {

        private IShoppingService _shoppingService;



        public ShoppingController(IShoppingService shoppingService)
        {
            this._shoppingService = shoppingService;
        }

        public IActionResult BuyDrinks()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuyDrinks(ShoppingInsertViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ShoppingInsertViewModel, ShoppingDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
            ShoppingDTO dto = mapper.Map<ShoppingDTO>(viewModel);
            try
            {
                await _shoppingService.Create(dto);
                return RedirectToAction("Home", "Index");
            }
            catch (NecoException ex)
            {
                ViewBag.ValidationErrors = ex.Errors;
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}