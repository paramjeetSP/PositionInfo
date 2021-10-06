using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TblEAppraisalRating
    {
        public TblEAppraisalRating()
        {
            PerformanceAppraisal = new HashSet<PerformanceAppraisal>();
            PerformanceEvaluationReviewerRatingNavigation = new HashSet<PerformanceEvaluation>();
            PerformanceEvaluationSelfRatingNavigation = new HashSet<PerformanceEvaluation>();
        }

        public int Id { get; set; }
        public string AppraisalMetric { get; set; }

        public ICollection<PerformanceAppraisal> PerformanceAppraisal { get; set; }
        public ICollection<PerformanceEvaluation> PerformanceEvaluationReviewerRatingNavigation { get; set; }
        public ICollection<PerformanceEvaluation> PerformanceEvaluationSelfRatingNavigation { get; set; }
    }
}
