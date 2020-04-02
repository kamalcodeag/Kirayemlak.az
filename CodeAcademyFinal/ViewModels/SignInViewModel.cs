using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), EmailAddress(ErrorMessage = "Zəhmət olmasa, düzgün email daxil edin."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
