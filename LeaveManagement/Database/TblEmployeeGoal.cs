using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TblEmployeeGoal
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public int? FkemployeeGoalSettingFormId { get; set; }
        public string Target { get; set; }
        public int? FkgoalCateoriesId { get; set; }
        public decimal? RatingSelf { get; set; }
        public string CommentSelf { get; set; }
        public bool? EmployeeHasSubmitted { get; set; }
        public decimal? RatingManager { get; set; }
        public string CommentManager { get; set; }
        public bool? ManagerHasSubmitted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? Year { get; set; }
        public string Cycle { get; set; }
        public int? MasterGoalCategoryId { get; set; }
    }
}
