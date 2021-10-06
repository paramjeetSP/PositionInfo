using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class BalanceLeave
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? LeaveType { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Description { get; set; }

        public virtual Employee Emp { get; set; }
        public virtual TblELeaveType LeaveTypeNavigation { get; set; }
    }
}
