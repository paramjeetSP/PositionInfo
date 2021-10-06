using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class Announcement
    {
        public Announcement()
        {
            AcceptAnnouncements = new HashSet<AcceptAnnouncement>();
        }

        public int Id { get; set; }
        public string AnnouncementContent { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AnnouncementDate { get; set; }

        public virtual ICollection<AcceptAnnouncement> AcceptAnnouncements { get; set; }
    }
}
