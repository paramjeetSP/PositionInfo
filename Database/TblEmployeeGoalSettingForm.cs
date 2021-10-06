using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEmployeeGoalSettingForm
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ManagerId { get; set; }
        public bool? IsGoalSettingStage { get; set; }
        public bool? IsReviewStage { get; set; }
        public int? TotalDaysToSubmitForManagerGoalSetting { get; set; }
        public int? TotalDaysToSubmitForEmployeeGoalSetting { get; set; }
        public int? TotalDaysToSubmitForManagerReview { get; set; }
        public int? TotalDaysToSubmitForEmployeeReview { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsProcessClosure { get; set; }
        public int? HrinitiateFormStatus { get; set; }
        public int? GoalsettingByLeadStatus { get; set; }
        public int? SelfAssesmentStatus { get; set; }
        public int? LeadAssesmentStatus { get; set; }
        public int? HrassesmentStatus { get; set; }
        public DateTime? EvaluationStartDate { get; set; }
        public DateTime? EvaluationEndDate { get; set; }
        public int? Year { get; set; }
        public string Cycle { get; set; }
        public int? ProjectManagerAssesmentStatus { get; set; }
        public DateTime? GoalSettingStartDate { get; set; }
        public DateTime? GoalSettingEndDate { get; set; }
        public DateTime? SelfAssesmentStartDate { get; set; }
        public DateTime? SelfAssesmentEndDate { get; set; }
        public DateTime? LeadAssesmentStartDate { get; set; }
        public DateTime? LeadAssesmentEndDate { get; set; }
        public DateTime? ProjectManagerAssesmentStartDate { get; set; }
        public DateTime? ProjectManagerAssesmentEndDate { get; set; }
        public DateTime? TodayDate { get; set; }
        public int? EmailSent11Am { get; set; }
        public int? EmailSent04Pm { get; set; }
        public int? ManagementFeedbackStatus { get; set; }
        public int? ManagementId { get; set; }
    }
}
