using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Estate
    {
        public Estate()
        {
            Announcements = new HashSet<Announcement>();
        }
        public int Id { get; set; }
        public string EstateName { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
