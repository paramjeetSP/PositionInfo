using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblAccessCardEmployees
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CardNo { get; set; }
        public string PersonCode { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
