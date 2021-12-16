using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class PerformanceAppraisal
    {
        public PerformanceAppraisal()
        {
            PerformanceEvaluation = new HashSet<PerformanceEvaluation>();
        }

        public int Id { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string AppraisalComment { get; set; }
        public DateTime? ReviewPeriodFrom { get; set; }
        public DateTime? ReviewPeriodTo { get; set; }
        public int? FkAppraisalRating { get; set; }
        public string EmployeeComment { get; set; }
        public string ReviewedBy { get; set; }
        public int? FkEmployee { get; set; }
        public int? CurrentCtc { get; set; }
        public int? AppraisedCtc { get; set; }
        public DateTime? NextAppraisalDueOn { get; set; }

        public TblEAppraisalRating FkAppraisalRatingNavigation { get; set; }
        public ICollection<PerformanceEvaluation> PerformanceEvaluation { get; set; }
    }
}
