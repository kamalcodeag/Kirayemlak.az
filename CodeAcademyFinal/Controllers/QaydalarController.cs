using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class QaydalarController : Controller
    {
        private readonly RentEstateDb _context;

        public QaydalarController(RentEstateDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Rules = "Rules";
            return View(_context.Rules.FirstOrDefault());
        }
    }
}