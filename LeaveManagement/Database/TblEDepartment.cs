using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblEDepartment
    {
        public TblEDepartment()
        {
            Employee = new HashSet<Employee>();
            TbEmployeeAppraisalRecords = new HashSet<TbEmployeeAppraisalRecords>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DepartmentHead { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbEmployeeAppraisalRecords> TbEmployeeAppraisalRecords { get; set; }
    }
}
