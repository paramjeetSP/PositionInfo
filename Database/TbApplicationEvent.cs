using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbApplicationEvent
    {
        public TbApplicationEvent()
        {
            TbEmailQueues = new HashSet<TbEmailQueue>();
            TbTemplates = new HashSet<TbTemplate>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }

        public virtual ICollection<TbEmailQueue> TbEmailQueues { get; set; }
        public virtual ICollection<TbTemplate> TbTemplates { get; set; }
    }
}
