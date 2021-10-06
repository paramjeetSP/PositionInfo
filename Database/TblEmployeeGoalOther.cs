using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEmployeeGoalOther
    {
        public int Id { get; set; }
        public int? FkemployeeGoalsSettingFormId { get; set; }
        public string AmbitionsJobExpectations { get; set; }
        public string SummarizeOverallPerformanceSelf { get; set; }
        public string SummarizeOverallPerformanceManager { get; set; }
        public string AreasImprovementSelf { get; set; }
        public string AreasImprovementManager { get; set; }
        public string ActionPlanImprovementSelf { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public decimal? OverallRatingManager { get; set; }
        public decimal? Hrfeedback { get; set; }
        public decimal? ManagementFeedback { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? EmployeeId { get; set; }
        public string OverallRatingManagercomment { get; set; }
        public string Hrfeedbackcomment { get; set; }
        public string ManagementFeedbackcomment { get; set; }
        public int? Year { get; set; }
        public string Cycle { get; set; }
        public string ProjectManagerFeedbackcomment { get; set; }
    }
}
