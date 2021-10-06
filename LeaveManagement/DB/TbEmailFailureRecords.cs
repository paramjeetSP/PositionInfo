using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TbEmailFailureRecords
    {
        public int Id { get; set; }
        public int QueueId { get; set; }
        public string FailureRecords { get; set; }

        public TbEmailQueue Queue { get; set; }
    }
}
