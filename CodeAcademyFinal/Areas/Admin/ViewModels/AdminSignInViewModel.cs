using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Areas.Admin.ViewModels
{
    public class AdminSignInViewModel
    {
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
