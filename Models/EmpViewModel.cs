using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PositionInfo.Models
{
    public class EmpViewModel
    {

    }
    public class LeaveGraph
    {
        public string LeaveName { get; set; }
        public decimal LeaveCount { get; set; }
    }
    public class LeaveTakenBar
    {
        public decimal LeaveTakenCount { get; set; }
    }
    public class LeaveLeftBar
    {
        public decimal LeaveLeftCount { get; set; }
    }
    public class LeaveProgessBar
    {
        public List<LeaveLeftBar> leaveLeftBar { get; set; }
        public List<LeaveTakenBar> leaveTakenBar { get; set; }
    }
    public class EmpLateComing_Details
    {
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOJ { get; set; }
        public string DeptName { get; set; }
        public int TotalWorkingHour { get; set; }
        public string ActualWorkingHour { get; set; }
    }
    public class EmpLateComing_Details_History
    {
        public Int64 RowID { get; set; }
        public string Emp_Id { get; set; }
        public string Login { get; set; }
        public string Logout { get; set; }
        public string PunchIn { get; set; }
        public string PunchOut { get; set; }
        public string WorkingHours { get; set; }
        public string ProductiveHours { get; set; }
        public string Earlycheckoutreson { get; set; }
        public decimal? WorkingHoursCal { get; set; }
    }

    public class EmployeeGoalSetting
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public int ManagerID { get; set; }
        public bool IsGoalSettingStage { get; set; }
        public bool IsReviewStage { get; set; }
        public int TotalDaysToSubmitForManagerGoalSetting { get; set; }
        public DateTime DateSubmittedManagerGoalSetting { get; set; }
        public int TotalDaysToSubmitForEmployeeGoalSetting { get; set; }
        public DateTime DateSubmittedEmployeeGoalSetting { get; set; }
        public int TotalDaysToSubmitForManagerReview { get; set; }
        public DateTime DateSubmittedManagerReview { get; set; }
        public int TotalDaysToSubmitForEmployeeReview { get; set; }
        public DateTime DateSubmittedEmployeeReview { get; set; }
        public bool IsActive { get; set; }
        public bool IsProcessClosure { get; set; }
        public DateTime GoalSettingStageStartDate { get; set; }
        public DateTime ReviewSettingStageStartDate { get; set; }
        public DateTime GoalSettingStageEndDate { get; set; }
        public DateTime ReviewSettingStageEndDate { get; set; }       
    }
}
