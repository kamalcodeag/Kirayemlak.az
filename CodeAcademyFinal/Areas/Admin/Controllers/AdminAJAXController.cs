using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAJAXController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminAJAXController(RentEstateDb context,
                                   UserManager<CustomUser> userManager,
                                   RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        #region Pagination - Messages
        public IActionResult GetMessagesByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<Message> messages = _context.Messages.OrderByDescending(message => message.SentTime).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetMessagesByPagePartialView", messages);
        }
        #endregion

        #region Pagination - Positions
        public IActionResult GetPositionsByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<IdentityRole> positions = _roleManager.Roles.Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetPositionsByPagePartialView", positions);
        }
        #endregion

        #region Pagination - Employees
        public IActionResult GetEmployeesByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<CustomUser> customUsers = _userManager.Users.Where(user => user.EmailConfirmed == true).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetEmployeesByPagePartialView", customUsers);
        }
        #endregion

        #region Pagination - Users
        public IActionResult GetUsersByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<CustomUser> customUsers = _userManager.Users.Where(user => user.EmailConfirmed == true).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetUsersByPagePartialView", customUsers);
        }
        #endregion

        #region Pagination - ActiveAnnouncements
        public IActionResult GetActiveAnnouncementsByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<Announcement> activeAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetActiveAnnouncementsByPagePartialView", activeAnnouncements);
        }
        #endregion

        #region Pagination - PendingAnnouncements
        public IActionResult GetPendingAnnouncementsByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<Announcement> pendingAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == false && announcement.IsDeleted == false && announcement.IsBan == false).OrderByDescending(announcement => announcement.PublishDate).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetPendingAnnouncementsByPagePartialView", pendingAnnouncements);
        }
        #endregion

        #region Pagination - BanAnnouncements
        public IActionResult GetBanAnnouncementsByPage(int? skipCount, int? dataId)
        {
            ViewBag.DataId = Convert.ToInt32(dataId);
            ViewBag.Number = Convert.ToInt32(skipCount) + 1;

            IQueryable<Announcement> bannedAnnouncements = _context.Announcements.Where(announcement => announcement.IsBan == true).OrderByDescending(announcement => announcement.PublishDate).Skip(Convert.ToInt32(skipCount)).Take(10);

            return PartialView("GetBanAnnouncementsByPagePartialView", bannedAnnouncements);
        }
        #endregion
    }
}