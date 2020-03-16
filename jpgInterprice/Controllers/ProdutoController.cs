using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using jpgInterprice.Models.Insert;
using Microsoft.AspNetCore.Mvc;

namespace jpgInterprice.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

    //    [HttpPost]
    //    public async Task<IActionResult> Add(ProdutoInsertViewModel viewModel)
    //    {
    //        var configuration = new MapperConfiguration(cfg =>
    //        {
    //            cfg.CreateMap<EmployeeInsertViewModel, EmployeeDTO>();
    //        });
    //
    //        IMapper mapper = configuration.CreateMapper();
    //        EmployeeDTO dto = mapper.Map<EmployeeDTO>(viewModel);
    //        try
    //        {
    //            await _employeeService.Create(dto);
    //            return RedirectToAction("Home", "Index");
    //        }
    //        catch (NecoException ex)
    //        {
    //            ViewBag.ValidationErrors = ex.Errors;
    //        }
    //        catch (Exception ex)
    //        {
    //            ViewBag.ErrorMessage = ex.Message;
    //        }
    //        return View();
    //    }

        public IActionResult Index()
        {
            return View();
        }
    }
}