using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblHTimeLog
    {
        public int? Id { get; set; }
        public string TimeBreak { get; set; }
        public string FkEmpId { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public string WorkingHours { get; set; }
        public string ProductiveHours { get; set; }
        public string LoginIp { get; set; }
        public string LogoutIp { get; set; }
        public DateTime? CurrentDate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Earlycheckoutreson { get; set; }
    }
}
