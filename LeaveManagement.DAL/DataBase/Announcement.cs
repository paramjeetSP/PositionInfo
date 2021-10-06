using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class Announcement
    {
        public Announcement()
        {
            AcceptAnnouncement = new HashSet<AcceptAnnouncement>();
        }

        public int Id { get; set; }
        public string AnnouncementContent { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AnnouncementDate { get; set; }

        public ICollection<AcceptAnnouncement> AcceptAnnouncement { get; set; }
    }
}
