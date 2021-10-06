using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AppraisalInterval
    {
        public int FkGrade { get; set; }
        public int? MonthCount { get; set; }

        public virtual TblEGrade FkGradeNavigation { get; set; }
    }
}
