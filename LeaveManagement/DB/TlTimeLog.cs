using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TlTimeLog
    {
        public int Id { get; set; }
        public string TimeBreak { get; set; }
        public string FkEmpId { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public string WorkingHours { get; set; }
        public string ProductiveHours { get; set; }
        public string LoginIp { get; set; }
        public string LogoutIp { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Earlycheckoutreson { get; set; }
        public string Userip { get; set; }
    }
}
