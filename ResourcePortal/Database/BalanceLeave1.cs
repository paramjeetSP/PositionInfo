using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class BalanceLeave1
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? LeaveType { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Description { get; set; }

        public Employee Emp { get; set; }
        public TblELeaveType LeaveTypeNavigation { get; set; }
    }
}
