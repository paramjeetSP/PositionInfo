using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class ReminderAlert
    {
        public int Id { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? Status { get; set; }
    }
}
