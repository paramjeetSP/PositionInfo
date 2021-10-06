using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AssessmentCriterion
    {
        public AssessmentCriterion()
        {
            PerformanceEvaluations = new HashSet<PerformanceEvaluation>();
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

        public virtual AssessmentRevision FkAssessmentRevisionNavigation { get; set; }
        public virtual TblEGrade FkGradeNavigation { get; set; }
        public virtual ICollection<PerformanceEvaluation> PerformanceEvaluations { get; set; }
    }
}
