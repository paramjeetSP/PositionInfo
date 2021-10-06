using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEDepartment
    {
        public TblEDepartment()
        {
            Employees = new HashSet<Employee>();
            TbEmployeeAppraisalRecords = new HashSet<TbEmployeeAppraisalRecord>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DepartmentHead { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TbEmployeeAppraisalRecord> TbEmployeeAppraisalRecords { get; set; }
    }
}
