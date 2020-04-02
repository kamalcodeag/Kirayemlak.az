using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.Areas.Admin.ViewModels;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using CodeAcademyFinal.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HesabController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<CustomUser> _signInManager;

        public HesabController(RentEstateDb context,
                               UserManager<CustomUser> userManager,
                               RoleManager<IdentityRole> roleManager,
                               SignInManager<CustomUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Girish()
        {
            //Calling reusable method
            bool succeeded = await UtilityRealEstate.DbInitializer(_userManager, _roleManager);

            if (succeeded == true)
            {
                await UtilityRealEstate.DbInitializer(_userManager, _roleManager);
            }
            else
            {
                return RedirectToAction("Index", "Xeta");
            }

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Anasehife");
            }

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Girish(AdminSignInViewModel adminSignInViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(adminSignInViewModel);
            }

            CustomUser customUserFromDb = await _userManager.FindByNameAsync(adminSignInViewModel.UserName);

            if (customUserFromDb == null)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz istifadəçi adı və ya şifrə yanlışdır.");
                return View(adminSignInViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(customUserFromDb, adminSignInViewModel.Password, false, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Daxil etdiyiniz istifadəçi adı və ya şifrə yanlışdır.");
                return View(adminSignInViewModel);
            }

            return RedirectToAction("Index", "Anasehife");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Chixish()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Girish", "Hesab");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Shifrenideyish()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Shifrenideyish(AdminChangePasswordViewModel adminChangePasswordViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(adminChangePasswordViewModel);
            }

            string activeUserName = User.Identity.Name;
            CustomUser customUserFromDb = await _userManager.FindByNameAsync(activeUserName);

            IdentityResult result = await _userManager.ChangePasswordAsync(customUserFromDb, adminChangePasswordViewModel.CurrentPassword, adminChangePasswordViewModel.NewPassword);
            await _userManager.UpdateAsync(customUserFromDb);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("CurrentPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                ModelState.AddModelError("NewPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                return View(adminChangePasswordViewModel);
            }

            TempData["PasswordChanged"] = true;

            return View();
        }
    }
}