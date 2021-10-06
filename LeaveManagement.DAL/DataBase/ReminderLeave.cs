using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
