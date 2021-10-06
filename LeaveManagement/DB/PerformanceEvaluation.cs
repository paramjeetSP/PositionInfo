using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class PerformanceEvaluation
    {
        public int Id { get; set; }
        public int? FkPerformanceAppraisal { get; set; }
        public int? FkAssessmentCriteria { get; set; }
        public int? SelfRating { get; set; }
        public string SelfComment { get; set; }
        public int? ReviewerRating { get; set; }
        public string ReviewerComment { get; set; }

        public AssessmentCriteria FkAssessmentCriteriaNavigation { get; set; }
        public PerformanceAppraisal FkPerformanceAppraisalNavigation { get; set; }
        public TblEAppraisalRating ReviewerRatingNavigation { get; set; }
        public TblEAppraisalRating SelfRatingNavigation { get; set; }
    }
}
