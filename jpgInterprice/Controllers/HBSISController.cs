using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jpgInterprice.Controllers
{
    public class HBSISController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}