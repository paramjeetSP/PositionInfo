using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class AppraisalInterval
    {
        public int FkGrade { get; set; }
        public int? MonthCount { get; set; }

        public TblEGrade FkGradeNavigation { get; set; }
    }
}
