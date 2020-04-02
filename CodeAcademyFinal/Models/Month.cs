using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Month
    {
        public Month()
        {
            Announcements = new HashSet<Announcement>();
        }
        public int Id { get; set; }
        public string MonthName { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
