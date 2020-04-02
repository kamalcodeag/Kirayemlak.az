using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Room
    {
        public Room()
        {
            Announcements = new HashSet<Announcement>();
        }
        public int Id { get; set; }
        public string RoomType { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
