using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class ChangedEmployeeDepartment
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int OldDeptId { get; set; }
        public int NewDeptId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
