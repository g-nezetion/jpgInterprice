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
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(EmployeeInsertViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeInsertViewModel, EmployeeDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
            EmployeeDTO dto = mapper.Map<EmployeeDTO>(viewModel);
            try
            {
                await _employeeService.Create(dto);
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

        [HttpPost]
        public async Task<IActionResult> Autenticar(string email, string senha)
        {

            //@if(ViewBag.Erro != null){<p class="color: red;">@ViewBag.Erro</p>}
            try
            {
                EmployeeDTO employee = await _employeeService.Autententicar(email, senha);

                //celinho vai mostrar pra nois S2

                return RedirectToAction("Index", "Drink");

            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
            }
            return View();
        }
    }
}