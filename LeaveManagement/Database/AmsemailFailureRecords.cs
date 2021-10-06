using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class AmsemailFailureRecords
    {
        public int Id { get; set; }
        public int? QueueId { get; set; }
        public string Reason { get; set; }
    }
}
