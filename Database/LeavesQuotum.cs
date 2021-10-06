using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class LeavesQuotum
    {
        public int Id { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public int? FkLeaveType { get; set; }
        public int? MaxLimit { get; set; }

        public virtual TblELeaveType FkLeaveTypeNavigation { get; set; }
    }
}
