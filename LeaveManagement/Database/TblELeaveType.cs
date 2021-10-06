using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblELeaveType
    {
        public TblELeaveType()
        {
            BalanceLeave1 = new HashSet<BalanceLeave1>();
            DetailedLeaveStatus = new HashSet<DetailedLeaveStatus>();
            LeaveStatus = new HashSet<LeaveStatus>();
            LeavesQuota = new HashSet<LeavesQuota>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? Count { get; set; }

        public ICollection<BalanceLeave1> BalanceLeave1 { get; set; }
        public ICollection<DetailedLeaveStatus> DetailedLeaveStatus { get; set; }
        public ICollection<LeaveStatus> LeaveStatus { get; set; }
        public ICollection<LeavesQuota> LeavesQuota { get; set; }
    }
}
