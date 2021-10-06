using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class AppraisalInterval
    {
        public int FkGrade { get; set; }
        public int? MonthCount { get; set; }

        public TblEGrade FkGradeNavigation { get; set; }
    }
}
