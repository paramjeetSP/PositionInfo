using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class LeadNotification
    {
        public int Id { get; set; }
        public int? LeadId { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public bool? IsRead { get; set; }
    }
}
