using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TlLateComing
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Reason { get; set; }
        public bool? IsApproved { get; set; }
    }
}
