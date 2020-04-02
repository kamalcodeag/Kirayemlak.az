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
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(50, ErrorMessage = "Yazının uzunluğu 50 simvoldan uzun ola bilməz")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Yazının uzunluğu 50 simvoldan uzun ola bilməz")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), EmailAddress(ErrorMessage = "Zəhmət olmasa, düzgün email daxil edin."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int? MobileOperatorId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), MinLength(7, ErrorMessage = "Zəhmət olmasa, düzgün telefon nömrəsi daxil edin."), MaxLength(7, ErrorMessage = "Zəhmət olmasa, düzgün telefon nömrəsi daxil edin."), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password), Compare("Password", ErrorMessage = "Daxil etdiyiniz şifrə ilə uyğun gəlmir")]
        public string ConfirmPassword { get; set; }
        [NotMapped, DataType(DataType.Upload)]
        public IFormFile UploadFile { get; set; }
    }
}
