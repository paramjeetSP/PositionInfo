using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TbEmailFailureRecords
    {
        public int Id { get; set; }
        public int QueueId { get; set; }
        public string FailureRecords { get; set; }

        public TbEmailQueue Queue { get; set; }
    }
}
