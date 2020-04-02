using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.ViewModels
{
    public class AnnouncementViewModel
    {
        public Announcement Announcement { get; set; }
        public IQueryable<Announcement> Announcements { get; set; }
        public int EstateId { get; set; }
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public decimal? AreaForView { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public decimal? Area { get; set; }
        public int DurationId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public int? Price { get; set; }
        public int CityId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(2500, ErrorMessage = "Yazının uzunluğu 2500 simvoldan uzun ola bilməz")]
        public string Details { get; set; }
        public bool IsVIP { get; set; }
        [NotMapped, DataType(DataType.Upload)]
        public ICollection<IFormFile> UploadFiles { get; set; }
    }
}
