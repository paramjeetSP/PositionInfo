using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TbApplicationEvents
    {
        public TbApplicationEvents()
        {
            TbEmailQueue = new HashSet<TbEmailQueue>();
            TbTemplates = new HashSet<TbTemplates>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }

        public ICollection<TbEmailQueue> TbEmailQueue { get; set; }
        public ICollection<TbTemplates> TbTemplates { get; set; }
    }
}
