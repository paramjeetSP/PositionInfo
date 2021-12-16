using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class LeavesQuota
    {
        public int Id { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public int? FkLeaveType { get; set; }
        public int? MaxLimit { get; set; }

        public TblELeaveType FkLeaveTypeNavigation { get; set; }
    }
}
