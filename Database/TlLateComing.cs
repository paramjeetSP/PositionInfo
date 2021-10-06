using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
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
