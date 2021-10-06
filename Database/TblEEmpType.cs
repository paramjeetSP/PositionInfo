using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEEmpType
    {
        public TblEEmpType()
        {
            Employees = new HashSet<Employee>();
            TbEmployeeStatusRecords = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecords { get; set; }
    }
}
