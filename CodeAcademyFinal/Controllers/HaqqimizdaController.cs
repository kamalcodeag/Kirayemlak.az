using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class HaqqimizdaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.About = "About";

            return View();
        }
    }
}