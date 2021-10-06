using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TblEExitStatus
    {
        public TblEExitStatus()
        {
            Employee = new HashSet<Employee>();
            TbEmployeeExitRecord = new HashSet<TbEmployeeExitRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbEmployeeExitRecord> TbEmployeeExitRecord { get; set; }
    }
}
