using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class CustomUser : IdentityUser
    {
        public CustomUser()
        {
            Announcements = new HashSet<Announcement>();
        }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(50, ErrorMessage = "Yazının uzunluğu 50 simvoldan uzun ola bilməz")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Yazının uzunluğu 50 simvoldan uzun ola bilməz")]
        public string LastName { get; set; }
        public string ProfilePictureURL { get; set; }
        public int? MobileOperatorId { get; set; }
        public virtual MobileOperator MobileOperator { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
