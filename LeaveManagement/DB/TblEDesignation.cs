using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblEDesignation
    {
        public TblEDesignation()
        {
            Employee = new HashSet<Employee>();
            TbChangeDesignation = new HashSet<TbChangeDesignation>();
            TbEmployeeStatusRecord = new HashSet<TbEmployeeStatusRecord>();
            TbNoticePeriod = new HashSet<TbNoticePeriod>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbChangeDesignation> TbChangeDesignation { get; set; }
        public ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
        public ICollection<TbNoticePeriod> TbNoticePeriod { get; set; }
    }
}
