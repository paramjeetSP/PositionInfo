using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEmployeeGoalSettingCategory
    {
        public int Id { get; set; }
        public int? FkgoalCateoriesId { get; set; }
        public int? FkemployeeGoalsSettingFormId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
