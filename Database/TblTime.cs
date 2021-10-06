using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblTime
    {
        public DateTime? LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public string LoginTime { get; set; }
        public string LogoutTime { get; set; }
        public string WorkingHrs { get; set; }
        public string TotalBreaks { get; set; }
        public string ProductiveHrs { get; set; }
        public string EmpId { get; set; }
    }
}
