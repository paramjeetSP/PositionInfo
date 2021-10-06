using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class Balanceleave1
    {
        public int? EmpId { get; set; }
        public decimal? CasualLeavesLeft { get; set; }
        public decimal? SickLeavesLeft { get; set; }
        public decimal? PaidLeavesLeft { get; set; }
    }
}
