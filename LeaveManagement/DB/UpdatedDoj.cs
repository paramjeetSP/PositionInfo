using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class UpdatedDoj
    {
        public int Id { get; set; }
        public int? Fkempid { get; set; }
        public DateTime? UpdatedDoj1 { get; set; }
        public DateTime? ActualDoj { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
