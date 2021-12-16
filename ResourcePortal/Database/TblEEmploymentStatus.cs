using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblEEmploymentStatus
    {
        public TblEEmploymentStatus()
        {
            Employee = new HashSet<Employee>();
            TbEmployeeStatusRecord = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
    }
}
