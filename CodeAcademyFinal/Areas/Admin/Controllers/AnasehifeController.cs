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
    public class AnasehifeController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;

        public AnasehifeController(RentEstateDb context,
                                   UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            ViewBag.Home = "Home";

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Girish", "Hesab");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Girish", "Hesab");
            }

            AdminHomeViewModel adminHomeViewModel = new AdminHomeViewModel
            {
                NumberOfCustomUsers = _userManager.Users.Count(),
                NumberOfMessages = _context.Messages.Count(),
                NumberOfAnnouncements = _context.Announcements.Count(),
                NumberOfPendingAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == false && announcement.IsDeleted == false && announcement.IsBan == false).Count(),
                NumberOfActiveAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == true).Count(),
                NumberOfDeletedAnnouncements = _context.Announcements.Where(announcement => announcement.IsDeleted == true).Count(),
                NumberOfBanAnnouncements = _context.Announcements.Where(announcement => announcement.IsBan == true).Count()
            };

            return View(adminHomeViewModel);
        }
    }
}