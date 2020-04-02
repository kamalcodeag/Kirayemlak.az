using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VezifeController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public VezifeController(RentEstateDb context,
                               RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Siyahi()
        {
            ViewBag.Position = "Position";
            ViewBag.AllPositions = Convert.ToDecimal(_roleManager.Roles.Count());

            IEnumerable<IdentityRole> positions = _roleManager.Roles.Take(10);

            return View(positions);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Yarat()
        {
            ViewBag.Position = "Position";

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Yarat(IdentityRole identityRole)
        {
            ViewBag.Position = "Position";

            if(identityRole.Name == null)
            {
                ViewBag.Position = "Position";

                ModelState.AddModelError("Name", "Zəhmət olmasa, boşluğu doldurun.");

                return View(identityRole);
            }
            else
            {
                if (!await _roleManager.RoleExistsAsync(identityRole.Name))
                {
                    await _roleManager.CreateAsync(new IdentityRole(identityRole.Name));
                }
                else
                {
                    ModelState.AddModelError("Name", "Bu vəzifə artıq mövcuddur.");
                    return View(identityRole);
                }
            }

            TempData["PositionCreated"] = true;

            return RedirectToAction("Siyahi", "Vezife");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Sil(string roleId)
        {
            if(roleId != null)
            {
                IdentityRole position = await _roleManager.FindByIdAsync(roleId);
                await _roleManager.DeleteAsync(position);
                await _context.SaveChangesAsync();
            }

            TempData["PositionDeleted"] = true;

            return RedirectToAction("Siyahi", "Vezife");
        }
    }
}