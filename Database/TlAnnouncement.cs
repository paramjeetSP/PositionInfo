using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TlAnnouncement
    {
        public TlAnnouncement()
        {
            TlAnnouncementAccepts = new HashSet<TlAnnouncementAccept>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Contents { get; set; }

        public virtual ICollection<TlAnnouncementAccept> TlAnnouncementAccepts { get; set; }
    }
}
