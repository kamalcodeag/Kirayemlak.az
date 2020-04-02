using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.Areas.Admin.ViewModels;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IshchilerController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IshchilerController(RentEstateDb context,
                                   UserManager<CustomUser> userManager,
                                   RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Siyahi()
        {
            ViewBag.Employees = "Employees";
            ViewBag.AllEmployees = Convert.ToDecimal(_userManager.Users.Where(user => user.EmailConfirmed == true).Count());

            IQueryable<CustomUser> customUsers = _userManager.Users.Where(user => user.EmailConfirmed == true).Take(10);

            return View(customUsers);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Yarat()
        {
            ViewBag.Employees = "Employees";
            ViewBag.Roles = _roleManager.Roles;

            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Yarat(AdminEmployeeViewModel adminEmployeeViewModel)
        {
            ViewBag.Employees = "Employees";
            ViewBag.Roles = _roleManager.Roles;

            if(!ModelState.IsValid)
            {
                ViewBag.Employees = "Employees";
                ViewBag.Roles = _roleManager.Roles;

                return View(adminEmployeeViewModel);
            }

            CustomUser customUser = new CustomUser
            {
                FirstName = adminEmployeeViewModel.UserName,
                LastName = adminEmployeeViewModel.UserName,
                UserName = adminEmployeeViewModel.UserName,
                Email = adminEmployeeViewModel.Email,
                EmailConfirmed = true,
                PhoneNumber = "+994001234567",
                ProfilePictureURL = "person-male-default.jpg"
            };

            IdentityResult result =  await _userManager.CreateAsync(customUser, adminEmployeeViewModel.Password);

            if(!result.Succeeded)
            {
                ViewBag.Employees = "Employees";
                ViewBag.Roles = _roleManager.Roles;

                ModelState.AddModelError("", "Bu istifadəçi artıq qeydiyyatdan keçib və ya şifrə tələblərə uyğun deyil.");

                return View(adminEmployeeViewModel);
            }

            IdentityRole identityRole = await _roleManager.FindByIdAsync(adminEmployeeViewModel.RoleId);
            await _userManager.AddToRoleAsync(customUser, identityRole.Name);

            TempData["EmployeeCreated"] = true;

            return RedirectToAction("Siyahi", "Ishchiler");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Sil(string userId)
        {
            ViewBag.Employees = "Employees";

            CustomUser customUser = _userManager.Users.FirstOrDefault(user => user.Id == userId);
            await _userManager.DeleteAsync(customUser);

            TempData["EmployeeDeleted"] = true;

            return RedirectToAction("Siyahi", "Ishchiler");
        }
    }
}