using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models.SpModels
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
        public string Experience { get; set; }
        public decimal PriorExperience { get; set; }
        public string PartialAvailable { get; set; }
        public string MarkToBench { get; set; }
        public string ExpPartialDateAvailability { get; set; }
        public string Skillset { get; set; }
        public string CurrentProject { get; set; }
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
    public class Emp_ProbationStatusWithColName
    {
        [Key]
        public int IsProbationStatus { get; set; }
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
    public class EmployeeResDetails
    {
        public int Id { get; set; }
        public bool OnBench { get; set; }
        public bool PartialAvailable { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpPartialDate { get; set; }
        public string Skillset { get; set; }
        public string CurrentProjName { get; set; }
    }
}
