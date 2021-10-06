using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class LeaveBalance
    {
        public int Id { get; set; }
        public DateTime? StartDateMonth { get; set; }
        public DateTime? EndDateMonth { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
