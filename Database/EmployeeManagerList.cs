using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class EmployeeManagerList
    {
        public int Id { get; set; }
        public int? DeptId { get; set; }
        public int? ManagerId { get; set; }
        public int? EmployeeId { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
