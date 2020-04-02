using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Areas.Admin.ViewModels
{
    public class AdminEmployeeViewModel
    {
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), StringLength(50, ErrorMessage = "Yazının uzunluğu 50 simvoldan uzun ola bilməz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), EmailAddress(ErrorMessage = "Zəhmət olmasa, düzgün email daxil edin."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password), Compare("Password", ErrorMessage = "Daxil etdiyiniz şifrə ilə uyğun gəlmir")]
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
    }
}
