using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReklamController : Controller
    {
        private readonly RentEstateDb _context;
        private readonly IHostingEnvironment _env;

        public ReklamController(RentEstateDb context,
                                IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewBag.Advertisement = "Advertisement";

            Advertisement advertisementFromDb = _context.Advertisements.FirstOrDefault();
            ViewBag.AdvertisementURL = advertisementFromDb.AdvertisementURL;
            ViewBag.AdvertisementId = advertisementFromDb.Id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int? Id, Advertisement advertisement)
        {
            ViewBag.Advertisement = "Advertisement";
            Advertisement advertisementFromDb = _context.Advertisements.FirstOrDefault(advs => advs.Id == Id);
            ViewBag.AdvertisementURL = advertisementFromDb.AdvertisementURL;
            ViewBag.AdvertisementId = advertisementFromDb.Id;

            if (Id != null)
            {
                if (advertisement.UploadFile == null)
                {
                    ViewBag.Advertisement = "Advertisement";
                    ViewBag.AdvertisementURL = advertisementFromDb.AdvertisementURL;
                    ModelState.AddModelError("UploadFile", "Zəhmət olmasa, şəkil yükləyin");
                    return View(advertisement);
                }

                if (advertisement.UploadFile.Length > 2 * 1024 * 1024)
                {
                    ViewBag.Advertisement = "Advertisement";
                    ViewBag.AdvertisementURL = advertisementFromDb.AdvertisementURL;
                    ModelState.AddModelError("UploadFile", "Şəklin həcmi 2MB'dan çox ola bilməz");
                    return View(advertisement);
                }

                if (advertisement.UploadFile.ContentType.Contains("image/jpg") || advertisement.UploadFile.ContentType.Contains("image/jpeg"))
                {
                    string folderPath = Path.Combine(_env.WebRootPath, "MainPageFiles", "images", "advertisements");
                    string fileName = Guid.NewGuid().ToString() + "_reklam_" + advertisement.UploadFile.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await advertisement.UploadFile.CopyToAsync(fileStream);
                    }

                    advertisementFromDb.AdvertisementURL = fileName;
                    await _context.SaveChangesAsync();
                    TempData["AdvertisementUpdated"] = true;
                }
                else
                {
                    ViewBag.Advertisement = "Advertisement";
                    ViewBag.AdvertisementURL = advertisementFromDb.AdvertisementURL;
                    ModelState.AddModelError("UploadFile", "Zəhmət olmasa, tələb olunan formatda şəkil yükləyin");
                    return View(advertisement);
                }
            }

            return RedirectToAction("Index", "Reklam");
        }
    }
}