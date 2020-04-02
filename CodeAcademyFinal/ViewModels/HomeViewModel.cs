using CodeAcademyFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.ViewModels
{
    public class HomeViewModel
    {
        public IQueryable<Announcement> VIP_Announcements { get; set; }
        public IQueryable<Announcement> RecentAnnouncements { get; set; }
        public IQueryable<Announcement> MostViewedAnnouncements { get; set; }
    }
}
