using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class XetaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}