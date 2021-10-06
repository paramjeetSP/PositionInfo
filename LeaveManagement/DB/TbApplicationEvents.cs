using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
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
