using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class AJAXController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly UserManager<CustomUser> _userManager;

        public AJAXController(RentEstateDb context,
                              UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        #region Search Result
        public IActionResult GetSearchResult(int? duration, int? estate, int? room, string area, string price, int? city)
        {
            IQueryable<Announcement> activeAnnouncementsByPublishDate = _context.Announcements.Where(announcement => announcement.IsActive == true).OrderByDescending(announce => announce.PublishDate);

            if (estate == 1 || estate == 2)
            {
                if (price == null)
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.RoomId == room && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }
                else
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.RoomId == room && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }
            }
            else
            {
                if (area == null && price == null)
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }

                if (area == null)
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }
                else if (price == null)
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Area <= Convert.ToDecimal(area) && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }
                else
                {
                    IQueryable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Area <= Convert.ToDecimal(area) && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Take(12);
                    return PartialView("GetSearchResultPartialView", announcements);
                }
            }
        }
        public IActionResult GetMoreSearchResults(int? skipCount, int? duration, int? estate, int? room, string area, string price, int? city)
        {
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            IEnumerable<Announcement> activeAnnouncementsByPublishDate = _context.Announcements.Where(announcement => announcement.IsActive == true).OrderByDescending(announce => announce.PublishDate);

            if (estate == 1 || estate == 2)
            {
                if (price == null)
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.RoomId == room && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }
                else
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.RoomId == room && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }
            }
            else
            {
                if (area == null && price == null)
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }

                if (area == null)
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }
                else if (price == null)
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Area <= Convert.ToDecimal(area) && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }
                else
                {
                    IEnumerable<Announcement> announcements = activeAnnouncementsByPublishDate.Where(ann => ann.DurationId == duration && ann.EstateId == estate && ann.Area <= Convert.ToDecimal(area) && ann.Price <= Convert.ToInt32(price) && ann.CityId == city).Skip(Convert.ToInt32(skipCount)).Take(6);
                    ViewBag.Count = announcements.Count();
                    return PartialView("GetMoreSearchResultsPartialView", announcements);
                }
            }
        }
        #endregion

        #region User Announcements
        public async Task<IActionResult> GetUserAnnouncements(string userId, int? skipCount)
        {
            if (userId == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            CustomUser customUserFromDb = await _userManager.FindByIdAsync(userId);

            IEnumerable<Announcement> announcements = customUserFromDb.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announce => announce.PublishDate).Skip(Convert.ToInt32(skipCount)).Take(6);

            ViewBag.Count = customUserFromDb.Announcements.Where(announce => announce.IsActive == true).Count();

            return PartialView("GetUserAnnouncementsPartialView", announcements);
        }
        #endregion

        #region Alike Announcements
        public IActionResult GetAlikeAnnouncements(int? skipCount, int? estateId)
        {
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            IQueryable<Announcement> announcements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Where(announce => announce.EstateId == estateId).Skip(Convert.ToInt32(skipCount)).Take(6);
            IQueryable<Announcement> activeEstateAnnouncements = _context.Announcements.Where(announce => announce.IsActive == true).Where(ann => ann.EstateId == estateId);
            int countActiveEstateAnnouncements = activeEstateAnnouncements.Count();

            ViewBag.Count = countActiveEstateAnnouncements;

            return PartialView("GetAlikeAnnouncementsPartialView", announcements);
        }
        #endregion

        #region Vip Announcements
        public IActionResult GetVipAnnouncements(int? skipCount)
        {
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            IQueryable<Announcement> announcements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Where(announce => announce.IsVIP == true).Skip(Convert.ToInt32(skipCount)).Take(6);
            IQueryable<Announcement> activeVIPAnnouncements = _context.Announcements.Where(announce => announce.IsActive == true).Where(ann => ann.IsVIP == true);
            int countActiveVIPAnnouncements = activeVIPAnnouncements.Count();

            ViewBag.Count = countActiveVIPAnnouncements;

            return PartialView("GetVipAnnouncementsPartialView", announcements);
        }
        #endregion

        #region Recent Announcements
        public IActionResult GetRecentAnnouncements(int? skipCount)
        {
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            IQueryable<Announcement> announcements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.PublishDate).Skip(Convert.ToInt32(skipCount)).Take(6);
            IQueryable<Announcement> activeAnnouncements = _context.Announcements.Where(announce => announce.IsActive == true);
            int countActiveAnnouncements = activeAnnouncements.Count();

            ViewBag.Count = countActiveAnnouncements;

            return PartialView("GetRecentAnnouncementsPartialView", announcements);
        }
        #endregion

        #region Most Viewed Announcements
        public IActionResult GetMostViewedAnnouncements(int? skipCount)
        {
            if (skipCount == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            IQueryable<Announcement> announcements = _context.Announcements.Where(ann => ann.IsActive == true).OrderByDescending(announcement => announcement.ViewCount).Skip(Convert.ToInt32(skipCount)).Take(6);
            IQueryable<Announcement> activeAnnouncements = _context.Announcements.Where(announce => announce.IsActive == true);
            int countActiveAnnouncements = activeAnnouncements.Count();

            ViewBag.Count = countActiveAnnouncements;

            return PartialView("GetMostViewedAnnouncementsPartialView", announcements);
        }
        #endregion

        #region Add Remove Announcements To From Favourites
        public IActionResult AddRemoveAnnouncementsToFromFavourites(string dataInfo)
        {
            var cookieExists = Request.Cookies["***FavouriteAnnouncement***"];

            if (cookieExists != null)
            {
                if (cookieExists.Contains(dataInfo))
                {
                    var cookieExistsArray = cookieExists.Split("+");
                    for (int i = 0; i < cookieExistsArray.Length; i++)
                    {
                        if (cookieExistsArray[0] == dataInfo)
                        {
                            string resultForIndexZero = cookieExists.Replace(dataInfo, "");
                            CookieOptions option = new CookieOptions();
                            option.IsEssential = true;
                            option.Expires = DateTime.Now.AddHours(24);
                            Response.Cookies.Append("***FavouriteAnnouncement***", resultForIndexZero, option);
                        }
                        else
                        {
                            string result = cookieExists.Replace("+" + dataInfo, "");
                            CookieOptions option = new CookieOptions();
                            option.IsEssential = true;
                            option.Expires = DateTime.Now.AddHours(24);
                            Response.Cookies.Append("***FavouriteAnnouncement***", result, option);
                        }
                    }
                }
                else
                {
                    string additionalValue = Request.Cookies["***FavouriteAnnouncement***"] + "+" + dataInfo;
                    CookieOptions additionalOption = new CookieOptions();
                    additionalOption.Expires = DateTime.Now.AddHours(24);
                    additionalOption.IsEssential = true;
                    Response.Cookies.Append("***FavouriteAnnouncement***", additionalValue, additionalOption);
                }
            }
            else
            {
                CookieOptions option = new CookieOptions();
                option.IsEssential = true;
                option.Expires = DateTime.Now.AddHours(24);
                Response.Cookies.Append("***FavouriteAnnouncement***", dataInfo, option);
            }

            return Json(new { status = "200" });
        }
        #endregion
    }
}