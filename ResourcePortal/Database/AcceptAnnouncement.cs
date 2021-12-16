using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class AcceptAnnouncement
    {
        public int Id { get; set; }
        public int? FkAnnouncement { get; set; }
        public int? FkEmp { get; set; }
        public DateTime? AcceptDateTime { get; set; }

        public Announcement FkAnnouncementNavigation { get; set; }
        public Employee FkEmpNavigation { get; set; }
        public AcceptAnnouncement IdNavigation { get; set; }
        public AcceptAnnouncement InverseIdNavigation { get; set; }
    }
}
