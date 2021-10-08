using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Database
{
    public partial class HrpositionInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }
        public string Skills { get; set; }
        public string Department { get; set; }
        public int? NoOfPosition { get; set; }
        public string Priority { get; set; }
        public string Budget { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ExpectedDate { get; set; }
        public string Experience { get; set; }
        public string Status { get; set; }
        public string RequestedBy { get; set; }
    }
}
