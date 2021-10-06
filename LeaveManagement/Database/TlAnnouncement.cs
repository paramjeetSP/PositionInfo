using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TlAnnouncement
    {
        public TlAnnouncement()
        {
            TlAnnouncementAccept = new HashSet<TlAnnouncementAccept>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Contents { get; set; }

        public ICollection<TlAnnouncementAccept> TlAnnouncementAccept { get; set; }
    }
}
