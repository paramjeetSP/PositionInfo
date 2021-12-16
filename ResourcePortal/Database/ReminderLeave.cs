using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class ReminderLeave
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int? FkLeavestatus { get; set; }
        public string LineManager { get; set; }
        public bool? Status { get; set; }
        public DateTime? CurrentDate { get; set; }

        public LeaveStatus FkLeavestatusNavigation { get; set; }
    }
}
