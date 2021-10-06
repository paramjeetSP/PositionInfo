using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AmsemailFailureRecord
    {
        public int Id { get; set; }
        public int? QueueId { get; set; }
        public string Reason { get; set; }
    }
}
