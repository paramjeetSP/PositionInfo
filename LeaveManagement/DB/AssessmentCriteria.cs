using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class AssessmentCriteria
    {
        public AssessmentCriteria()
        {
            PerformanceEvaluation = new HashSet<PerformanceEvaluation>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? FkGrade { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? FkAssessmentRevision { get; set; }

        public AssessmentRevision FkAssessmentRevisionNavigation { get; set; }
        public TblEGrade FkGradeNavigation { get; set; }
        public ICollection<PerformanceEvaluation> PerformanceEvaluation { get; set; }
    }
}
