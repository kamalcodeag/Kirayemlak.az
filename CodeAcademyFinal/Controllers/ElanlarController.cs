using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using CodeAcademyFinal.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Controllers
{
    public class ElanlarController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<CustomUser> _userManager;
        private string fileName;

        public ElanlarController(RentEstateDb context,
                                 IHostingEnvironment env,
                                 UserManager<CustomUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        public async Task<IActionResult> Elanyerleshdir()
        {
            if(!User.Identity.IsAuthenticated)
            {
                TempData["MustBeSignedIn"] = true;
                return RedirectToAction("Girish", "Hesab");
            }

            CustomUser customUserFromDb = await _userManager.FindByNameAsync(User.Identity.Name);

            if(!await _userManager.IsInRoleAsync(customUserFromDb, "İstifadəçi"))
            {
                return RedirectToAction("Girish", "Hesab");
            }

            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Durations = _context.Durations;
            ViewBag.Cities = _context.Cities;

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Elanyerleshdir(CreateAnnouncementViewModel createAnnouncementViewModel)
        {
            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Durations = _context.Durations;
            ViewBag.Cities = _context.Cities;

            CustomUser customUserFromDb = await _userManager.FindByNameAsync(User.Identity.Name);

            if (!ModelState.IsValid)
            {
                ViewBag.Estates = _context.Estates;
                ViewBag.Rooms = _context.Rooms;
                ViewBag.Durations = _context.Durations;
                ViewBag.Cities = _context.Cities;

                return View(createAnnouncementViewModel);
            }

            if (createAnnouncementViewModel.UploadFiles == null || createAnnouncementViewModel.UploadFiles.Count() < 4 || createAnnouncementViewModel.UploadFiles.Count() > 20)
            {
                ViewBag.Estates = _context.Estates;
                ViewBag.Rooms = _context.Rooms;
                ViewBag.Durations = _context.Durations;
                ViewBag.Cities = _context.Cities;

                ModelState.AddModelError("UploadFiles", "Şəkillərin(.jpg, .jpeg) sayı 4-dən az, 20-dən çox ola bilməz");

                return View(createAnnouncementViewModel);
            }

            foreach (var file in createAnnouncementViewModel.UploadFiles)
            {
                if (file.Length > (2 * 1024 * 1024))
                {
                    ViewBag.Estates = _context.Estates;
                    ViewBag.Rooms = _context.Rooms;
                    ViewBag.Durations = _context.Durations;
                    ViewBag.Cities = _context.Cities;

                    ModelState.AddModelError("UploadFiles", "Şəklin həcmi 2MB'dan çox ola bilməz.");

                    return View(createAnnouncementViewModel);
                }
            }

            if (createAnnouncementViewModel.BeenReadRules == false)
            {
                ViewBag.Estates = _context.Estates;
                ViewBag.Rooms = _context.Rooms;
                ViewBag.Durations = _context.Durations;
                ViewBag.Cities = _context.Cities;

                ModelState.AddModelError("BeenReadRules", "Diqqət ! Elan yerləşdirmək üçün qaydalarla tanış olmalısınız.");

                return View(createAnnouncementViewModel);
            }

            //Find the last announcement which doesn't require payment fee
            Announcement lastSimpleAnnouncement = customUserFromDb.Announcements.Where(announce => announce.IsVIP == false && announce.IsDeleted == false && announce.IsBan == false).OrderByDescending(ann => ann.PublishDate).FirstOrDefault();
            
            if(lastSimpleAnnouncement != null)
            {
                int lastSimpleAnnouncementDayOfYear = lastSimpleAnnouncement.PublishDate.DayOfYear;

                if(lastSimpleAnnouncement.PublishDate.Year == DateTime.Now.Year)
                {
                    if (DateTime.Now.DayOfYear - lastSimpleAnnouncementDayOfYear <= 30)
                    {
                        ViewBag.Estates = _context.Estates;
                        ViewBag.Rooms = _context.Rooms;
                        ViewBag.Durations = _context.Durations;
                        ViewBag.Cities = _context.Cities;

                        TempData["SimpleAnnouncementLimit"] = true;

                        return View(createAnnouncementViewModel);
                    }
                }
            }

            Announcement announcement = new Announcement
            {
                IsVIP = createAnnouncementViewModel.IsVIP,
                Details = createAnnouncementViewModel.Details,
                Price = createAnnouncementViewModel.Price,
                ViewCount = 0,
                PublishDate = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                IsBan = false,
                EstateId = createAnnouncementViewModel.EstateId,
                DurationId = createAnnouncementViewModel.DurationId,
                CityId = createAnnouncementViewModel.CityId,
                MonthId = DateTime.Now.Month,
                CustomUserId = customUserFromDb.Id
            };

            if (createAnnouncementViewModel.EstateId == 1 || createAnnouncementViewModel.EstateId == 2)
            {
                announcement.Area = createAnnouncementViewModel.Area;
                announcement.AreaForView = createAnnouncementViewModel.Area;
                announcement.RoomId = createAnnouncementViewModel.RoomId;
            }
            else
            {
                announcement.Area = createAnnouncementViewModel.AreaParticular;
                announcement.AreaForView = createAnnouncementViewModel.AreaParticular;
            }

            await _context.Announcements.AddAsync(announcement);
            await _context.SaveChangesAsync();

            foreach (var file in createAnnouncementViewModel.UploadFiles)
            {
                if(file.ContentType.Contains("image/jpg") || file.ContentType.Contains("image/jpeg"))
                {
                    string folderPath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "announcements");
                    fileName = Guid.NewGuid().ToString() + "_elan_" + file.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);


                        //Add Watermark
                        //var watermarkedStream = new MemoryStream();
                        //Image image = Image.FromStream(fileStream);
                        //using (Graphics graphic = Graphics.FromImage(image))
                        //{
                        //    SolidBrush brush = new SolidBrush(Color.Black);
                        //    Font font = new Font(FontFamily.GenericSansSerif, 20.0F);
                        //    graphic.DrawString("kirayeemlak.az", font, brush, new PointF(100,100));
                        //    image.Save(fileStream, ImageFormat.Png);
                        //}


                        ////Add Watermark
                        //var watermarkedStream = new MemoryStream();
                        //using (var img = Image.FromStream(fileStream))
                        //{
                        //    using (var graphic = Graphics.FromImage(img))
                        //    {
                        //        var font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold, GraphicsUnit.Pixel);
                        //        var color = Color.Black;
                        //        var brush = new SolidBrush(color);
                        //        var point = new Point(100, 100);

                        //        graphic.DrawString("kirayeemlak.az", font, brush, point);
                        //        img.Save(watermarkedStream, ImageFormat.Png);
                        //    }
                        //}
                    }

                    AnnouncementPhoto announcementPhoto = new AnnouncementPhoto
                    {
                        AnnouncementPhotoURL = fileName,
                        AnnouncementId = announcement.Id
                    };

                    await _context.AnnouncementPhotos.AddAsync(announcementPhoto);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ViewBag.Estates = _context.Estates;
                    ViewBag.Rooms = _context.Rooms;
                    ViewBag.Durations = _context.Durations;
                    ViewBag.Cities = _context.Cities;

                    ModelState.AddModelError("UploadFiles", "Zəhmət olmasa, .jpg / .jpeg formatda şəkil yükləyin");

                    _context.Announcements.Remove(announcement);
                    await _context.SaveChangesAsync();

                    return View(createAnnouncementViewModel);
                }
            }

            TempData["AnnouncementCreated"] = true;

            return RedirectToAction("Menimhesabim", "Hesab");
        }

        public async Task<IActionResult> Elan(int? Id)
        {
            if (Id == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            Announcement announcementFromDb = _context.Announcements.Where(ann => ann.IsActive == true).FirstOrDefault(announcement => announcement.Id == Id);

            if(announcementFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
            string activeUserName = User.Identity.Name;

            if(activeUserName != null)
            {
                CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                if (activeUser != null)
                {
                    if (announcementFromDbUser.Id == activeUser.Id)
                    {
                        ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                    }
                }
            }

            AnnouncementViewModel announcementViewModel = new AnnouncementViewModel
            {
                Announcement = announcementFromDb,
                Announcements = _context.Announcements.Where(announcement => announcement.IsActive == true && announcement.EstateId == announcementFromDb.EstateId).OrderByDescending(announce => announce.PublishDate)
            };
            
            announcementViewModel.Announcement.ViewCount++;
            await _context.SaveChangesAsync();

            ViewBag.Cookie = Request.Cookies["***FavouriteAnnouncement***"];
            ViewBag.Alike = announcementFromDb.Estate.EstateName;
            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Durations = _context.Durations;
            ViewBag.Cities = _context.Cities;

            return View(announcementViewModel);
        }
        public async Task<IActionResult> Elangozleyen(int? Id)
        {
            if (Id == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            Announcement announcementFromDb = _context.Announcements.Where(ann => ann.IsActive == false && ann.IsDeleted == false && ann.IsBan == false).FirstOrDefault(announcement => announcement.Id == Id);

            if(announcementFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            if(!User.Identity.IsAuthenticated)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            #region AuthorUser
            CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
            string activeUserName = User.Identity.Name;

            if (activeUserName != null)
            {
                CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                if (activeUser != null)
                {
                    if (announcementFromDbUser.Id == activeUser.Id)
                    {
                        ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                    }
                    else
                    {
                        return View("Views/Xeta/Index.cshtml");
                    }
                }
            }
            #endregion

            //AnnouncementViewModel announcementViewModel = new AnnouncementViewModel
            //{
            //    Announcement = announcementFromDb,
            //    Announcements = _context.Announcements.Where(announcement => announcement.IsActive == true && announcement.EstateId == announcementFromDb.EstateId).OrderByDescending(announce => announce.PublishDate)
            //};

            #region ViewBagForPendingAnnouncement
            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Durations = _context.Durations;
            ViewBag.Cities = _context.Cities;

            ViewBag.AnnouncementId = announcementFromDb.Id;
            ViewBag.SelectedEstateId = announcementFromDb.EstateId;
            ViewBag.SelectedRoomId = announcementFromDb.RoomId;
            ViewBag.AreaForView = announcementFromDb.AreaForView;
            ViewBag.Area = announcementFromDb.Area;
            ViewBag.DurationId = announcementFromDb.DurationId;
            ViewBag.Price = announcementFromDb.Price;
            ViewBag.CityId = announcementFromDb.CityId;
            ViewBag.Details = announcementFromDb.Details;

            ViewBag.EstateName = announcementFromDb.Estate.EstateName;
            ViewBag.DurationType = announcementFromDb.Duration.DurationType;
            ViewBag.CityName = announcementFromDb.City.CityName;
            ViewBag.IsVIP = announcementFromDb.IsVIP;
            ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
            ViewBag.MonthName = announcementFromDb.Month.MonthName;
            ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
            ViewBag.ViewCount = announcementFromDb.ViewCount;

            ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
            ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

            if(announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
            {
                ViewBag.RoomType = announcementFromDb.Room.RoomType;
            }

            ViewBag.CustomUserId = announcementFromDb.CustomUserId;
            ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
            ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
            ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
            ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
            ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
            #endregion


            //announcementViewModel.Announcement.ViewCount++;
            await _context.SaveChangesAsync();

            ViewBag.Cookie = Request.Cookies["***FavouriteAnnouncement***"];
            ViewBag.Alike = announcementFromDb.Estate.EstateName;
            ViewBag.Estates = _context.Estates;
            ViewBag.Rooms = _context.Rooms;
            ViewBag.Durations = _context.Durations;
            ViewBag.Cities = _context.Cities;

            return View();
            //return View(announcementViewModel);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Elanaduzelishet(int? Id, AnnouncementViewModel announcementViewModel)
        {
            if (Id == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            Announcement announcementFromDb = _context.Announcements.Where(announce => announce.IsActive == false && announce.IsDeleted == false && announce.IsBan == false).FirstOrDefault(announcement => announcement.Id == Id);

            if (announcementFromDb == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            if (!ModelState.IsValid)
            {
                #region ViewBagForPendingAnnouncement
                ViewBag.Estates = _context.Estates;
                ViewBag.Rooms = _context.Rooms;
                ViewBag.Durations = _context.Durations;
                ViewBag.Cities = _context.Cities;

                ViewBag.AnnouncementId = announcementFromDb.Id;
                ViewBag.SelectedEstateId = announcementFromDb.EstateId;
                ViewBag.SelectedRoomId = announcementFromDb.RoomId;
                ViewBag.AreaForView = announcementFromDb.AreaForView;
                ViewBag.Area = announcementFromDb.Area;
                ViewBag.DurationId = announcementFromDb.DurationId;
                ViewBag.Price = announcementFromDb.Price;
                ViewBag.CityId = announcementFromDb.CityId;
                ViewBag.Details = announcementFromDb.Details;

                ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                ViewBag.DurationType = announcementFromDb.Duration.DurationType;
                ViewBag.CityName = announcementFromDb.City.CityName;
                ViewBag.IsVIP = announcementFromDb.IsVIP;
                ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
                ViewBag.MonthName = announcementFromDb.Month.MonthName;
                ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
                ViewBag.ViewCount = announcementFromDb.ViewCount;

                ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
                ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

                if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
                {
                    ViewBag.RoomType = announcementFromDb.Room.RoomType;
                }

                ViewBag.CustomUserId = announcementFromDb.CustomUserId;
                ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
                ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
                ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
                ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
                ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
                #endregion

                #region AuthorUser
                CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
                string activeUserName = User.Identity.Name;

                if (activeUserName != null)
                {
                    CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                    if (activeUser != null)
                    {
                        if (announcementFromDbUser.Id == activeUser.Id)
                        {
                            ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                        }
                        else
                        {
                            return View("Views/Xeta/Index.cshtml");
                        }
                    }
                }
                #endregion

                TempData["ValidationError"] = true;

                return View("Elangozleyen", announcementViewModel);

                //return RedirectToAction("Elan", new { Id= Id});
            }
            
            if (announcementViewModel.UploadFiles != null && announcementViewModel.UploadFiles.Count() > 0)
            {
                if (announcementViewModel.UploadFiles.Count() > 20 - announcementFromDb.AnnouncementPhotos.Count())
                {
                    #region ViewBagForPendingAnnouncement
                    ViewBag.Estates = _context.Estates;
                    ViewBag.Rooms = _context.Rooms;
                    ViewBag.Durations = _context.Durations;
                    ViewBag.Cities = _context.Cities;

                    ViewBag.AnnouncementId = announcementFromDb.Id;
                    ViewBag.SelectedEstateId = announcementFromDb.EstateId;
                    ViewBag.SelectedRoomId = announcementFromDb.RoomId;
                    ViewBag.AreaForView = announcementFromDb.AreaForView;
                    ViewBag.Area = announcementFromDb.Area;
                    ViewBag.DurationId = announcementFromDb.DurationId;
                    ViewBag.Price = announcementFromDb.Price;
                    ViewBag.CityId = announcementFromDb.CityId;
                    ViewBag.Details = announcementFromDb.Details;

                    ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                    ViewBag.DurationType = announcementFromDb.Duration.DurationType;
                    ViewBag.CityName = announcementFromDb.City.CityName;
                    ViewBag.IsVIP = announcementFromDb.IsVIP;
                    ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
                    ViewBag.MonthName = announcementFromDb.Month.MonthName;
                    ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
                    ViewBag.ViewCount = announcementFromDb.ViewCount;

                    ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
                    ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

                    if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
                    {
                        ViewBag.RoomType = announcementFromDb.Room.RoomType;
                    }

                    ViewBag.CustomUserId = announcementFromDb.CustomUserId;
                    ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
                    ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
                    ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
                    ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
                    ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
                    #endregion

                    #region AuthorUser
                    CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
                    string activeUserName = User.Identity.Name;

                    if (activeUserName != null)
                    {
                        CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                        if (activeUser != null)
                        {
                            if (announcementFromDbUser.Id == activeUser.Id)
                            {
                                ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                            }
                            else
                            {
                                return View("Views/Xeta/Index.cshtml");
                            }
                        }
                    }
                    #endregion

                    ModelState.AddModelError("UploadFiles", "Elan şəkillərinin(.jpg, .jpeg) sayı 20-dən çox ola bilməz");

                    TempData["ValidationError"] = true;

                    return View("Elangozleyen", announcementViewModel);
                }

                foreach (var file in announcementViewModel.UploadFiles)
                {
                    if (announcementViewModel.UploadFiles.Count() < 4)
                    {
                        #region ViewBagForPendingAnnouncement
                        ViewBag.Estates = _context.Estates;
                        ViewBag.Rooms = _context.Rooms;
                        ViewBag.Durations = _context.Durations;
                        ViewBag.Cities = _context.Cities;

                        ViewBag.AnnouncementId = announcementFromDb.Id;
                        ViewBag.SelectedEstateId = announcementFromDb.EstateId;
                        ViewBag.SelectedRoomId = announcementFromDb.RoomId;
                        ViewBag.AreaForView = announcementFromDb.AreaForView;
                        ViewBag.Area = announcementFromDb.Area;
                        ViewBag.DurationId = announcementFromDb.DurationId;
                        ViewBag.Price = announcementFromDb.Price;
                        ViewBag.CityId = announcementFromDb.CityId;
                        ViewBag.Details = announcementFromDb.Details;

                        ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                        ViewBag.DurationType = announcementFromDb.Duration.DurationType;
                        ViewBag.CityName = announcementFromDb.City.CityName;
                        ViewBag.IsVIP = announcementFromDb.IsVIP;
                        ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
                        ViewBag.MonthName = announcementFromDb.Month.MonthName;
                        ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
                        ViewBag.ViewCount = announcementFromDb.ViewCount;

                        ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
                        ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

                        if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
                        {
                            ViewBag.RoomType = announcementFromDb.Room.RoomType;
                        }

                        ViewBag.CustomUserId = announcementFromDb.CustomUserId;
                        ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
                        ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
                        ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
                        ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
                        ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
                        #endregion

                        #region AuthorUser
                        CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
                        string activeUserName = User.Identity.Name;

                        if (activeUserName != null)
                        {
                            CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                            if (activeUser != null)
                            {
                                if (announcementFromDbUser.Id == activeUser.Id)
                                {
                                    ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                                }
                                else
                                {
                                    return View("Views/Xeta/Index.cshtml");
                                }
                            }
                        }
                        #endregion

                        ModelState.AddModelError("UploadFiles", "Şəkillərin(.jpg, .jpeg) sayı 4-dən az ola bilməz");

                        TempData["ValidationError"] = true;

                        return View("Elangozleyen", announcementViewModel);
                    }

                    if (file.Length > (2 * 1024 * 1024))
                    {
                        #region ViewBagForPendingAnnouncement
                        ViewBag.Estates = _context.Estates;
                        ViewBag.Rooms = _context.Rooms;
                        ViewBag.Durations = _context.Durations;
                        ViewBag.Cities = _context.Cities;

                        ViewBag.AnnouncementId = announcementFromDb.Id;
                        ViewBag.SelectedEstateId = announcementFromDb.EstateId;
                        ViewBag.SelectedRoomId = announcementFromDb.RoomId;
                        ViewBag.AreaForView = announcementFromDb.AreaForView;
                        ViewBag.Area = announcementFromDb.Area;
                        ViewBag.DurationId = announcementFromDb.DurationId;
                        ViewBag.Price = announcementFromDb.Price;
                        ViewBag.CityId = announcementFromDb.CityId;
                        ViewBag.Details = announcementFromDb.Details;

                        ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                        ViewBag.DurationType = announcementFromDb.Duration.DurationType;
                        ViewBag.CityName = announcementFromDb.City.CityName;
                        ViewBag.IsVIP = announcementFromDb.IsVIP;
                        ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
                        ViewBag.MonthName = announcementFromDb.Month.MonthName;
                        ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
                        ViewBag.ViewCount = announcementFromDb.ViewCount;

                        ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
                        ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

                        if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
                        {
                            ViewBag.RoomType = announcementFromDb.Room.RoomType;
                        }

                        ViewBag.CustomUserId = announcementFromDb.CustomUserId;
                        ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
                        ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
                        ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
                        ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
                        ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
                        #endregion

                        #region AuthorUser
                        CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
                        string activeUserName = User.Identity.Name;

                        if (activeUserName != null)
                        {
                            CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                            if (activeUser != null)
                            {
                                if (announcementFromDbUser.Id == activeUser.Id)
                                {
                                    ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                                }
                                else
                                {
                                    return View("Views/Xeta/Index.cshtml");
                                }
                            }
                        }
                        #endregion

                        ModelState.AddModelError("UploadFiles", "Şəklin həcmi 2MB'dan çox ola bilməz.");

                        TempData["ValidationError"] = true;

                        return View("Elangozleyen", announcementViewModel);
                    }

                    if (file.ContentType.Contains("image/jpg") || file.ContentType.Contains("image/jpeg"))
                    {
                        //foreach (var announcementPhotoFile in announcementFromDb.AnnouncementPhotos.ToList())
                        //{
                        //    string announcementPhotoFilePath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "announcements", announcementPhotoFile.AnnouncementPhotoURL);
                        //    if (System.IO.File.Exists(announcementPhotoFilePath))
                        //    {
                        //        System.IO.File.Delete(announcementPhotoFilePath);
                        //    }

                        //    _context.AnnouncementPhotos.Remove(announcementPhotoFile);
                        //    await _context.SaveChangesAsync();
                        //}

                        string folderPath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "announcements");
                        fileName = Guid.NewGuid().ToString() + "_elan_" + file.FileName;
                        string filePath = Path.Combine(folderPath, fileName);

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }

                        AnnouncementPhoto announcementPhoto = new AnnouncementPhoto
                        {
                            AnnouncementPhotoURL = fileName,
                            AnnouncementId = announcementFromDb.Id
                        };

                        await _context.AnnouncementPhotos.AddAsync(announcementPhoto);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        #region ViewBagForPendingAnnouncement
                        ViewBag.Estates = _context.Estates;
                        ViewBag.Rooms = _context.Rooms;
                        ViewBag.Durations = _context.Durations;
                        ViewBag.Cities = _context.Cities;

                        ViewBag.AnnouncementId = announcementFromDb.Id;
                        ViewBag.SelectedEstateId = announcementFromDb.EstateId;
                        ViewBag.SelectedRoomId = announcementFromDb.RoomId;
                        ViewBag.AreaForView = announcementFromDb.AreaForView;
                        ViewBag.Area = announcementFromDb.Area;
                        ViewBag.DurationId = announcementFromDb.DurationId;
                        ViewBag.Price = announcementFromDb.Price;
                        ViewBag.CityId = announcementFromDb.CityId;
                        ViewBag.Details = announcementFromDb.Details;

                        ViewBag.EstateName = announcementFromDb.Estate.EstateName;
                        ViewBag.DurationType = announcementFromDb.Duration.DurationType;
                        ViewBag.CityName = announcementFromDb.City.CityName;
                        ViewBag.IsVIP = announcementFromDb.IsVIP;
                        ViewBag.PublishDateDay = announcementFromDb.PublishDate.Day;
                        ViewBag.MonthName = announcementFromDb.Month.MonthName;
                        ViewBag.PublishDateYear = announcementFromDb.PublishDate.Year;
                        ViewBag.ViewCount = announcementFromDb.ViewCount;

                        ViewBag.AnnouncementPhotosFirst = announcementFromDb.AnnouncementPhotos.FirstOrDefault();
                        ViewBag.AnnouncementPhotos = announcementFromDb.AnnouncementPhotos.ToList();

                        if (announcementFromDb.EstateId == 1 || announcementFromDb.EstateId == 2)
                        {
                            ViewBag.RoomType = announcementFromDb.Room.RoomType;
                        }

                        ViewBag.CustomUserId = announcementFromDb.CustomUserId;
                        ViewBag.CustomUserProfilePictureURL = announcementFromDb.CustomUser.ProfilePictureURL;
                        ViewBag.CustomUserFirstName = announcementFromDb.CustomUser.FirstName;
                        ViewBag.CustomUserLastName = announcementFromDb.CustomUser.LastName;
                        ViewBag.CustomUserEmail = announcementFromDb.CustomUser.Email;
                        ViewBag.CustomUserPhoneNumber = announcementFromDb.CustomUser.PhoneNumber;
                        #endregion

                        #region AuthorUser
                        CustomUser announcementFromDbUser = await _userManager.FindByIdAsync(announcementFromDb.CustomUserId);
                        string activeUserName = User.Identity.Name;

                        if (activeUserName != null)
                        {
                            CustomUser activeUser = await _userManager.FindByNameAsync(activeUserName);
                            if (activeUser != null)
                            {
                                if (announcementFromDbUser.Id == activeUser.Id)
                                {
                                    ViewBag.AuthorUser = await _userManager.FindByIdAsync(activeUser.Id);
                                }
                                else
                                {
                                    return View("Views/Xeta/Index.cshtml");
                                }
                            }
                        }
                        #endregion

                        ModelState.AddModelError("UploadFiles", "Zəhmət olmasa, .jpg / .jpeg formatda şəkil yükləyin");

                        TempData["ValidationError"] = true;

                        return View("Elangozleyen", announcementViewModel);
                    }
                }
            }

            announcementFromDb.IsVIP = announcementViewModel.IsVIP;
            announcementFromDb.Details = announcementViewModel.Details;
            announcementFromDb.Price = announcementViewModel.Price;
            announcementFromDb.UpdateDate = DateTime.Now;
            announcementFromDb.EstateId = announcementViewModel.EstateId;
            announcementFromDb.DurationId = announcementViewModel.DurationId;
            announcementFromDb.CityId = announcementViewModel.CityId;
            announcementFromDb.MonthId = DateTime.Now.Month;

            if (announcementViewModel.EstateId == 1 || announcementViewModel.EstateId == 2)
            {
                announcementFromDb.Area = announcementViewModel.Area;
                announcementFromDb.AreaForView = announcementViewModel.Area;
                announcementFromDb.RoomId = announcementViewModel.RoomId;
            }
            else
            {
                announcementFromDb.Area = announcementViewModel.AreaForView;
                announcementFromDb.AreaForView = announcementViewModel.AreaForView;
            }

            announcementFromDb.IsActive = false;
            announcementFromDb.IsDeleted = false;
            announcementFromDb.IsBan = false;

            await _context.SaveChangesAsync();

            TempData["AnnouncementUpdated"] = true;

            return RedirectToAction("Menimhesabim", "Hesab");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Elanisil(int? Id)
        {
            if (Id == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            Announcement announcementToBeDeleted = _context.Announcements.Where(announce => announce.IsActive == false && announce.IsDeleted == false && announce.IsBan == false).FirstOrDefault(announcement => announcement.Id == Id);

            if (announcementToBeDeleted == null)
            {
                return View("Views/Xeta/Index.cshtml");
            }

            //foreach (var announcementPhoto in announcementToBeDeleted.AnnouncementPhotos.ToList())
            //{
            //    _context.AnnouncementPhotos.Remove(announcementPhoto);
            //    await _context.SaveChangesAsync();

            //    string announcementPhotoFilePath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "announcements", announcementPhoto.AnnouncementPhotoURL);
            //    if (System.IO.File.Exists(announcementPhotoFilePath))
            //    {
            //        System.IO.File.Delete(announcementPhotoFilePath);
            //    }
            //}

            //_context.Announcements.Remove(announcementToBeDeleted);
            announcementToBeDeleted.IsActive = false;
            announcementToBeDeleted.IsDeleted = true;
            announcementToBeDeleted.IsBan = false;

            await _context.SaveChangesAsync();

            TempData["AnnouncementDeleted"] = true;

            return RedirectToAction("Menimhesabim", "Hesab");
        }
        public async Task<IActionResult> Istifadechininelanlari(string userId)
        {
            CustomUser customUserFromDb = await _userManager.FindByIdAsync(userId);

            ViewBag.Cookie = Request.Cookies["***FavouriteAnnouncement***"];

            return View(customUserFromDb);
        }
    }
}