using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEAppraisalRating
    {
        public TblEAppraisalRating()
        {
            PerformanceAppraisals = new HashSet<PerformanceAppraisal>();
            PerformanceEvaluationReviewerRatingNavigations = new HashSet<PerformanceEvaluation>();
            PerformanceEvaluationSelfRatingNavigations = new HashSet<PerformanceEvaluation>();
        }

        public int Id { get; set; }
        public string AppraisalMetric { get; set; }

        public virtual ICollection<PerformanceAppraisal> PerformanceAppraisals { get; set; }
        public virtual ICollection<PerformanceEvaluation> PerformanceEvaluationReviewerRatingNavigations { get; set; }
        public virtual ICollection<PerformanceEvaluation> PerformanceEvaluationSelfRatingNavigations { get; set; }
    }
}
