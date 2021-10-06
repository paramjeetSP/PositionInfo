using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblEDesignation
    {
        public TblEDesignation()
        {
            DesignationHistory = new HashSet<DesignationHistory>();
            Employee = new HashSet<Employee>();
            TbChangeDesignation = new HashSet<TbChangeDesignation>();
            TbEmployeeStatusRecord = new HashSet<TbEmployeeStatusRecord>();
            TbNoticePeriod = new HashSet<TbNoticePeriod>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<DesignationHistory> DesignationHistory { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbChangeDesignation> TbChangeDesignation { get; set; }
        public ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
        public ICollection<TbNoticePeriod> TbNoticePeriod { get; set; }
    }
}
