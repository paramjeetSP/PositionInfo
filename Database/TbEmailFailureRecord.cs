using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmailFailureRecord
    {
        public int Id { get; set; }
        public int QueueId { get; set; }
        public string FailureRecords { get; set; }

        public virtual TbEmailQueue Queue { get; set; }
    }
}
