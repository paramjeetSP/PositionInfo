using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
