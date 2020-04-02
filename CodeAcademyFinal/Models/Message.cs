using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(100, ErrorMessage = "Yazının uzunluğu 100 simvoldan uzun ola bilməz")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), EmailAddress(ErrorMessage = "Zəhmət olmasa, düzgün email daxil edin."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(100, ErrorMessage = "Yazının uzunluğu 100 simvoldan uzun ola bilməz")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(2500, ErrorMessage = "Yazının uzunluğu 2500 simvoldan uzun ola bilməz")]
        public string MessageText { get; set; }
        public DateTime SentTime { get; set; }

    }
}
