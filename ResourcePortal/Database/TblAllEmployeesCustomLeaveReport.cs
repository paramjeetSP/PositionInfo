using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblAllEmployeesCustomLeaveReport
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? DeptId { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        public decimal? TotalAllocatedLeaves { get; set; }
        public decimal? TotalLeavesTaken { get; set; }
        public decimal? CasualLeavesTaken { get; set; }
        public decimal? SickLeavesTaken { get; set; }
        public decimal? PaidLeavesTaken { get; set; }
        public decimal? Lwptaken { get; set; }
    }
}
