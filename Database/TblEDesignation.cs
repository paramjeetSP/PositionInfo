using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEDesignation
    {
        public TblEDesignation()
        {
            DesignationHistories = new HashSet<DesignationHistory>();
            Employees = new HashSet<Employee>();
            TbChangeDesignations = new HashSet<TbChangeDesignation>();
            TbEmployeeStatusRecords = new HashSet<TbEmployeeStatusRecord>();
            TbNoticePeriods = new HashSet<TbNoticePeriod>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DesignationHistory> DesignationHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TbChangeDesignation> TbChangeDesignations { get; set; }
        public virtual ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecords { get; set; }
        public virtual ICollection<TbNoticePeriod> TbNoticePeriods { get; set; }
    }
}
