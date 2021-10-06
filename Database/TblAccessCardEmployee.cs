using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblAccessCardEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CardNo { get; set; }
        public string PersonCode { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
