using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblAccessCardEvents
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public DateTime? EventTime { get; set; }
        public int? Modify { get; set; }
        public int? EmployeeId { get; set; }
        public string EventCh { get; set; }
        public int? DoorId { get; set; }
        public string DoorName { get; set; }
    }
}
