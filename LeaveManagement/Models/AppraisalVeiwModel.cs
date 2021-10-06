using LeaveManagement.Models.SpModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class AppraisalVeiwModel
    {
    }

    public class EmployeeGoalModel
    {
        public int id { get; set; }
        public int createdById { get; set; }
        public string empid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class EmployeeGoalEMPModel
    {
        public int id { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }
    public class leadGoalNotificationbyID
    {
        public int id { get; set; }

    }
    public class hrGoalNotificationbyID
    {
        public int id { get; set; }

    }

    public class EmployeeGoalFromModel
    {
        public List<employeegoal> employeegoal { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class EmployeeGoalUpdatebyManagerModel
    {
        public List<editemployeegoal> editemployeegoal { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class editemployeegoal
    {
        public string description { get; set; }
        public int id { get; set; }
        public string departmentHead { get; set; }
        public int pid { get; set; }
    }

    public class employeegoal
    {
        public string description { get; set; }
        public int id { get; set; }
        public int departmentHead { get; set; }
        public int pid { get; set; }
    }

    public class UpdateEmployeeGoalModel
    {
        public List<Goaldataupdate> Goaldataupdate { get; set; }
        public List<Goalemployeeambitionsummary> Goalemployeeambitionsummary { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class SaveManagerRatingCommentBehaviourGoal
    {
        public List<ManagerRatingComment> ManagerRatingComment { get; set; }
        public List<BehaviourRatingComment> BehaviourRatingComment { get; set; }
        public List<Summary> Summary { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class EditManagerRatingCommentBehaviourGoal
    {
        public List<ManagerRatingComment> ManagerRatingComment { get; set; }
        public List<EditBehaviourRatingComment> EditBehaviourRatingComment { get; set; }
        public List<Summary> Summary { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class HrCumManagmentFeedbackComments
    {
        public int id { get; set; }
        public decimal Hrrating { get; set; }
        public string Hrcomment { get; set; }
        public decimal Managmentrating { get; set; }
        public string Managmentcomment { get; set; }
        public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }
    public class HrFeedbackComments
    {
        public int id { get; set; }
        public decimal Hrrating { get; set; }
        public string Hrcomment { get; set; }
        public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
        public int semiedit { get; set; }
    }
    public class ManagmentFeedbackComments
    {
        public int id { get; set; }
        public decimal? Managmentrating { get; set; }
        public string Managmentcomment { get; set; }
        public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
        public int semiedit { get; set; }
    }

    public class ProjectManagerFeedbackComments
    {
        public int id { get; set; }
        public decimal? ProjectManagerrating { get; set; }
        public string ProjectManagercomment { get; set; }
        public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }

        public string SummarizeOverallPerformanceManager { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public string AreasImprovementManager { get; set; }

        public int semiedit { get; set; }
    }
    public class SaveEditEmployeeGoalModel
    {
        //public List<EditGoaldataupdate> EditGoaldataupdate { get; set; }
        public List<Goaldataupdate> Goaldataupdate { get; set; }
        public List<EditGoalemployeeambitionsummary> EditGoalemployeeambitionsummary { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class Summary
    {
        // public int id { get; set; } // we have to update based on Empployee Id  All these
        public string SummarizeOverallPerformanceManager { get; set; }
        public string ActionPlanImprovementManager { get; set; }
        public string AreasImprovementManager { get; set; }
        public decimal OverallRatingManager { get; set; }
        public string OverallRatingManagercomment { get; set; }
        public int Pid { get; set; }
    }

    public class Goalemployeeambitionsummary
    {
        public int id { get; set; }
        public string AmbitionsJobExpectations { get; set; }
        public string ActionPlanImprovementSelf { get; set; }
        public string SummarizeOverallPerformanceSelf { get; set; }
        public string AreasImprovementSelf { get; set; }
        public bool IsActive { get; set; }
    }

    public class BehaviourRatingComment
    {
        public int id { get; set; }
        //    public int Emp_id { get; set; }
        public string Behaviouralgoals { get; set; } // save Static desc also in db
        public decimal ManagerRating { get; set; }
        public string ManagerComments { get; set; }
        public bool IsActive { get; set; }
        public int Pid { get; set; }
        //public DateTime CreatedOn { get; set; } 
        //public DateTime UpdatedOn { get; set; }
        //public int CreatedBy { get; set; } // save Emp id
        //public int UpdatedBy { get; set; }
    }

    public class BehaviourRatingsComment
    {
        //public int id { get; set; }
        //    public int Emp_id { get; set; }
        public int Behaviouralgoals { get; set; } // save Static desc also in db
        public decimal? ManagerRating { get; set; }
        public string ManagerComments { get; set; }
        // public bool IsActive { get; set; }
        //public int Pid { get; set; }
        //public DateTime CreatedOn { get; set; } 
        //public DateTime UpdatedOn { get; set; }
        //public int CreatedBy { get; set; } // save Emp id
        //public int UpdatedBy { get; set; }
    }

    public class EditBehaviourRatingComment
    {
        public int id { get; set; }
        //    public int Emp_id { get; set; }
        public string Behaviouralgoals { get; set; } // save Static desc also in db
        public decimal ManagerRating { get; set; }
        public string ManagerComments { get; set; }
        public bool IsActive { get; set; }
        public int Pid { get; set; }
        //public DateTime CreatedOn { get; set; } 
        //public DateTime UpdatedOn { get; set; }
        //public int CreatedBy { get; set; } // save Emp id
        //public int UpdatedBy { get; set; }
    }

    public class EditGoalemployeeambitionsummary
    {
        public int id { get; set; }
        public string AmbitionsJobExpectations { get; set; }
        public string ActionPlanImprovementSelf { get; set; }
        public string SummarizeOverallPerformanceSelf { get; set; }
        public string AreasImprovementSelf { get; set; }
    }

    public class Goaldataupdate
    {

        public int id { get; set; }
        public decimal RatingSelf { get; set; }
        public string CommentSelf { get; set; }
        public int pid { get; set; }
    }

    public class ManagerRatingComment
    {
        public int id { get; set; }
        public decimal Ratings { get; set; }
        public string Comments { get; set; }
        public int pid { get; set; }
    }

    public class EditGoaldataupdate
    {

        public int id { get; set; }
        public decimal RatingSelf { get; set; }
        public string CommentSelf { get; set; }
        public int pid { get; set; }
    }

    public class EmployeelistbyyearPeriodModel
    {
        public int year { get; set; }
        public string cycle { get; set; }
    }

    public class DepartmentEmployeeModel
    {
        public int Depid { get; set; }
        public int MangerId { get; set; }
    }
    public class DepartmentEmployeeModel_V2
    {
        public int Depid { get; set; }
        public int EmpId { get; set; }
    }
    public class GoalmasterModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
    public class TeamManagementModel
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public string ManagerName { get; set; }
        public int ManagerId { get; set; }
        public int EmployeeCount { get; set; }
        public int TotalEmployeeCount { get; set; }
    }
    public class SaveManagerModel
    {
        public int DepId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string[] ManagerId { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class SaveSubManagerModel
    {
        public int DepId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string[] SubManagerId { get; set; }
        public int ManagerId { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class SaveEmployeeModel
    {
        public int DepId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ManagerId { get; set; }
        public string[] EmployeeId { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class ManagerModel
    {
        public int MangerId { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
    }

    public class DepartmentAssignEmployeeModel
    {
        public int Depid { get; set; }
        public int MangerId { get; set; }
    }

    public class DepartmentWiseAssignEmployeeModel
    {
        public int Depid { get; set; }
        public int ManagerId { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
    }

    // varinder code

    public class DashboardModelForEmployeeList
    {
        public int DeptID { get; set; }
        public int Year { get; set; }
        public string Cycle { get; set; }
    }


    public class DashboardModel
    {
        public List<ManagerModel> ManagerList { get; set; }
        public List<EmployeeDetailsDashboard> EmployeeDetailsDashboardList { get; set; }
    }


    public class EmployeeEmailListModel
    {
        public string Name { get; set; }
        public string EmpCode { get; set; }
        public string OfficialEmail1 { get; set; }
        public string OfficialEmail2 { get; set; }
    }

    public class ProjectMangerFeedbackComment
    {
        public int EmployeeID { get; set; }
        public string ProjectManagerComment { get; set; }
    }

    public class SetGoal
    {
        public string goal { get; set; }
        public int goalCategoryId { get; set; }
        public string target { get; set; }

    }
    public class SetEmployeeGoalFromModel
    {
        public int empId { get; set; }
        public int mangerId { get; set; }
        // public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }

        public int semiedit { get; set; }

        public List<SetGoal> employeegoal { get; set; }
    }

    public class SetRatingComments
    {
        public int pid { get; set; }
        public decimal? Ratings { get; set; }
        public string Comments { get; set; }
    }

    public class SetManagerAssessment
    {
        public int empId { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
        public List<SetRatingComments> ManagerRatingComment { get; set; }
        public List<BehaviourRatingsComment> BehaviourRatingComment { get; set; }
        public List<Summary> Summary { get; set; }
        public int semiedit { get; set; }
    }


    public class EmployeeSelfAssessmentModel
    {
        public int id { get; set; }
        public List<SetRatingComments> Goaldataupdate { get; set; }
        public List<Goalemployeeambitionsummary> Goalemployeeambitionsummary { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }

        public int semiedit { get; set; }
    }
    public class ReplaceManagerModel
    {
        public int OldManagerId { get; set; }
        public int NewManagerId { get; set; }
    }

    public class ReplaceSubManagerModel
    {
        public int OldSubManagerId { get; set; }
        public int NewSubManagerId { get; set; }
    }
    public class RejectReasonComments
    {
        public int id { get; set; }
        public string reason { get; set; }
        public int pid { get; set; }
        public int year { get; set; }
        public string cycle { get; set; }
    }
    public class AllEmployeeForms
    {
        public int? id { get; set; }
        public int? year { get; set; }
        public int? department { get; set; }
        public string cycle { get; set; }
    }
}
