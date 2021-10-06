using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
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

        public virtual AssessmentCriterion FkAssessmentCriteriaNavigation { get; set; }
        public virtual PerformanceAppraisal FkPerformanceAppraisalNavigation { get; set; }
        public virtual TblEAppraisalRating ReviewerRatingNavigation { get; set; }
        public virtual TblEAppraisalRating SelfRatingNavigation { get; set; }
    }
}
