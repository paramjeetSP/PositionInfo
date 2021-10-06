using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PositionInfo.Models.SpModels
{

    public class TopLeaves
    {
        [Key]
        public Int64 Rowid { get; set; }
        public decimal total { get; set; }
        public string name { get; set; }
        public string empcode { get; set; }
    }
    public class TopLeavesDept
    {
        [Key]
        public string empcode { get; set; }
        public decimal total { get; set; }
        public string name { get; set; }

    }
    public class LeaveReport
    {
        [Key]
        public int SrNo { get; set; }
        public string Empid { get; set; }
        public string ConfirmationDate { get; set; }
        public string ConfirmationStatus { get; set; }
    }
    //public class PendingLeaves
    //{
    //    [Key]
    //    public int EmpId { get; set; }
    //    public decimal PaidLeavesLeft { get; set; }
    //    public decimal SickLeavesLeft { get; set; }
    //    public decimal TotalLeavesLeft { get; set; }
    //    public decimal CasualLeavesLeft { get; set; }
    //    public decimal AllowedTotalLeaves { get; set; }
    //    public decimal AllowedCasualLeaves { get; set; }
    //    public decimal AllowedSickLeaves { get; set; }
    //    public decimal AllowedPaidLeaves { get; set; }
    //    public decimal TotalLeaveTaken { get; set; }
    //    public decimal LWP { get; set; }
    //    public bool IsProhibitionEmployee { get; set; }
    //}
    public class PendingLeaves
    {
        [Key]
        public int EmpID { get; set; }
        public decimal PaidLeavesLeft { get; set; }
        public decimal SickLeavesLeft { get; set; }
        public decimal TotalLeavesLeft { get; set; }
        public decimal CasualLeavesLeft { get; set; }
        public decimal AllowedTotalLeaves { get; set; }
        public decimal AllowedCasualLeaves { get; set; }
        public decimal AllowedSickLeaves { get; set; }
        public decimal AllowedPaidLeaves { get; set; }
        public decimal TotalLeaveTaken { get; set; }
        public decimal LWP { get; set; }
        public decimal CasualLeaveTaken { get; set; }
        public decimal SickLeaveTaken { get; set; }
        public decimal PaidLeaveTaken { get; set; }
        //public bool IsProhibitionEmployee { get; set; }
    }

    public class EmpLeavesStatus
    {
        [Key]
        public Int64 RowID { get; set; }
        public Int32 EmpId { get; set; }
        public string LeaveType { get; set; }
        public string AppliedOn { get; set; }
        public string LeaveStartDate { get; set; }
        public string LeaveEndDate { get; set; }
        public decimal? ActualCount { get; set; }
        public string LeaveReason { get; set; }
        public string FirstLineMangerName { get; set; }
        public string FirstLineMangerComment { get; set; }
        public string FirstLineMangerStatus { get; set; }
        public string SecondLineMangerName { get; set; }
        public string SecondLineManagerComment { get; set; }
        public string SecondLineManagerStatus { get; set; }
        public string HRName { get; set; }
        public string Hr_Comment { get; set; }
        public string Hr_Status { get; set; }
        public string EmpLeaveStatus { get; set; }
    }
    public class SingleEmployee
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string LName { get; set; }
        public string ConfirmationStatus { get; set; }

    }
    public class Manager
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int DesignationID { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public string FullName { get; set; }
        public int SelfAssesmentStatus { get; set; }
        public int HrAssesmentStatus { get; set; }
        public int GoalSettingByLeadStatus { get; set; }
        public int LeadAssesmentStatus { get; set; }
        public int HrInitiateFormStatus { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
        public int isLogin { get; set; }

    }

    public class Manager_v2
    {
        [Key]
        public long Row_Number { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int DesignationID { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public string FullName { get; set; }
        public int SelfAssesmentStatus { get; set; }
        public int HrAssesmentStatus { get; set; }
        public int GoalSettingByLeadStatus { get; set; }
        public int LeadAssesmentStatus { get; set; }
        public int HrInitiateFormStatus { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
        public int isLogin { get; set; }
        public int? IsLead { get; set; }

        public int IsManager { get; set; }

    }
    public class login
    {
        [Key]
        public bool islogin { get; set; }
    }

    public class EmployeeDetails
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string LName { get; set; }
        public string ConfirmationStatus { get; set; }
        public int AppraisalStatus { get; set; }
        public int HrAssesmentStatus { get; set; }
        public int GoalsettingByLeadStatus { get; set; }
        public int HrinitiateFormStatus { get; set; }
        public int SelfAssesmentStatus { get; set; }
        public int LeadAssesmentStatus { get; set; }
        public int ProjectManagerAssesmentStatus { get; set; }
        public int ManagementFeedbackStatus { get; set; }
        public string DepartmentHead { get; set; }
        public string ManagerName { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
    }

    public class EmployeeDetailsDashboard
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string LName { get; set; }
        public string ConfirmationStatus { get; set; }
        public int AppraisalStatus { get; set; }
        public int HrAssesmentStatus { get; set; }
        public int GoalsettingByLeadStatus { get; set; }
        public int HrinitiateFormStatus { get; set; }
        public int SelfAssesmentStatus { get; set; }
        public int LeadAssesmentStatus { get; set; }
        public string DepartmentHead { get; set; }
        public string ManagerName { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
    }

    public class EmployeeBasicDetails
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string ReportingTo { get; set; }
        public string EvaluationStartDate { get; set; }
        public string EvaluationEndDate { get; set; }
    }




    public class EmployeeRatingDetail
    {
        public List<EmployeeRating> _EmployeeRatinglist { get; set; }
        public List<EmployeeAmbition> _EmployeeAmbitionlist { get; set; }
        public List<ManagerBehaviourRatingComment> _ManagerBehaviourRatinglist { get; set; }
    }

    public class ManagerRatingDetail
    {
        public List<ManagerRating> _ManagerRatinglist { get; set; }
        public List<ManagerSummary> _ManagerSummarylist { get; set; }
        public List<ManagerBehaviourRatingComment> _ManagerBehaviourRatinglist { get; set; }
    }

    public class RatingDetail
    {
        public int Emp_Id { get; set; }
        public List<GoalRCList> GoalRCList { get; set; }
        public SummaryList SummaryList { get; set; }
        public List<BehaviourRatingList> BehaviourRatingList { get; set; }
    }

    public class GoalRCList
    {
        [Key]
        public int ID { get; set; }
        public int? GoalCategoryId { get; set; }
        public string GoalDescription { get; set; }
        public string Target { get; set; }
        public decimal? Ratings { get; set; }
        public string Comments { get; set; }
        public string CommentManager { get; set; }
        public decimal? RatingManager { get; set; }
    }

    public class SummaryList
    {
        public int ID { get; set; }
        public string Ambitions { get; set; }
        public string Summarize { get; set; }
        public string AreaImproveSelf { get; set; }
        public string ActionPlanImproveSelf { get; set; }
        public string SummarizeOverallPerformanceManager { get; set; }
        public string AreasImprovementManager { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public decimal? OverallRatingManager { get; set; }
        public string OverallRatingManagercomment { get; set; }
        public decimal? Hrfeedback { get; set; }
        public decimal? ManagementFeedback { get; set; }
        public string Hrfeedbackcomment { get; set; }
        public string ManagementFeedbackcomment { get; set; }
    }

    public class BehaviourRatingList
    {
        public int ID { get; set; }
        public decimal? ManagerRating { get; set; }
        public string ManagerComments { get; set; }
        public int? BehaviourGoalId { get; set; }
    }

    public class EmployeeRating
    {
        [Key]
        public int ID { get; set; }
        public int Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string OfficialEmail { get; set; }
        public decimal Ratings { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string CreatedOn { get; set; }
        public int goalCategoryId { get; set; }



    }
    public class ManagerRating
    {
        [Key]
        public int ID { get; set; }
        public int Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string OfficialEmail { get; set; }
        public decimal Ratings { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string CreatedOn { get; set; }
        public string CommentManager { get; set; }
        public decimal RatingManager { get; set; }

    }


    public class EmployeeAmbition
    {
        public int ID { get; set; }
        public string Ambitions { get; set; }
        public string Summarize { get; set; }
        public string AreaImproveSelf { get; set; }
        public string ActionPlanImproveSelf { get; set; }
        public int Emp_Id { get; set; }
    }

    public class ManagerSummary
    {
        public int ID { get; set; }
        public string Ambitions { get; set; }
        public string Summarize { get; set; }
        public string AreaImproveSelf { get; set; }
        public string ActionPlanImproveSelf { get; set; }
        public string SummarizeOverallPerformanceManager { get; set; }
        public string AreasImprovementManager { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public decimal OverallRatingManager { get; set; }
        public string OverallRatingManagercomment { get; set; }
        public decimal Hrfeedback { get; set; }
        public decimal ManagementFeedback { get; set; }
        public string Hrfeedbackcomment { get; set; }
        public string ManagementFeedbackcomment { get; set; }
        public int Emp_Id { get; set; }
        public string ProjectManagerFeedbackComment { get; set; }
    }
    public class ManagerBehaviourRatingComment
    {
        public int id { get; set; }
        //   public string Behaviouralgoals { get; set; } // save Static desc also in db
        public decimal ManagerRating { get; set; }
        public string ManagerComments { get; set; }
        public bool IsActive { get; set; }
        public int Pid { get; set; }

    }

    public class DepartmentList
    {
        [Key]
        public int ID { get; set; }
        public string DeptName { get; set; }
    }




    public class Top5EmployeeByDepartment
    {
        [Key]
        public Int64 RowId { get; set; }
        public decimal total { get; set; }
        public string name { get; set; }
        public string empcode { get; set; }
    }

    public class TotalLeaveByDepartment
    {
        [Key]
        public Int64 RowId { get; set; }
        public string DeptName { get; set; }
        public decimal ActualCount { get; set; }
    }

    public class EmployeesLeaveDetails
    {
        [Key]
        public string EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        public string Grade { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOJ { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string ConfirmationDate { get; set; }
        public string ConfirmationStatus { get; set; }
        public string D16 { get; set; }
        public string D17 { get; set; }
        public string D18 { get; set; }
        public string D19 { get; set; }
        public string D20 { get; set; }
        public string D21 { get; set; }
        public string D22 { get; set; }
        public string D23 { get; set; }
        public string D24 { get; set; }
        public string D25 { get; set; }
        public string D26 { get; set; }
        public string D27 { get; set; }
        public string D28 { get; set; }
        public string D29 { get; set; }
        public string D30 { get; set; }
        public string D31 { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public string D4 { get; set; }
        public string D5 { get; set; }
        public string D6 { get; set; }
        public string D7 { get; set; }
        public string D8 { get; set; }
        public string D9 { get; set; }
        public string D10 { get; set; }
        public string D11 { get; set; }
        public string D12 { get; set; }
        public string D13 { get; set; }
        public string D14 { get; set; }
        public string D15 { get; set; }
        public decimal LeaveBalance_CL { get; set; }
        public decimal LeaveBalance_SL { get; set; }
        public decimal LeaveBalance_PL { get; set; }
        public decimal LeaveBalance_TL { get; set; }
        public decimal LeaveTaken_CL { get; set; }
        public decimal LeaveTaken_SL { get; set; }
        public decimal LeaveTaken_PL { get; set; }
        public decimal LeaveTaken_TL { get; set; }
        public decimal LeaveBalancefornexttenure_CL { get; set; }
        public decimal LeaveBalancefornexttenure_SL { get; set; }
        public decimal LeaveBalancefornexttenure_PL { get; set; }
        public decimal LeaveBalancefornexttenure_TL { get; set; }
        public decimal TotalDays { get; set; }
        public decimal PayableDays { get; set; }
        public decimal LWPLeave { get; set; }
    }

    public class GetUserImagePath
    {
        [Key]
        public int ID { get; set; }
        public string imageurl { get; set; }
    }

    public class EmployeeList
    {
        [Key]
        public int Id { get; set; }
        public string Emp_id { get; set; }
    }
    public class FirstLineManager
    {
        [Key]
        public string emp_id { get; set; }
    }
    public class ManagerDetails
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string OfficialEmail { get; set; }
        public string DeptName { get; set; }
        public string DepartmentHead { get; set; }
        public string FullName { get; set; }
    }
    public class SecondLineManager
    {
        [Key]
        public string emp_id { get; set; }
    }
    public class GetEmployeeLeavesStatus
    {
        [Key]
        public Int64 RowID { get; set; }
        public int EmpId { get; set; }
        public string AppliedOn { get; set; }
        public string LeaveStartDate { get; set; }
        public string LeaveEndDate { get; set; }
        public decimal ActualCount { get; set; }
        //public int LeaveRowID { get; set; }
    }

    public class SaveNewLeaveData
    {

        public int Id { get; set; }
        public string Emp_Id { get; set; }
        public int fkLeaveType { get; set; }
        public int Department { get; set; }
        public string AppliedOn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveReason { get; set; }
        public string FirstLineManager_id { get; set; }
        public int FirstLineManagerStatus { get; set; }
        public string SecondLineManager_id { get; set; }
        public int SecondLineManagerStatus { get; set; }
        public string Hr_id { get; set; }
        public int Hr_Status { get; set; }
        public int EmpLeaveStatus { get; set; }
        public int? fkEmploymentStatus { get; set; }
        public DateTime LeaveAppliedDate { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public bool IsHalfDay { get; set; }
        public bool IsProbationLeave { get; set; }
        public bool IsLWP { get; set; }
        public decimal ELC { get; set; }
        public bool IsELCFlag { get; set; }



        public decimal CasualLeaveTaken { get; set; }
        public decimal CasualLeavesLeft { get; set; }
        public decimal SickLeaveTaken { get; set; }
        public decimal SickLeavesLeft { get; set; }
        public decimal PaidLeaveTaken { get; set; }
        public decimal PaidLeavesLeft { get; set; }
        public decimal LWP { get; set; }

        public decimal WorkFromHomeTaken { get; set; }
        public decimal WorkFromHomeLeft { get; set; }
    }

    public class UpdateLeaveData
    {
        public string LeaveStartDate { get; set; }
        public string LeaveEndDate { get; set; }
        public int LeaveID { get; set; }
    }


    public class CustomLeaveDetail
    {
        [Key]
        public string EmpId { get; set; }
        public string Name { get; set; }
        public decimal TotalAllocatedLeaves { get; set; }
        public decimal TotalLeavesTaken { get; set; }
        public decimal CasualLeavesTaken { get; set; }
        public decimal SickLeavesTaken { get; set; }
        public decimal PaidLeavesTaken { get; set; }
        public decimal LWPTaken { get; set; }
    }
    public class CalculateLeavesCount
    {
        [Key]
        public int fkleavetype { get; set; }
        public int EmpID { get; set; }
        public decimal CasualLeavesLeft { get; set; }
        public decimal SickLeavesLeft { get; set; }
        public decimal PaidLeavesLeft { get; set; }
        //public decimal LWPLeft { get; set; }
    }

    public class CalculateLeavesTakenByYear
    {
        [Key]
        public int fkleavetype { get; set; }
        public int Emp_id { get; set; }
        public decimal TL { get; set; }
        public decimal CL { get; set; }
        public decimal SL { get; set; }
        public decimal PL { get; set; }
    }

    public class GetEmployeeLeavesHistory_LWP
    {
        [Key]
        public Int64 RowID { get; set; }
        public int EmpId { get; set; }
        public string AppliedOn { get; set; }
        public string LeaveStartDate { get; set; }
        public string LeaveEndDate { get; set; }
        public decimal ActualCount { get; set; }
        public string LeaveType { get; set; }

    }
    public class CalculateLeavesTakenLWPByYear
    {
        [Key]
        public int fkleavetype { get; set; }
        public int Emp_id { get; set; }
        public decimal TL { get; set; }

    }

    public class ClsEmpLeaveTakenAndLeftDetails
    {
        [Key]
        public int ID { get; set; }
        public decimal TakenSickLeave { get; set; }
        public decimal TakenCasualLeave { get; set; }
        public decimal TakenPaidLeave { get; set; }
        public decimal LeftSickLeave { get; set; }
        public decimal LeftCasualLeave { get; set; }
        public decimal LeftPaidLeave { get; set; }




    }

    public class ClsEmp_GetEmployeePendingLeaves
    {
        [Key]
        public int EmpID { get; set; }
        public decimal CasualLeaveTaken { get; set; }
        public decimal CasualLeavesLeft { get; set; }
        public decimal SickLeaveTaken { get; set; }
        public decimal SickLeavesLeft { get; set; }
        public decimal PaidLeaveTaken { get; set; }
        public decimal PaidLeavesLeft { get; set; }
        public int WorkFromHomeTaken { get; set; }
        public int WorkFromHomeLeft { get; set; }
        public decimal LWP { get; set; }


    }

    public class ClsMonthlyFinalList
    {
        public string key { get; set; }
        public string value { get; set; }
    }
    public class ClsMonthlyList
    {
        public int key { get; set; }
        public string value { get; set; }
    }
    public class Emp_ProbationStatusWithColName
    {
        [Key]
        public int IsProbationStatus { get; set; }
    }
    public class AppVersion
    {
        public int Id { get; set; }
        public string VersionNumber { get; set; }
        public string VersionFileLinkAndroid { get; set; }
        public string VersionFileLinkIOS { get; set; }
        public string VersionMessageText { get; set; }
        public string PreviousVersionFileLinkAndroid { get; set; }
        public string PreviousVersionFileLinkIOS { get; set; }
        public string VersionNumberIOS { get; set; }
    }

    public class EmployeeList_withCode
    {
        [Key]
        public Int64 RowID { get; set; }
        public int UserID { get; set; }
        public string EmpCode { get; set; }
        public string FullName { get; set; }
        public string EmpID { get; set; }
        public string Department { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOJ { get; set; }
        public string RandomCode { get; set; }

    }
    public class EmployeeListCode
    {
        public string EmpCode { get; set; }
        public string FullName { get; set; }
        public string EmpID { get; set; }
        public string RandomCode { get; set; }
    }

    public class ProhbitionEmployeeList
    {
        [Key]
        public int EmpID { get; set; }
        public decimal AllowedTotalLeaves { get; set; }
        // public decimal PaidLeavesLeft { get; set; }
        public decimal CasualLeavesLeft { get; set; }
        public decimal TotalLeaveTaken { get; set; }
        public decimal CasualLeaveTaken { get; set; }
        public decimal LWP { get; set; }
    }
    public class ExceptionTrace
    {
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public string controllerName { get; set; }
        public string Platform { get; set; }
        public string stackTrace { get; set; }

    }

    public class LateComing_Details_History
    {
        [Key]
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
    public class WorkingHoursDetails
    {
        [Key]
        public int RowID { get; set; }
        public int TotalWorkingHours { get; set; }
        public string ActualWorkingHours { get; set; }
    }

    public class LateComing_Details
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOJ { get; set; }
        public string DeptName { get; set; }
    }
    public class LessWorkingHours_Details
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DOJ { get; set; }
        public string DeptName { get; set; }
        public string Total { get; set; }
        public string Actual { get; set; }
    }

    public class EmployeeGoalDetails
    {
        [Key]
        public int ID { get; set; }
        public int Emp_Id { get; set; }
        public string Description { get; set; }
        public int FkEmployeeGoalSettingFormId { get; set; }
        public string Target { get; set; }
        public int FkGoalCategoryId { get; set; }
        public decimal SelfRating { get; set; }
        public string SelfComment { get; set; }
        public Boolean HasSubmittedEmp { get; set; }
        public decimal RatingByManager { get; set; }
        public string CommnetManager { get; set; }
        public Boolean HasSubmittedManager { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Boolean IsActive { get; set; }


    }

    public class yearlist
    {
        [Key]
        public int Yearlist { get; set; }
    }

    public class SelectedManagerDetails
    {
        [Key]
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public string Emp_Code { get; set; }
        public string FName { get; set; }
        public string FullName { get; set; }
        public string OfficialEmail { get; set; }
        public string Mobile { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }
        public string Department { get; set; }
        public string PermanentAddress { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string Grade { get; set; }
        public string DOJ { get; set; }
        public string LName { get; set; }
        public string ConfirmationStatus { get; set; }
        public int AppraisalCycle { get; set; }
        public string ManagerName { get; set; }
        public int Checkboxcheck { get; set; }
        public int DepartmentId { get; set; }
    }


    public class AllSelectedManagerDetails
    {
        [Key]
        public int ID { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

    }

    public class AssignEmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Emp_Code { get; set; }
        public int? SelfAssesmentStatus { get; set; }
        public int? HrassesmentStatus { get; set; }
        public int? GoalSettingByLeadStatus { get; set; }
        public int? LeadAssesmentStatus { get; set; }
        public int? HrinitiateFormStatus { get; set; }
        public int ProjectManagerAssesmentStatus { get; set; } // property added
        public int? Year { get; set; }
        public string Cycle { get; set; }
    }


    public class AssesmentStatus
    {
        public int Emp_Id { get; set; }
        public int HRInitiateFormStatus { get; set; }
        public int GoalSettingByLeadStatus { get; set; }
        public int SelfAssesmentStatus { get; set; }
        public int LeadAssesmentStatus { get; set; }
        public int ProjectManagerAssesmentStatsu { get; set; }
        public int HRAssesmentStatus { get; set; }
        public int ManagementFeedbackStatus { get; set; }
    }

    public class EditFormHR
    {
        public int Emp_Id { get; set; }
        public List<ManagerRatingAndComments> ManagerRatingAndComments { get; set; }
        public List<BehaviouralRatingAndComments> BehaviouralRatingAndComments { get; set; }
        public List<SummaryClosure> SummaryClosure { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
        public int semiedit { get; set; }
    }

    public class ManagerRatingAndComments
    {
        public int Pid { get; set; }
        public decimal? Ratings { get; set; }
        public string Comments { get; set; }
    }

    public class BehaviouralRatingAndComments
    {
        public int Pid { get; set; }
        public decimal? Ratings { get; set; }
        public string Comments { get; set; }
    }

    public class SummaryClosure
    {
        public int Id { get; set; }
        public string SummarizeOverallPerformanceManager { get; set; }
        public string AreaofImprovementManager { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public decimal? ProjectManagerrating { get; set; }
        public string ProjectManagercomment { get; set; }
        public decimal? HRrating { get; set; }
        public string HRComment { get; set; }
    }

    public class BalanceLeaveById
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeaveId { get; set; }
        public string LeaveType { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
    }
    public class UpdateBalanceLeaveData
    {
        public decimal Balance { get; set; }
        public int ID { get; set; }
    }
}
