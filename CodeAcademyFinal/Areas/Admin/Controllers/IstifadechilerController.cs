using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IstifadechilerController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;

        public IstifadechilerController(RentEstateDb context,
                                        UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Siyahi()
        {
            ViewBag.Users = "Users";
            ViewBag.AllUsers = Convert.ToDecimal(_userManager.Users.Where(user => user.EmailConfirmed == true).Count());

            IQueryable<CustomUser> customUsers = _userManager.Users.Where(user => user.EmailConfirmed == true).Take(10);

            return View(customUsers);
        }
    }
}