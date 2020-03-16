using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Impl;
using BLL.Interfaces;
using Common;
using DTO;
using jpgInterprice.Models.Insert;
using jpgInterprice.Models.Query;
using Microsoft.AspNetCore.Mvc;

namespace jpgInterprice.Controllers
{
    public class ClientController : Controller
    {

        private IClientService _clientService;
        private IDrinksService _drinksService;

        public ClientController(IClientService clientService,IDrinksService drinksService)
        {
            this._clientService = clientService;
            this._drinksService = drinksService;
        }

        public async Task<IActionResult> Create()
        {

            //ViewBag.Drinks = await _drinksService.GetDrinks();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientInsertViewModel viewModel)
        {

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClientInsertViewModel, ClientDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
            ClientDTO dto = mapper.Map<ClientDTO>(viewModel);
            try
            {
                await _clientService.Create(dto);
                return RedirectToAction("Produto", "Add");
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