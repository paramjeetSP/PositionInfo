using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AmsemailQueue
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? EventId { get; set; }
        public DateTime? PendingDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsEmailSent { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsActive { get; set; }
        public int? EmailType { get; set; }
        public int? FkEmployeeId { get; set; }
        public int? ManagerId { get; set; }
        public string ReasonforReject { get; set; }
    }
}
