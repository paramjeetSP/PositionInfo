using LeaveManagement.Models.SpModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Database
{
    public class StoredProcedureClass
    {

    }

    public partial class Recovered_hrmsnewContext
    {
        public virtual DbSet<TopLeaves> TopLeaveCount { get; set; }
        public virtual DbSet<LeaveReport> LeaveReport  { get; set; }
        public virtual DbSet<PendingLeaves> pendingLeaves { get; set; }
        public virtual DbSet<EmpLeavesStatus> empLeaveStatus { get; set; }
        public virtual DbSet<SingleEmployee> SingleEmployees { get; set; }
        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public virtual DbSet<ManagerDetails> ManagerDetails { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Manager_v2> Manager_v2 { get; set; }
        public virtual DbSet<TopLeavesDept> TopLeavesDepts { get; set; }
        public virtual DbSet<DepartmentList> DepartmentList { get; set; }
        public virtual DbSet<Top5EmployeeByDepartment> Top5EmployeeByDepartment { get; set; }
        public virtual DbSet<TotalLeaveByDepartment> TotalLeaveByDepartment { get; set; }
        public virtual DbSet<EmployeesLeaveDetails> EmployeesLeaveDetails { get; set; }
        public virtual DbSet<GetUserImagePath> GetUserImagePath { get; set; }
        public virtual DbSet<EmployeeList> EmployeeList { get; set; }
        public virtual DbSet<FirstLineManager> FirstLineManager { get; set; }
        public virtual DbSet<SecondLineManager> SecondLineManager { get; set; }
        public virtual DbSet<GetEmployeeLeavesStatus> GetEmployeeLeavesStat { get; set; }
        public virtual DbSet<CalculateLeavesCount> CalculateLeavesCount { get; set; }
        
        public virtual DbSet<CalculateLeavesTakenByYear> CalculateLeavesTakenByYear { get; set; }
        public virtual DbSet<CalculateLeavesTakenLWPByYear> CalculateLeavesTakenLWPByYear { get; set; }
        public virtual DbSet<ClsEmpLeaveTakenAndLeftDetails> ClsEmpLeaveTakenAndLeftDetails { get; set; }
        public virtual DbSet<GetEmployeeLeavesHistory_LWP> GetEmployeeLeavesHistory_LWP { get; set; }
        public virtual DbSet<CustomLeaveDetail> CustomLeaveDetail { get; set; }
        public virtual DbSet<Emp_ProbationStatusWithColName> Emp_ProbationStatusWithColName { get; set; }
        public virtual DbSet<EmployeeList_withCode> EmployeeList_withCodes { get; set; }
        public virtual DbSet<ProhbitionEmployeeList> ProhbitionEmployeeList { get; set; }
        public virtual DbSet<LateComing_Details> LateComing_DetailsList { get; set; }        
        //public virtual DbSet<LateComing_Details_History> LateComing_Details_History { get; set; }
        public virtual DbSet<ClsEmp_GetEmployeePendingLeaves> ClsEmp_GetEmployeePendingLeaves { get; set; }
        public virtual DbSet<LessWorkingHours_Details> LessWorkingHours_DetailsList { get; set; }
        public virtual DbSet<WorkingHoursDetails> WorkingHoursDetailsList { get; set; }
        public virtual DbSet<yearlist> yearlist { get; set; }
        public virtual DbSet<SelectedManagerDetails> SelectedManagerDetails { get; set; }
        public virtual DbSet<AssignEmployeeModel> AssignEmployeeModel { get; set; }
        



    }
}
