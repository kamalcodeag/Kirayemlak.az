using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Announcement
    {
        public Announcement()
        {
            AnnouncementPhotos = new HashSet<AnnouncementPhoto>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public decimal? Area { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public decimal? AreaForView { get; set; }
        public bool IsVIP { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(2500, ErrorMessage = "Yazının uzunluğu 2500 simvoldan uzun ola bilməz")]
        public string Details { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public int? Price { get; set; }
        public long? ViewCount { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBan { get; set; }
        public int? EstateId { get; set; }
        public virtual Estate Estate { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int? DurationId { get; set; }
        public virtual Duration Duration { get; set; }
        public int? CityId { get; set; }
        public virtual City City { get; set; }
        public int? MonthId { get; set; }
        public virtual Month Month { get; set; }
        public string CustomUserId { get; set; }
        public virtual CustomUser CustomUser { get; set; }
        public virtual ICollection<AnnouncementPhoto> AnnouncementPhotos { get; set; }
    }
}
