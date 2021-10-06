using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblEGrade
    {
        public TblEGrade()
        {
            AssessmentCriteria = new HashSet<AssessmentCriteria>();
            DesignationHistory = new HashSet<DesignationHistory>();
            Employee = new HashSet<Employee>();
            TbEmployeeStatusRecord = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public AppraisalInterval AppraisalInterval { get; set; }
        public ICollection<AssessmentCriteria> AssessmentCriteria { get; set; }
        public ICollection<DesignationHistory> DesignationHistory { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
    }
}
