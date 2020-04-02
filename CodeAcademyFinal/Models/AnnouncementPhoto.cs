using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class AnnouncementPhoto
    {
        public int Id { get; set; }
        public string AnnouncementPhotoURL { get; set; }
        public int? AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
