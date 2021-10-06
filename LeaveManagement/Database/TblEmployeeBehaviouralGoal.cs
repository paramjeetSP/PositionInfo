using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblEmployeeBehaviouralGoal
    {
        public int Id { get; set; }
        public string GoalDescription { get; set; }
        public decimal? RatingManagerEvaluation { get; set; }
        public string CommentManagerEvaluation { get; set; }
        public int? FkemployeeGoalsSettingFormId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? FkbehaviouralGoalsMasterId { get; set; }
        public bool? IsActiveForManagerComments { get; set; }
        public int? EmployeeId { get; set; }
        public int? Year { get; set; }
        public string Cycle { get; set; }
    }
}
