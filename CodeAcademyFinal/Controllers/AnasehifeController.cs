using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using CodeAcademyFinal.Utilities;
using CodeAcademyFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class AnasehifeController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AnasehifeController(RentEstateDb context,
                                   UserManager<CustomUser> userManager,
                                   RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Home = "Home";
            ViewBag.Durations = _context.Durations;
            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Cities = _context.Cities;

            //Calling reusable method
            bool succeeded = await UtilityRealEstate.DbInitializer(_userManager, _roleManager);

            if(succeeded == true)
            {
                await UtilityRealEstate.DbInitializer(_userManager, _roleManager);
            }
            else
            {
                return RedirectToAction("Index", "Xeta");
            }

            HomeViewModel homeViewModel = new HomeViewModel
            {
                VIP_Announcements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Where(announce => announce.IsVIP == true),
                RecentAnnouncements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate),
                MostViewedAnnouncements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).OrderByDescending(announce => announce.ViewCount)
            };

            ViewBag.Cookie = Request.Cookies["***FavouriteAnnouncement***"];

            return View(homeViewModel);
        }
    }
}