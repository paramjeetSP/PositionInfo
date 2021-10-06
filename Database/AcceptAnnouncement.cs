using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AcceptAnnouncement
    {
        public int Id { get; set; }
        public int? FkAnnouncement { get; set; }
        public int? FkEmp { get; set; }
        public DateTime? AcceptDateTime { get; set; }

        public virtual Announcement FkAnnouncementNavigation { get; set; }
        public virtual Employee FkEmpNavigation { get; set; }
    }
}
