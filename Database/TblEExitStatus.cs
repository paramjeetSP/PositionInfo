using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEExitStatus
    {
        public TblEExitStatus()
        {
            Employees = new HashSet<Employee>();
            TbEmployeeExitRecords = new HashSet<TbEmployeeExitRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TbEmployeeExitRecord> TbEmployeeExitRecords { get; set; }
    }
}
