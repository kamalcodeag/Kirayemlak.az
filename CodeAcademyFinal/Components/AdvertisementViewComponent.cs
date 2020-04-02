using CodeAcademyFinal.DAL;
using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Views.Shared.Components
{
    public class AdvertisementViewComponent : ViewComponent
    {
        private readonly RentEstateDb _context;

        public AdvertisementViewComponent(RentEstateDb context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            Advertisement advertisementFromDb = _context.Advertisements.FirstOrDefault();

            return View("Default", advertisementFromDb);
        }
    }
}
