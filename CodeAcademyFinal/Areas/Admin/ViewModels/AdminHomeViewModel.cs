using CodeAcademyFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Areas.Admin.ViewModels
{
    public class AdminHomeViewModel
    {
        public int NumberOfCustomUsers { get; set; }
        public int NumberOfMessages { get; set; }
        public decimal NumberOfAnnouncements { get; set; }
        public decimal NumberOfPendingAnnouncements { get; set; }
        public decimal NumberOfActiveAnnouncements { get; set; }
        public decimal NumberOfDeletedAnnouncements { get; set; }
        public decimal NumberOfBanAnnouncements { get; set; }
    }
}
