using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblELeaveType
    {
        public TblELeaveType()
        {
            LeaveStatus = new HashSet<LeaveStatus>();
            LeavesQuota = new HashSet<LeavesQuota>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        public ICollection<LeaveStatus> LeaveStatus { get; set; }
        public ICollection<LeavesQuota> LeavesQuota { get; set; }
    }
}
