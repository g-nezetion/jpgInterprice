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
    public class DrinkController : Controller
    {
        private IDrinksService _drinkService;
        public DrinkController(IDrinksService DrinkService)
        {
            this._drinkService = DrinkService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DrinkInsertViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DrinkInsertViewModel, DrinkDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
           
            DrinkDTO dto = mapper.Map<DrinkDTO>(viewModel);
            try
            {
                await _drinkService.Create(dto);
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
    }
}