using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEGrade
    {
        public TblEGrade()
        {
            AssessmentCriteria = new HashSet<AssessmentCriterion>();
            DesignationHistories = new HashSet<DesignationHistory>();
            Employees = new HashSet<Employee>();
            TbEmployeeStatusRecords = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual AppraisalInterval AppraisalInterval { get; set; }
        public virtual ICollection<AssessmentCriterion> AssessmentCriteria { get; set; }
        public virtual ICollection<DesignationHistory> DesignationHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecords { get; set; }
    }
}
