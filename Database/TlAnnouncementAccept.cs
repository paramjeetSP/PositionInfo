using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TlAnnouncementAccept
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public DateTime? AcceptDate { get; set; }
        public bool? IsAgree { get; set; }
        public int? FkAnnouncement { get; set; }

        public virtual TlAnnouncement FkAnnouncementNavigation { get; set; }
    }
}
