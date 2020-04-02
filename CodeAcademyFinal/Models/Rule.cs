using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Rule
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa, boşluğu doldurun")]
        public string RuleText { get; set; }
    }
}
