using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class MobileOperator
    {
        public MobileOperator()
        {
            CustomUsers = new HashSet<CustomUser>();
        }
        public int Id { get; set; }
        public string MobileOperatorCode { get; set; }
        public virtual ICollection<CustomUser> CustomUsers { get; set; }
    }
}
