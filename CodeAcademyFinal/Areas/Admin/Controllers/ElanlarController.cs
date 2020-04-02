using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using CodeAcademyFinal.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ElanlarController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly IConfiguration _configuration;

        public ElanlarController(RentEstateDb context,
                                 IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Aktiv()
        {
            ViewBag.Announcements = "Announcements";
            ViewBag.AllActiveAnnouncements = Convert.ToDecimal(_context.Announcements.Where(announcement => announcement.IsActive == true).Count());

            IQueryable<Announcement> activeAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Take(10);

            return View(activeAnnouncements);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Gozleyen()
        {
            ViewBag.Announcements = "Announcements";
            ViewBag.AllPendingAnnouncements = Convert.ToDecimal(_context.Announcements.Where(announcement => announcement.IsActive == false && announcement.IsDeleted == false && announcement.IsBan == false).Count());

            IQueryable<Announcement> pendingAnnouncements = _context.Announcements.Where(announcement => announcement.IsActive == false && announcement.IsDeleted == false && announcement.IsBan == false).OrderByDescending(announcement => announcement.PublishDate).Take(10);

            return View(pendingAnnouncements);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Tesdiqedilmemish()
        {
            ViewBag.Announcements = "Announcements";
            ViewBag.AllBanAnnouncements = Convert.ToDecimal(_context.Announcements.Where(announcement => announcement.IsBan == true).Count());

            IQueryable<Announcement> bannedAnnouncements = _context.Announcements.Where(announcement => announcement.IsBan == true).OrderByDescending(announcement => announcement.PublishDate).Take(10);

            return View(bannedAnnouncements);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Elan(int? Id)
        {
            ViewBag.Announcements = "Announcements";

            if (Id == null)
            {
                return NotFound();
            }

            ViewBag.AnnouncementId = Id;

            Announcement announcementFromDb = _context.Announcements.Where(announcement => announcement.IsActive == false && announcement.IsDeleted == false && announcement.IsBan == false).FirstOrDefault(announcement => announcement.Id == Id);

            if(announcementFromDb == null)
            {
                return NotFound();
            }

            ViewBag.IsVIP = announcementFromDb.IsVIP;
            ViewBag.EstateName = announcementFromDb.Estate.EstateName;
            ViewBag.CityName = announcementFromDb.City.CityName;

            if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
            {
                ViewBag.Room = announcementFromDb.Room.RoomType;
            }

            ViewBag.Photos = announcementFromDb.AnnouncementPhotos.ToList();
            ViewBag.Area = announcementFromDb.Area;
            ViewBag.AreaForView = announcementFromDb.AreaForView;
            ViewBag.Duration = announcementFromDb.Duration.DurationType;
            ViewBag.Price = announcementFromDb.Price;
            ViewBag.Details = announcementFromDb.Details;

            return View(announcementFromDb);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Elanitesdiqet(int? Id, Announcement announcement)
        {
            if(Id == null)
            {
                return NotFound();
            }

            ViewBag.AnnouncementId = Id;

            Announcement announcementFromDb = _context.Announcements.Where(announce => announce.IsActive == false && announce.IsDeleted == false && announce.IsBan == false).FirstOrDefault(ann => ann.Id == Id);

            if(announcementFromDb == null)
            {
                return NotFound();
            }

            ViewBag.IsVIP = announcementFromDb.IsVIP;
            ViewBag.EstateName = announcementFromDb.Estate.EstateName;
            ViewBag.CityName = announcementFromDb.City.CityName;

            if(announcement.EstateId == 1 || announcement.EstateId == 2)
            {
                ViewBag.Room = announcementFromDb.Room.RoomType;
            }

            ViewBag.Photos = announcementFromDb.AnnouncementPhotos.ToList();
            ViewBag.Area = announcementFromDb.Area;
            ViewBag.AreaForView = announcementFromDb.AreaForView;
            ViewBag.Duration = announcementFromDb.Duration.DurationType;
            ViewBag.Price = announcementFromDb.Price;
            ViewBag.Details = announcementFromDb.Details;

            if (!ModelState.IsValid)
            {
                ViewBag.AnnouncementId = Id;
                ViewBag.IsVIP = announcementFromDb.IsVIP;
                ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                ViewBag.CityName = announcementFromDb.City.CityName;

                if (announcement.EstateId == 1 || announcement.EstateId == 2)
                {
                    ViewBag.Room = announcementFromDb.Room.RoomType;
                }

                ViewBag.Photos = announcementFromDb.AnnouncementPhotos.ToList();
                ViewBag.Area = announcementFromDb.Area;
                ViewBag.AreaForView = announcementFromDb.AreaForView;
                ViewBag.Duration = announcementFromDb.Duration.DurationType;
                ViewBag.Price = announcementFromDb.Price;
                ViewBag.Details = announcementFromDb.Details;

                return View("Elan", announcement);
            }

            announcementFromDb.Area = announcement.Area;
            announcementFromDb.AreaForView = announcement.AreaForView;
            announcementFromDb.Price = announcement.Price;
            announcementFromDb.Details = announcement.Details;
            announcementFromDb.IsActive = true;
            announcementFromDb.IsDeleted = false;
            announcementFromDb.IsBan = false;

            await _context.SaveChangesAsync();

            #region Sending Email AnnouncementConfirmed Message
            string messageSubject = "Elan təsdiq olundu";
            string messageBody = $"<table style='width:100%;background-color:#292C34;padding:50px'><thead style ='width:100%;display:flex;justify-content:center;'><tr style ='width:100%;display:flex;justify-content:center;'><th style ='width:100%;color:#F9F9F9;font-family:Roboto, sans-serif;font-weight:400;font-size:50px'>Kirayemlak.az</th></tr><thead><tbody><tr><td style ='padding:30px 0px;color:#888888;font-family:Roboto Condensed, sans-serif;font-size:20px;text-align:center;'>Hörmətli istifadəçi, dərc etdiyiniz elan təsdiqləndi. Hesabınıza daxil olaraq elana baxa bilərsiniz.</td></tr><tr><td style ='font-family:Roboto Condensed, sans-serif;text-align:center;'><a href='http://kirayemlak.az/Hesab/Girish' style ='text-decoration:none;padding:10px 30px;border-radius:3px;background-color:#F9F9F9;color:#292C34;font-weight:lighter;font-size:20px;cursor:pointer;'>Daxil ol</a></td></tr></tbody></table>";
            await UtilityRealEstate.SendMessage(_configuration, announcementFromDb.CustomUser.Email, messageSubject, messageBody);
            #endregion

            TempData["AnnouncementConfirmed"] = true;

            return RedirectToAction("Aktiv", "Elanlar");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Elaniengelle(int? Id, Announcement announcement)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Announcement announcementFromDb = _context.Announcements.Where(announce => announce.IsActive == false && announce.IsDeleted == false && announce.IsBan == false).FirstOrDefault(ann => ann.Id == Id);

            if (announcementFromDb == null)
            {
                return NotFound();
            }

            announcementFromDb.IsActive = false;
            announcementFromDb.IsDeleted = false;
            announcementFromDb.IsBan = true;

            await _context.SaveChangesAsync();

            #region Sending Email Announcement Banned Message
            string messageSubject = "Elan təsdiq olunmadı";
            string messageBody = $"<table style='width:100%;background-color:#AD0028;padding:50px'><thead style ='width:100%;display:flex;justify-content:center;'><tr style ='width:100%;display:flex;justify-content:center;'><th style ='width:100%;color:#F9F9F9;font-family:Roboto, sans-serif;font-weight:400;font-size:50px'>Kirayemlak.az</th></tr><thead><tbody><tr><td style ='padding:30px 0px;color:white;font-family:Roboto Condensed, sans-serif;font-size:20px;text-align:center;'>Hörmətli istifadəçi, dərc etdiyiniz elan qaydalara uyğun olmadığına görə təsdiq olunmadı. Zəhmət olmasa, 'Qaydalar' bölməsində təsvir edilmiş qaydaları yenidən nəzərdən keçirin.</td></tr><tr><td style ='font-family:Roboto Condensed, sans-serif;text-align:center;'><a href='http://kirayemlak.az/Qaydalar' style ='text-decoration:none;padding:10px 30px;border-radius:3px;background-color:#F9F9F9;color:#292C34;font-weight:lighter;font-size:20px;cursor:pointer;'>Qaydalar</a></td></tr></tbody></table>";
            await UtilityRealEstate.SendMessage(_configuration, announcementFromDb.CustomUser.Email, messageSubject, messageBody);
            #endregion

            TempData["AnnouncementBanned"] = true;

            return RedirectToAction("Tesdiqedilmemish", "Elanlar");
        }
    }
}