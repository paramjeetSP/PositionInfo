using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblELeaveType
    {
        public TblELeaveType()
        {
            BalanceLeaves = new HashSet<BalanceLeave>();
            DetailedLeaveStatuses = new HashSet<DetailedLeaveStatus>();
            LeaveStatuses = new HashSet<LeaveStatus>();
            LeavesQuota = new HashSet<LeavesQuotum>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        public virtual ICollection<BalanceLeave> BalanceLeaves { get; set; }
        public virtual ICollection<DetailedLeaveStatus> DetailedLeaveStatuses { get; set; }
        public virtual ICollection<LeaveStatus> LeaveStatuses { get; set; }
        public virtual ICollection<LeavesQuotum> LeavesQuota { get; set; }
    }
}
