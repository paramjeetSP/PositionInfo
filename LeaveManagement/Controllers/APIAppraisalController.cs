using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Enum;
using LeaveManagement.Models;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIAppraisalController : ControllerBase
    {
        private readonly Recovered_hrmsnewContext _context;
        private Logging _logging;
        private DashboardViewModel model;
        public static List<EmployeeGoalFromModel> TempEventAttachments = new List<EmployeeGoalFromModel>();
        public APIAppraisalController(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging(context);
            model = new DashboardViewModel(context);
        }

        [HttpGet]
        [Route("GetDepartmentList")]
        public IActionResult DepartmentList()
        {
            try
            {
                List<DepartmentList> deptList = _context.Set<DepartmentList>().FromSql("[dbo].[Emp_GetAllDepartment]").ToList();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisal, methodName: DepartmentList", "WEB/API");
                return null;
            }
        }

        [Route("GetGoalmaster")]
        [HttpGet]
        public async Task<IActionResult> Goalmaster()
        {
            try
            {
                var data = await _context.TblMasterGoalCategory.ToListAsync();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetDepartmentEmployeeList")]
        [HttpPost]
        public async Task<IActionResult> DepartmentEmployeeList(DepartmentEmployeeModel model)
        {
            try
            {
                List<EmployeeDetails> deptList = await _context.Set<EmployeeDetails>().FromSql("dbo.Emp_GetAllEmployeeProfileStatusByDepartment @dept = {0}", model.Depid).ToListAsync();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("GetDepartmentEmployeeList_v2")]
        [HttpPost]
        public async Task<IActionResult> DepartmentEmployeeList_v2(DepartmentEmployeeModel_V2 model)
        {
            try
            {
                List<EmployeeDetails> deptList;
                if (model.EmpId == 447 || model.EmpId == 452) //Soumyajit Sir
                {
                    deptList = await _context.Set<EmployeeDetails>().FromSql("dbo.Emp_GetAllEmployeeProfileStatusManagement  @managerid = {0}", model.EmpId).ToListAsync();
                }
                else
                {
                    deptList = await _context.Set<EmployeeDetails>().FromSql("dbo.Emp_GetAllEmployeeProfileStatusByDepartment_v2  @managerid = {0},@dept={1}", model.EmpId, model.Depid).ToListAsync();
                }
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("GetEmplist")]
        [HttpGet]
        public async Task<IActionResult> AllEmployees()
        {
            try
            {
                //EmployeelistbyyearPeriodModel periodModel;
                List<EmployeeDetails> _list = await _context.Set<EmployeeDetails>().FromSql("[dbo].[Emp_GetAllEmployeeProfileStatus]").ToListAsync();
                // List<EmployeeDetails> _list = await _context.Set<EmployeeDetails>().FromSql("[dbo].[Emp_GetAllEmployeeProfileStatus] @year = {0}, @cycle = {1}",periodModel.year,periodModel.cycle).ToListAsync();
                return Ok(_list);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("EmployeeGoalForm")]
        [HttpPost]
        public async Task<IActionResult> PostEmployeeGoalForm(EmployeeGoalFromModel _EmployeeGoalFromModel)
        {
            foreach (var item in _EmployeeGoalFromModel.employeegoal)
            {
                TblEmployeeGoal obj = new TblEmployeeGoal
                {
                    Description = item.description,
                    EmployeeId = item.id,
                    UpdatedOn = DateTime.Now,
                    CreatedOn = DateTime.Now,
                    CreatedBy = item.departmentHead.ToString(),
                    UpdatedBy = item.departmentHead.ToString(),
                    IsActive = true,
                    Year = DateTime.Now.Year
                };
                var month = DateTime.Now.Month;
                if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
                {
                    obj.Cycle = "May-October";
                }
                else
                {
                    obj.Cycle = "November-April";
                }
                _context.TblEmployeeGoal.Add(obj);
                await _context.SaveChangesAsync();
            }
            int id = _EmployeeGoalFromModel.employeegoal[0].id;

            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == id && m.Year == _EmployeeGoalFromModel.year && m.Cycle == _EmployeeGoalFromModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                employeedata.GoalsettingByLeadStatus = 3;
                await _context.SaveChangesAsync();

                // Email Notification Code
                var EmailQueue = new AmsemailQueue()
                {
                    EmployeeId = id,
                    EventId = (int)NotificationType.EventType.GoalSettingEndEmployee,
                    PendingDate = DateTime.Now.Date,
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.IntimationEmail,
                    FkEmployeeId = id,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue);
                await _context.SaveChangesAsync();

                var EmailQueue1 = new AmsemailQueue()
                {
                    EmployeeId = (int)employeedata.CreatedBy,
                    EventId = (int)NotificationType.EventType.GoalSettingEndHR,
                    PendingDate = DateTime.Now.Date,
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.IntimationEmail,
                    FkEmployeeId = id,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue1);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            int departmentHeadid = Convert.ToInt32(_EmployeeGoalFromModel.employeegoal[0].departmentHead);
            var departmentHeaddetail = _context.Employee.Where(m => m.Id == departmentHeadid).FirstOrDefault();
            var employeedetail = _context.Employee.Where(m => m.Id == id).FirstOrDefault();
            string description = departmentHeaddetail.Fname + " " + departmentHeaddetail.Lname + " " + "has been submitted goal for" + " " + employeedetail.Fname + " " + employeedetail.Lname;
            Hrnotification hrobj = new Hrnotification
            {
                Description = description,
                Hrid = (int)employeedata.CreatedBy,
                EmpId = id,
                IsRead = false
            };
            _context.Hrnotification.Add(hrobj);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [Route("SetEmployeeGoalForm")]
        [HttpPost]
        public async Task<IActionResult> SetEmployeeGoalForm(SetEmployeeGoalFromModel _setEmployeeGoalFromModel)
        {
            var existingGoals = _context.TblEmployeeGoal.Where(x => x.EmployeeId == _setEmployeeGoalFromModel.empId && x.Cycle == _setEmployeeGoalFromModel.cycle
              && x.Year == _setEmployeeGoalFromModel.year);
            if (existingGoals.Count() > 0)
                _context.TblEmployeeGoal.RemoveRange(existingGoals);

            foreach (var item in _setEmployeeGoalFromModel.employeegoal)
            {
                TblEmployeeGoal obj = new TblEmployeeGoal();
                obj.Description = item.goal;
                obj.EmployeeId = _setEmployeeGoalFromModel.empId;
                obj.UpdatedOn = DateTime.Now;
                obj.CreatedOn = DateTime.Now;
                obj.Target = item.target;
                obj.CreatedBy = _setEmployeeGoalFromModel.mangerId.ToString();
                obj.UpdatedBy = _setEmployeeGoalFromModel.mangerId.ToString();
                obj.MasterGoalCategoryId = item.goalCategoryId;
                obj.IsActive = true;
                obj.Year = DateTime.Now.Year;
                var month = DateTime.Now.Month;
                if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
                {
                    obj.Cycle = "May-October";
                }
                else
                {
                    obj.Cycle = "November-April";
                }
                _context.TblEmployeeGoal.Add(obj);
                await _context.SaveChangesAsync();
            }
            int id = _setEmployeeGoalFromModel.empId;

            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == id && m.Year == _setEmployeeGoalFromModel.year && m.Cycle == _setEmployeeGoalFromModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                if (_setEmployeeGoalFromModel.semiedit == 1)
                {
                    employeedata.GoalsettingByLeadStatus = 2;
                    await _context.SaveChangesAsync();
                }
                else if (_setEmployeeGoalFromModel.semiedit == 0)
                {
                    employeedata.GoalsettingByLeadStatus = 3;
                    await _context.SaveChangesAsync();
                    // Email Notification Code
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = (int)id,
                        EventId = (int)NotificationType.EventType.GoalSettingEndEmployee,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = id,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();

                    var EmailQueue1 = new AmsemailQueue()
                    {
                        EmployeeId = employeedata.CreatedBy,
                        EventId = (int)NotificationType.EventType.GoalSettingEndHR,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = id,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue1);
                    await _context.SaveChangesAsync();

                    int departmentHeadid = _setEmployeeGoalFromModel.mangerId;
                    var departmentHeaddetail = _context.Employee.Where(m => m.Id == departmentHeadid).FirstOrDefault();
                    var employeedetail = _context.Employee.Where(m => m.Id == id).FirstOrDefault();
                    string description = departmentHeaddetail.Fname + " " + departmentHeaddetail.Lname + " " + "has been submitted goal for" + " " + employeedetail.Fname + " " + employeedetail.Lname;
                    Hrnotification hrobj = new Hrnotification
                    {
                        Description = description,
                        Hrid = employeedata.CreatedBy,
                        EmpId = id,
                        IsRead = false
                    };
                    _context.Hrnotification.Add(hrobj);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return NotFound();
            }

            return Ok(true);
        }

        [Route("SaveEmployeeGoalFormRating")]
        [HttpPost]
        public async Task<IActionResult> SaveEmployeeGoalFormRating(UpdateEmployeeGoalModel _UpdateEmployeeGoalModel)
        {
            int idval = _UpdateEmployeeGoalModel.Goaldataupdate[0].id;
            //TblEmployeeGoal objval = new TblEmployeeGoal();
            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _UpdateEmployeeGoalModel.year && m.Cycle == _UpdateEmployeeGoalModel.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _UpdateEmployeeGoalModel.Goaldataupdate)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _UpdateEmployeeGoalModel.year && x.Cycle == _UpdateEmployeeGoalModel.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingSelf = item.RatingSelf;
                        UpdateData.CommentSelf = item.CommentSelf;
                        UpdateData.EmployeeHasSubmitted = true;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            TblEmployeeGoalOther tblEmployeeGoalOther = new TblEmployeeGoalOther
            {
                EmployeeId = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].id,
                AmbitionsJobExpectations = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].AmbitionsJobExpectations,
                ActionPlanImprovementSelf = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].ActionPlanImprovementSelf,
                SummarizeOverallPerformanceSelf = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].SummarizeOverallPerformanceSelf,
                AreasImprovementSelf = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].AreasImprovementSelf,
                IsActive = _UpdateEmployeeGoalModel.Goalemployeeambitionsummary[0].IsActive,
                //OverallRatingManager = 0,
                //Hrfeedback = 0,
                //ManagementFeedback = 0,
                Year = DateTime.Now.Year
            };
            var month = DateTime.Now.Month;
            if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
            {
                tblEmployeeGoalOther.Cycle = "May-October";
            }
            else
            {
                tblEmployeeGoalOther.Cycle = "November-April";
            }
            _context.TblEmployeeGoalOther.Add(tblEmployeeGoalOther);
            await _context.SaveChangesAsync();
            //int id = _EmployeeGoalFromModel.employeegoal[0].id;
            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == idval && m.Year == _UpdateEmployeeGoalModel.year && m.Cycle == _UpdateEmployeeGoalModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                employeedata.SelfAssesmentStatus = 3;
                //employeedata.LeadAssesmentStatus = 1;
                await _context.SaveChangesAsync();
                var employeedata1 = _context.Employee.Where(m => m.Id == idval).FirstOrDefault();
                string description = employeedata1.Fname + " " + employeedata1.Lname + "submitted the Self Assesment";
                Hrnotification hrobj = new Hrnotification
                {
                    Description = description,
                    Hrid = employeedata.CreatedBy,
                    EmpId = idval,
                    IsRead = false
                };
                _context.Hrnotification.Add(hrobj);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }

            // Email Notification Code
            var EmailQueue = new AmsemailQueue()
            {
                EmployeeId = employeedata.CreatedBy,
                EventId = (int)NotificationType.EventType.SelfAssesmentEnd,
                PendingDate = DateTime.Now.Date,
                CreatedDate = DateTime.Now.Date,
                IsEmailSent = false,
                IsRead = false,
                IsActive = true,
                EmailType = (int)NotificationType.EventType.IntimationEmail,
                FkEmployeeId = idval,
                ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
            };
            _context.AmsemailQueue.Add(EmailQueue);
            await _context.SaveChangesAsync();
            return Ok(true);
        }

        [Route("SaveEmployeeGoalsRating")]
        [HttpPost]
        public async Task<IActionResult> SaveEmployeeGoalsRating(EmployeeSelfAssessmentModel _employeeSelfAssessmentModel)
        {
            int idval = _employeeSelfAssessmentModel.id;
            TblEmployeeGoal objval = new TblEmployeeGoal();
            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _employeeSelfAssessmentModel.year && m.Cycle == _employeeSelfAssessmentModel.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _employeeSelfAssessmentModel.Goaldataupdate)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _employeeSelfAssessmentModel.year && x.Cycle == _employeeSelfAssessmentModel.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingSelf = item.Ratings;
                        UpdateData.CommentSelf = item.Comments;
                        UpdateData.UpdatedOn = DateTime.Now;
                        UpdateData.UpdatedBy = idval.ToString();
                        if (_employeeSelfAssessmentModel.semiedit == 0)
                            UpdateData.EmployeeHasSubmitted = true;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            var employeegoalotherdata = await _context.TblEmployeeGoalOther.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _employeeSelfAssessmentModel.year && m.Cycle == _employeeSelfAssessmentModel.cycle).FirstOrDefaultAsync();
            if (employeegoalotherdata != null)
            {
                employeegoalotherdata.AmbitionsJobExpectations = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].AmbitionsJobExpectations;
                employeegoalotherdata.ActionPlanImprovementSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].ActionPlanImprovementSelf;
                employeegoalotherdata.SummarizeOverallPerformanceSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].SummarizeOverallPerformanceSelf;
                employeegoalotherdata.AreasImprovementSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].AreasImprovementSelf;
                employeegoalotherdata.IsActive = true;
                await _context.SaveChangesAsync();
            }
            else
            {
                TblEmployeeGoalOther tblEmployeeGoalOther = new TblEmployeeGoalOther
                {
                    EmployeeId = idval,
                    AmbitionsJobExpectations = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].AmbitionsJobExpectations,
                    ActionPlanImprovementSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].ActionPlanImprovementSelf,
                    SummarizeOverallPerformanceSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].SummarizeOverallPerformanceSelf,
                    AreasImprovementSelf = _employeeSelfAssessmentModel.Goalemployeeambitionsummary[0].AreasImprovementSelf,
                    IsActive = true,
                    //tblEmployeeGoalOther.OverallRatingManager = 0;
                    //tblEmployeeGoalOther.Hrfeedback = 0;
                    //tblEmployeeGoalOther.ManagementFeedback = 0;
                    Year = DateTime.Now.Year
                };
                var month = DateTime.Now.Month;
                if (month >= 6 && month <= 11)
                {
                    tblEmployeeGoalOther.Cycle = "May-October";
                }
                else
                {
                    tblEmployeeGoalOther.Cycle = "November-April";
                }
                _context.TblEmployeeGoalOther.Add(tblEmployeeGoalOther);
                await _context.SaveChangesAsync();
            }
            //int id = _EmployeeGoalFromModel.employeegoal[0].id;

            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == idval && m.Year == _employeeSelfAssessmentModel.year && m.Cycle == _employeeSelfAssessmentModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                if (_employeeSelfAssessmentModel.semiedit == 0)
                {
                    employeedata.SelfAssesmentStatus = 3;
                    //employeedata.LeadAssesmentStatus = 1;
                    await _context.SaveChangesAsync();
                    var employeedata1 = _context.Employee.Where(m => m.Id == idval).FirstOrDefault();
                    string description = employeedata1.Fname + " " + employeedata1.Lname + "submitted the Self Assesment";
                    Hrnotification hrobj = new Hrnotification();
                    hrobj.Description = description;
                    hrobj.Hrid = employeedata.CreatedBy;
                    hrobj.EmpId = idval;
                    hrobj.IsRead = false;
                    _context.Hrnotification.Add(hrobj);
                    await _context.SaveChangesAsync();

                    // Email Notification Code
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = employeedata.CreatedBy,
                        EventId = (int)NotificationType.EventType.SelfAssesmentEnd,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = idval,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    employeedata.SelfAssesmentStatus = 2;
                    //employeedata.LeadAssesmentStatus = 1;
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("EmployeeGoalSetting")]
        [HttpPost]
        public async Task<IActionResult> EmployeeGoalSetting(EmployeeGoalModel _EmployeeGoalModel)
        {
            var employeedata = _context.Employee.Where(m => m.Id == _EmployeeGoalModel.id).FirstOrDefault();
            var managerdata = _context.EmployeeManagerList.Where(a => a.EmployeeId == _EmployeeGoalModel.id).FirstOrDefault();
            if (managerdata != null)
            {
                string Emp_Id = employeedata.EmpId;
                int id = Convert.ToInt32(employeedata.FkDepartment);
                ManagerDetails managerDetails = await model.GetManagerDetails(id);
                TblEmployeeGoalSettingForm obj = new TblEmployeeGoalSettingForm();
                obj.EmployeeId = employeedata.Id;
                obj.ManagerId = managerdata.ManagerId;
                obj.TotalDaysToSubmitForManagerGoalSetting = 3;
                obj.TotalDaysToSubmitForEmployeeGoalSetting = 1;
                obj.TotalDaysToSubmitForManagerReview = 4;
                obj.TotalDaysToSubmitForEmployeeReview = 1;
                obj.IsGoalSettingStage = true;
                obj.IsReviewStage = false;
                obj.IsActive = true;
                obj.IsProcessClosure = false;
                obj.HrassesmentStatus = 1;
                obj.GoalsettingByLeadStatus = 2;
                obj.HrinitiateFormStatus = 3;
                obj.SelfAssesmentStatus = 1;
                obj.LeadAssesmentStatus = 1;
                obj.CreatedBy = _EmployeeGoalModel.createdById;
                obj.ProjectManagerAssesmentStatus = 1;
                obj.EvaluationStartDate = DateTime.Now.Date;
                obj.CreatedOn = DateTime.Now;
                obj.UpdatedOn = DateTime.Now;
                obj.Year = DateTime.Now.Year;
                var month = DateTime.Now.Month;
                obj.ManagementFeedbackStatus = 1;
                if (employeedata.FkDepartment == 9 || employeedata.FkDepartment == 10 || employeedata.FkDepartment == 7)
                {
                    obj.ManagementId = 452; //Divya Ma'am
                }
                else
                {
                    obj.ManagementId = 447; //Soumayjit sir
                }
                if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
                {
                    obj.Cycle = "May-October";
                }
                else
                {
                    obj.Cycle = "November-April";
                }
                obj.EmailSent04Pm = 0;
                obj.EmailSent11Am = 0;
                obj.GoalSettingStartDate = DateTime.Now.Date;
                obj.GoalSettingEndDate = GetDate(3);//DateTime.Now.AddDays(3).Date;
                _context.TblEmployeeGoalSettingForm.Add(obj);
                await _context.SaveChangesAsync();
                // Manager Email Goal Setting Code
                //EmailSend emailSend = new EmailSend();
                //bool isMailSend = false;
                //RandomGenerator generator = new RandomGenerator();
                //string pass = generator.RandomPassword();
                //isMailSend = true;
                //isMailSend = await emailSend.emailSend(managerDetails.OfficialEmail, pass, managerDetails.FullName);

                int managerId = Convert.ToInt32(managerdata.ManagerId);
                string description = "Hr initiates a goal form of" + " " + employeedata.Fname + " " + employeedata.Lname;
                LeadNotification leadobj = new LeadNotification
                {
                    Description = description,
                    LeadId = managerId,
                    EmpId = _EmployeeGoalModel.id,
                    IsRead = false
                };
                _context.LeadNotification.Add(leadobj);
                await _context.SaveChangesAsync();

                // Email Notification Code
                var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.Id).Select(x => x.ManagerId).FirstOrDefault();
                // Intimation
                var EmailQueue = new AmsemailQueue()
                {
                    EmployeeId = (int)SubManagerId,
                    EventId = (int)NotificationType.EventType.GoalSettingStart,
                    PendingDate = DateTime.Now.Date,
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.IntimationEmail,
                    FkEmployeeId = employeedata.Id,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.Id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue);
                await _context.SaveChangesAsync();

                // Email 11AM
                var EmailQueue1 = new AmsemailQueue()
                {
                    EmployeeId = (int)SubManagerId,
                    EventId = (int)NotificationType.EventType.GoalSettingStart,
                    PendingDate = GetDate(3),//DateTime.Now.Date.AddDays(3),
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.EmailSent11Am,
                    FkEmployeeId = employeedata.Id,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.Id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue1);
                await _context.SaveChangesAsync();

                // Email 4PM
                var EmailQueue2 = new AmsemailQueue()
                {
                    EmployeeId = (int)SubManagerId,
                    EventId = (int)NotificationType.EventType.GoalSettingStart,
                    PendingDate = GetDate(3),//DateTime.Now.Date.AddDays(3),
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.EmailSent04PM,
                    FkEmployeeId = employeedata.Id,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.Id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue2);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Ok(false);
            }
            return Ok(true);
        }

        [Route("ReinitiateEmployeeGoal")]
        [HttpPost]
        public async Task<IActionResult> ReinitiateEmployeeGoal(EmployeeGoalModel _EmployeeGoalModel)
        {
            int id = _EmployeeGoalModel.id;
            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == id && m.Year == _EmployeeGoalModel.year && m.Cycle == _EmployeeGoalModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                if (employeedata.SelfAssesmentStatus == 1)
                {
                    employeedata.SelfAssesmentStatus = 2;
                    employeedata.SelfAssesmentStartDate = DateTime.Now.Date;
                    employeedata.SelfAssesmentEndDate = GetDate(1);//DateTime.Now.AddDays(1).Date;
                    await _context.SaveChangesAsync();

                    // Email Notification Code
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = (int)employeedata.EmployeeId,
                        EventId = (int)NotificationType.EventType.SelfAssesmentStart,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();

                    var EmailQueue1 = new AmsemailQueue()
                    {
                        EmployeeId = (int)employeedata.EmployeeId,
                        EventId = (int)NotificationType.EventType.SelfAssesmentStart,
                        PendingDate = GetDate(1),//DateTime.Now.Date.AddDays(1),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent11Am,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue1);
                    await _context.SaveChangesAsync();

                    var EmailQueue2 = new AmsemailQueue()
                    {
                        EmployeeId = (int)employeedata.EmployeeId,
                        EventId = (int)NotificationType.EventType.SelfAssesmentStart,
                        PendingDate = GetDate(1),//DateTime.Now.Date.AddDays(1),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent04PM,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue2);
                    await _context.SaveChangesAsync();
                }
                else if (employeedata.SelfAssesmentStatus == 3)
                {
                    employeedata.LeadAssesmentStatus = 2;
                    employeedata.LeadAssesmentStartDate = DateTime.Now.Date;
                    employeedata.LeadAssesmentEndDate = GetDate(3);//DateTime.Now.AddDays(3).Date;
                    employeedata.ProjectManagerAssesmentStartDate = GetDate(4);//DateTime.Now.AddDays(4).Date;
                    employeedata.ProjectManagerAssesmentEndDate = GetDate(5);//DateTime.Now.AddDays(5).Date;
                    await _context.SaveChangesAsync();

                    // Email Notification Code
                    var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId).Select(x => x.ManagerId).FirstOrDefault();
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = (int)SubManagerId,
                        EventId = (int)NotificationType.EventType.LeadAssesmentStart,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();

                    var EmailQueue1 = new AmsemailQueue()
                    {
                        EmployeeId = (int)SubManagerId,
                        EventId = (int)NotificationType.EventType.LeadAssesmentStart,
                        PendingDate = GetDate(3),//DateTime.Now.Date.AddDays(3),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent11Am,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue1);
                    await _context.SaveChangesAsync();

                    var EmailQueue2 = new AmsemailQueue()
                    {
                        EmployeeId = (int)SubManagerId,
                        EventId = (int)NotificationType.EventType.LeadAssesmentStart,
                        PendingDate = GetDate(3),//DateTime.Now.Date.AddDays(3),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent04PM,
                        FkEmployeeId = employeedata.EmployeeId,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue2);
                    await _context.SaveChangesAsync();
                }

            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("ReinitiateEmployeeLeadAssesment")]
        [HttpPost]
        public async Task<IActionResult> ReinitiateEmployeeLeadAssesment(EmployeeGoalModel _EmployeeGoalModel)
        {
            int id = _EmployeeGoalModel.id;
            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == id && m.Year == _EmployeeGoalModel.year && m.Cycle == _EmployeeGoalModel.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                employeedata.LeadAssesmentStatus = 2;
                await _context.SaveChangesAsync();
                var managerdata = _context.EmployeeManagerList.Where(a => a.EmployeeId == _EmployeeGoalModel.id).FirstOrDefault();
                int managerId = Convert.ToInt32(managerdata.ManagerId);
                var employeedata1 = _context.Employee.Where(m => m.Id == _EmployeeGoalModel.id).FirstOrDefault();
                string description = "Hr initiates a Lead Assesment form of" + " " + employeedata1.Fname + " " + employeedata1.Lname;
                LeadNotification leadobj = new LeadNotification
                {
                    Description = description,
                    LeadId = managerId,
                    EmpId = _EmployeeGoalModel.id,
                    IsRead = false
                };
                _context.LeadNotification.Add(leadobj);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("loginDetail")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                EmployeeViewApiModel user = _context.Employee.Where(usr => usr.EmpId == model.UserName &&
           usr.LoginPassword == model.Password && usr.EmpStatus == "Active").Select(x => new EmployeeViewApiModel
           {
               Id = x.Id,
               EmpId = x.EmpId,
               FullName = x.FullName,
               Roles = _context.EmployeeRole.Join(_context.TblERole, a => a.FkRole, b => b.Id, (a, b) => new { a, b }).Where(i => i.a.FkEmployee == x.Id).Select(z => new Roles
               {
                   Id = z.b.Id,
                   Role = z.b.RoleName
               }).ToList(),
           }).SingleOrDefault();
                if (user != null)
                {
                    Manager userdetail = await _context.Set<Manager>().FromSql("dbo.Emp_GetLoginEmployeedetail @userid = {0}", user.Id).FirstOrDefaultAsync();
                    return Ok(userdetail);
                }
                else
                {
                    login login = new login();
                    login.islogin = false;
                    return Ok(login);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [Route("loginDetail_V2")]
        [HttpPost]
        public async Task<IActionResult> loginDetailV2(LoginViewModel model)
        {
            try
            {
                EmployeeViewApiModel user = _context.Employee.Where(usr => usr.EmpId == model.UserName &&
           usr.LoginPassword == model.Password && usr.EmpStatus == "Active").Select(x => new EmployeeViewApiModel
           {
               Id = x.Id,
               EmpId = x.EmpId,
               FullName = x.FullName,
               Roles = _context.EmployeeRole.Join(_context.TblERole, a => a.FkRole, b => b.Id, (a, b) => new { a, b }).Where(i => i.a.FkEmployee == x.Id).Select(z => new Roles
               {
                   Id = z.b.Id,
                   Role = z.b.RoleName
               }).ToList(),
           }).SingleOrDefault();
                if (user != null)
                {
                    List<Manager_v2> userdetail = await _context.Set<Manager_v2>().FromSql("dbo.Emp_GetLoginEmployeedetail_V2 @userid = {0}", user.Id).ToListAsync();
                    return Ok(userdetail);
                }
                else
                {
                    login login = new login();
                    login.islogin = false;
                    return Ok(login);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [Route("GetUserInfoById")]
        [HttpPost]
        public async Task<IActionResult> GetUserInfo(EmployeeGoalEMPModel _EmployeeGoalEMPModel)
        {
            try
            {
                var GetDepartData = await _context.TblEDepartment.ToListAsync();
                EmployeeBasicDetails data = await (from Employee E in _context.Employee
                                                   join Ed in _context.TblEDepartment on E.FkDepartment equals Ed.Id
                                                   join G in _context.TblEGrade on E.FkEmpGrade equals G.Id
                                                   join D in _context.TblEDesignation on E.FkDesignation equals D.Id
                                                   join EG in _context.TblEmployeeGoalSettingForm on E.Id equals EG.EmployeeId into ps
                                                   from p in ps.DefaultIfEmpty()
                                                   where E.Id == _EmployeeGoalEMPModel.id
                                                   select new EmployeeBasicDetails
                                                   {
                                                       ID = E.Id,
                                                       Emp_Id = E.EmpId,
                                                       Emp_Code = E.EmpCode,
                                                       FullName = E.FullName,
                                                       DOJ = E.Doj.Value.ToString("dd-MMMM-yy"),
                                                       OfficialEmail = E.OfficialEmail,
                                                       Department = Ed.DeptName,
                                                       Designation = D.Description,
                                                       Grade = G.Description,
                                                       ReportingTo = null,//_context.Employee.FirstOrDefault(x => x.Id == E.ProjectReportingTo).FullName,
                                                       EvaluationStartDate = p.EvaluationStartDate == null ? string.Empty : p.EvaluationStartDate.Value.ToString("dd-MMMM-yy"),
                                                       EvaluationEndDate = p.EvaluationEndDate == null ? string.Empty : p.EvaluationEndDate.Value.ToString("dd-MMMM-yy"),
                                                   }).FirstOrDefaultAsync();
                //int ID = data.ID;
                int ID = (int)_context.EmployeeManagerList.Where(x => x.EmployeeId == data.ID).Select(x => x.ManagerId).FirstOrDefault();
                bool manager = (bool)_context.ManagerList.Where(x => x.ManagerId == ID).Select(x => x.SubManager).FirstOrDefault();
                if (manager == true)
                {
                    ID = (int)_context.EmployeeManagerList.Where(x => x.EmployeeId == ID).Select(x => x.ManagerId).FirstOrDefault();
                }
                //var GetDeptData = await _context.Employee.Where(x => x.Id == ID).FirstOrDefaultAsync();
                //int FkDept = (int)GetDeptData.FkDepartment;
                //string GetDeptHeadID = GetDepartData.Where(x => x.Id == FkDept).FirstOrDefault().DepartmentHead;
                data.ReportingTo = _context.Employee.FirstOrDefault(x => x.Id == Convert.ToInt32(ID)).FullName;
                //data.Add(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetGoalByEmpId")]
        [HttpPost]
        public async Task<IActionResult> GetGoal(EmployeeGoalEMPModel _EmployeeGoalEMPModel)
        {
            try
            {

                var data = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == _EmployeeGoalEMPModel.id && m.IsActive == true && m.Year == _EmployeeGoalEMPModel.year && m.Cycle == _EmployeeGoalEMPModel.cycle).ToListAsync();

                return Ok(data);
            }
            catch (Exception)
            {

                return NotFound();
            }
        }

        [Route("EditEmployeeGoalForm")]
        [HttpPost]
        public async Task<IActionResult> PostEditEmployeeGoalForm(EmployeeGoalUpdatebyManagerModel _EmployeeGoalFromModel)
        {
            int id = _EmployeeGoalFromModel.editemployeegoal[0].id;
            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == id && m.IsActive == true && m.Year == _EmployeeGoalFromModel.year && m.Cycle == _EmployeeGoalFromModel.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _EmployeeGoalFromModel.editemployeegoal)
                {
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _EmployeeGoalFromModel.year && x.Cycle == _EmployeeGoalFromModel.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.Description = item.description;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("GetEmployeeRcInfoById")]
        [HttpPost]
        public async Task<IActionResult> GetEmployeeRcInfo(EmployeeGoalEMPModel _EmployeeGoalEMPModel)
        {
            try
            {
                EmployeeRatingDetail employeeRating = new EmployeeRatingDetail();
                List<EmployeeRating> _listrating = new List<EmployeeRating>();
                List<EmployeeAmbition> _listEmployeeAmbition = new List<EmployeeAmbition>();
                List<ManagerBehaviourRatingComment> _listManagerBehaviour = new List<ManagerBehaviourRatingComment>();
                EmployeeAmbition data = new EmployeeAmbition();
                _listrating = await (from TblEmployeeGoal E in _context.TblEmployeeGoal.AsNoTracking()
                                     where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                     select new EmployeeRating
                                     {
                                         ID = E.Id,
                                         Emp_Id = E.EmployeeId,
                                         CreatedOn = E.CreatedOn.Value.ToString("dd-MMMM-yy"),
                                         Description = E.Description,
                                         Ratings = E.RatingSelf ?? 0,
                                         Comments = E.CommentSelf,
                                         goalCategoryId = E.MasterGoalCategoryId == null ? 0 : (int)E.MasterGoalCategoryId
                                     }).ToListAsync();

                _listEmployeeAmbition = await (from TblEmployeeGoalOther E in _context.TblEmployeeGoalOther.AsNoTracking()
                                               where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                               select new EmployeeAmbition
                                               {
                                                   ID = E.Id,
                                                   Ambitions = E.AmbitionsJobExpectations,
                                                   Summarize = E.SummarizeOverallPerformanceSelf,
                                                   AreaImproveSelf = E.AreasImprovementSelf,
                                                   ActionPlanImproveSelf = E.ActionPlanImprovementSelf,
                                                   Emp_Id = (int)E.EmployeeId
                                               }).ToListAsync();

                _listManagerBehaviour = await (from TblEmployeeBehaviouralGoal E in _context.TblEmployeeBehaviouralGoal.AsNoTracking()
                                               where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                               select new ManagerBehaviourRatingComment
                                               {
                                                   id = (int)E.EmployeeId,
                                                   ManagerRating = E.RatingManagerEvaluation ?? 0,
                                                   ManagerComments = E.CommentManagerEvaluation,
                                                   IsActive = (bool)E.IsActive,
                                                   Pid = E.Id,
                                               }).ToListAsync();

                employeeRating._EmployeeRatinglist = _listrating;
                employeeRating._EmployeeAmbitionlist = _listEmployeeAmbition;
                employeeRating._ManagerBehaviourRatinglist = _listManagerBehaviour;
                return Ok(employeeRating);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("UpdateEmployeeRatingComment")]
        [HttpPost]
        public async Task<IActionResult> SaveEmployeeRcAfterEdit(SaveEditEmployeeGoalModel _SaveEditEmployeeGoalModel)
        {
            int idval = _SaveEditEmployeeGoalModel.Goaldataupdate[0].id;
            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _SaveEditEmployeeGoalModel.year && m.Cycle == _SaveEditEmployeeGoalModel.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _SaveEditEmployeeGoalModel.Goaldataupdate)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _SaveEditEmployeeGoalModel.year && x.Cycle == _SaveEditEmployeeGoalModel.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingSelf = item.RatingSelf;
                        UpdateData.CommentSelf = item.CommentSelf;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            var AmbitionData = await _context.TblEmployeeGoalOther.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _SaveEditEmployeeGoalModel.year && m.Cycle == _SaveEditEmployeeGoalModel.cycle).FirstOrDefaultAsync();
            if (AmbitionData != null)
            {
                int Pid = AmbitionData.Id;
                var UpdateAmbitionData = _context.TblEmployeeGoalOther.Where(x => x.Id == Pid && x.Year == _SaveEditEmployeeGoalModel.year && x.Cycle == _SaveEditEmployeeGoalModel.cycle).FirstOrDefault();
                if (UpdateAmbitionData != null)
                {

                    UpdateAmbitionData.EmployeeId = _SaveEditEmployeeGoalModel.EditGoalemployeeambitionsummary[0].id;
                    UpdateAmbitionData.AmbitionsJobExpectations = _SaveEditEmployeeGoalModel.EditGoalemployeeambitionsummary[0].AmbitionsJobExpectations;
                    UpdateAmbitionData.ActionPlanImprovementSelf = _SaveEditEmployeeGoalModel.EditGoalemployeeambitionsummary[0].ActionPlanImprovementSelf;
                    UpdateAmbitionData.SummarizeOverallPerformanceSelf = _SaveEditEmployeeGoalModel.EditGoalemployeeambitionsummary[0].SummarizeOverallPerformanceSelf;
                    UpdateAmbitionData.AreasImprovementSelf = _SaveEditEmployeeGoalModel.EditGoalemployeeambitionsummary[0].AreasImprovementSelf;
                    UpdateAmbitionData.IsActive = true;

                    await _context.SaveChangesAsync();
                    //  _context.TblEmployeeGoalOther.Add(tblEmployeeGoalOther);
                }

            }

            return Ok(true);
        }

        [Route("SaveManagerAllRatingComment")]
        [HttpPost]
        public async Task<IActionResult> SaveManagerAllRatingComment(SaveManagerRatingCommentBehaviourGoal _SaveManagerRatingCommentBehaviourGoal)
        {
            int idval = _SaveManagerRatingCommentBehaviourGoal.ManagerRatingComment[0].id;

            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _SaveManagerRatingCommentBehaviourGoal.year && m.Cycle == _SaveManagerRatingCommentBehaviourGoal.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _SaveManagerRatingCommentBehaviourGoal.ManagerRatingComment)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _SaveManagerRatingCommentBehaviourGoal.year && x.Cycle == _SaveManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingManager = item.Ratings;
                        UpdateData.CommentManager = item.Comments;
                        UpdateData.ManagerHasSubmitted = true;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            var employeeGoalOtherldata = await _context.TblEmployeeGoalOther.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _SaveManagerRatingCommentBehaviourGoal.year && m.Cycle == _SaveManagerRatingCommentBehaviourGoal.cycle).ToListAsync();
            if (employeeGoalOtherldata != null)
            {
                foreach (var item in _SaveManagerRatingCommentBehaviourGoal.Summary)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.Pid;
                    var UpdateGoalOtherData = _context.TblEmployeeGoalOther.Where(x => x.Id == PID && x.Year == _SaveManagerRatingCommentBehaviourGoal.year && x.Cycle == _SaveManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
                    if (UpdateGoalOtherData != null)
                    {
                        UpdateGoalOtherData.SummarizeOverallPerformanceManager = item.SummarizeOverallPerformanceManager;
                        UpdateGoalOtherData.AreasImprovementManager = item.AreasImprovementManager;
                        UpdateGoalOtherData.ActionPlanImprovementManager = item.ActionPlanImprovementManager;
                        UpdateGoalOtherData.OverallRatingManager = item.OverallRatingManager;
                        UpdateGoalOtherData.OverallRatingManagercomment = item.OverallRatingManagercomment;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            try
            {

                foreach (var item in _SaveManagerRatingCommentBehaviourGoal.BehaviourRatingComment)
                {
                    TblEmployeeBehaviouralGoal tblEmployeeBehaviouralGoal = new TblEmployeeBehaviouralGoal();
                    tblEmployeeBehaviouralGoal.EmployeeId = item.id;
                    tblEmployeeBehaviouralGoal.GoalDescription = item.Behaviouralgoals;
                    tblEmployeeBehaviouralGoal.RatingManagerEvaluation = item.ManagerRating;
                    tblEmployeeBehaviouralGoal.CommentManagerEvaluation = item.ManagerComments;
                    tblEmployeeBehaviouralGoal.IsActive = true; //_SaveManagerRatingCommentBehaviourGoal.BehaviourRatingComment[0].IsActive;
                    tblEmployeeBehaviouralGoal.Year = DateTime.Now.Year;
                    var month = DateTime.Now.Month;
                    if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
                    {
                        tblEmployeeBehaviouralGoal.Cycle = "May-October";
                    }
                    else
                    {
                        tblEmployeeBehaviouralGoal.Cycle = "November-April";
                    }
                    _context.TblEmployeeBehaviouralGoal.Add(tblEmployeeBehaviouralGoal);
                    await _context.SaveChangesAsync();

                }


            }
            catch (Exception ex)
            {
                return NotFound();
            }

            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == idval && m.Year == _SaveManagerRatingCommentBehaviourGoal.year && m.Cycle == _SaveManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                employeedata.LeadAssesmentStatus = 3;
                employeedata.ProjectManagerAssesmentStatus = 2;
                await _context.SaveChangesAsync();

                // Email Notification Code
                var ManagerId = _context.TblEmployeeGoalSettingForm.Where(x => x.EmployeeId == idval).Select(x => x.ManagerId).FirstOrDefault();
                var EmailQueue = new AmsemailQueue()
                {
                    EmployeeId = (int)ManagerId,
                    EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                    PendingDate = DateTime.Now.Date,
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.IntimationEmail,
                    FkEmployeeId = idval,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue);
                await _context.SaveChangesAsync();

                var EmailQueue1 = new AmsemailQueue()
                {
                    EmployeeId = (int)ManagerId,
                    EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                    PendingDate = GetDate(1),//DateTime.Now.Date.AddDays(1),
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.EmailSent11Am,
                    FkEmployeeId = idval,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue1);
                await _context.SaveChangesAsync();

                var EmailQueue2 = new AmsemailQueue()
                {
                    EmployeeId = (int)ManagerId,
                    EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                    PendingDate = GetDate(1),//DateTime.Now.Date.AddDays(1),
                    CreatedDate = DateTime.Now.Date,
                    IsEmailSent = false,
                    IsRead = false,
                    IsActive = true,
                    EmailType = (int)NotificationType.EventType.EmailSent04PM,
                    FkEmployeeId = idval,
                    ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                };
                _context.AmsemailQueue.Add(EmailQueue2);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("SaveManagerRatingsComment")]
        [HttpPost]
        public async Task<IActionResult> SaveManagerRatingsComment(SetManagerAssessment _setManagerAssessment)
        {
            int idval = _setManagerAssessment.empId;

            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _setManagerAssessment.year && m.Cycle == _setManagerAssessment.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _setManagerAssessment.ManagerRatingComment)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _setManagerAssessment.year && x.Cycle == _setManagerAssessment.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingManager = item.Ratings;
                        UpdateData.CommentManager = item.Comments;
                        if (_setManagerAssessment.semiedit == 0)
                            UpdateData.ManagerHasSubmitted = true;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            var employeeGoalOtherldata = await _context.TblEmployeeGoalOther.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _setManagerAssessment.year && m.Cycle == _setManagerAssessment.cycle).ToListAsync();
            if (employeeGoalOtherldata != null)
            {
                foreach (var item in _setManagerAssessment.Summary)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.Pid;
                    var UpdateGoalOtherData = _context.TblEmployeeGoalOther.Where(x => x.Id == PID && x.Year == _setManagerAssessment.year && x.Cycle == _setManagerAssessment.cycle).FirstOrDefault();
                    if (UpdateGoalOtherData != null)
                    {
                        UpdateGoalOtherData.SummarizeOverallPerformanceManager = item.SummarizeOverallPerformanceManager;
                        UpdateGoalOtherData.AreasImprovementManager = item.AreasImprovementManager;
                        UpdateGoalOtherData.ActionPlanImprovementManager = item.ActionPlanImprovementManager;
                        //UpdateGoalOtherData.OverallRatingManager = item.OverallRatingManager;
                        //UpdateGoalOtherData.OverallRatingManagercomment = item.OverallRatingManagercomment;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            try
            {
                var BehaviourGoalData = await _context.TblEmployeeBehaviouralGoal.Where(x => x.EmployeeId == idval && x.Year == _setManagerAssessment.year && x.Cycle == _setManagerAssessment.cycle).ToListAsync();
                if (BehaviourGoalData != null && BehaviourGoalData.Count > 0)
                {
                    foreach (var updateBeahviour in BehaviourGoalData)
                    {
                        var item = _setManagerAssessment.BehaviourRatingComment.Where(x => x.Behaviouralgoals == updateBeahviour.FkbehaviouralGoalsMasterId).FirstOrDefault();
                        updateBeahviour.FkbehaviouralGoalsMasterId = item.Behaviouralgoals;
                        updateBeahviour.RatingManagerEvaluation = item.ManagerRating;
                        updateBeahviour.CommentManagerEvaluation = item.ManagerComments;
                        await _context.SaveChangesAsync();

                    }
                }
                else
                {
                    foreach (var item in _setManagerAssessment.BehaviourRatingComment)
                    {
                        TblEmployeeBehaviouralGoal tblEmployeeBehaviouralGoal = new TblEmployeeBehaviouralGoal();
                        tblEmployeeBehaviouralGoal.EmployeeId = idval;
                        //tblEmployeeBehaviouralGoal.GoalDescription = item.Behaviouralgoals;
                        tblEmployeeBehaviouralGoal.FkbehaviouralGoalsMasterId = item.Behaviouralgoals;
                        tblEmployeeBehaviouralGoal.RatingManagerEvaluation = item.ManagerRating;
                        tblEmployeeBehaviouralGoal.CommentManagerEvaluation = item.ManagerComments;
                        tblEmployeeBehaviouralGoal.IsActive = true; //_SaveManagerRatingCommentBehaviourGoal.BehaviourRatingComment[0].IsActive;
                        tblEmployeeBehaviouralGoal.Year = DateTime.Now.Year;
                        tblEmployeeBehaviouralGoal.CreatedBy = idval.ToString();
                        tblEmployeeBehaviouralGoal.UpdatedBy = idval.ToString();
                        tblEmployeeBehaviouralGoal.CreatedOn = DateTime.Now;
                        tblEmployeeBehaviouralGoal.UpdatedOn = tblEmployeeBehaviouralGoal.CreatedOn;
                        var month = DateTime.Now.Month;
                        if (month == 11 || month == 6 || month == 7 || month == 8 || month == 9 || month == 10)
                        {
                            tblEmployeeBehaviouralGoal.Cycle = "May-October";
                        }
                        else
                        {
                            tblEmployeeBehaviouralGoal.Cycle = "November-April";
                        }
                        _context.TblEmployeeBehaviouralGoal.Add(tblEmployeeBehaviouralGoal);
                        await _context.SaveChangesAsync();

                    }

                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            if (_setManagerAssessment.semiedit == 0)
            {
                var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == idval && m.Year == _setManagerAssessment.year && m.Cycle == _setManagerAssessment.cycle).FirstOrDefault();
                if (employeedata != null)
                {
                    employeedata.LeadAssesmentStatus = 3;
                    employeedata.ProjectManagerAssesmentStatus = 2;
                    await _context.SaveChangesAsync();

                    // Email Notification Code
                    var ManagerId = _context.TblEmployeeGoalSettingForm.Where(x => x.EmployeeId == idval).Select(x => x.ManagerId).FirstOrDefault();
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = (int)ManagerId,
                        EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = idval,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();

                    var EmailQueue1 = new AmsemailQueue()
                    {
                        EmployeeId = (int)ManagerId,
                        EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                        PendingDate = DateTime.Now.Date.AddDays(1),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent11Am,
                        FkEmployeeId = idval,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue1);
                    await _context.SaveChangesAsync();

                    var EmailQueue2 = new AmsemailQueue()
                    {
                        EmployeeId = (int)ManagerId,
                        EventId = (int)NotificationType.EventType.ManagerAssesmentStart,
                        PendingDate = DateTime.Now.Date.AddDays(1),
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.EmailSent04PM,
                        FkEmployeeId = idval,
                        ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == idval && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault()
                    };
                    _context.AmsemailQueue.Add(EmailQueue2);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok(true);
        }

        [Route("GetManagerRcInfoById")]
        [HttpPost]
        public async Task<IActionResult> GetManagerRcInfo(EmployeeGoalEMPModel _EmployeeGoalEMPModel)
        {
            try
            {
                ManagerRatingDetail managerRating = new ManagerRatingDetail();
                List<ManagerRating> _listrating = new List<ManagerRating>();
                List<ManagerSummary> _listManagerSummary = new List<ManagerSummary>();
                List<ManagerBehaviourRatingComment> _listManagerBehaviour = new List<ManagerBehaviourRatingComment>();
                ManagerSummary data = new ManagerSummary();
                _listrating = await (from TblEmployeeGoal E in _context.TblEmployeeGoal.AsNoTracking()
                                     where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                     select new ManagerRating
                                     {
                                         ID = E.Id,
                                         Emp_Id = E.EmployeeId,
                                         CreatedOn = E.CreatedOn.Value.ToString("dd-MMMM-yy"),
                                         Description = E.Description,
                                         Ratings = E.RatingSelf ?? 0,
                                         Comments = E.CommentSelf,
                                         RatingManager = E.RatingManager ?? 0,
                                         CommentManager = E.CommentManager,
                                     }).ToListAsync();

                _listManagerSummary = await (from TblEmployeeGoalOther E in _context.TblEmployeeGoalOther.AsNoTracking()
                                             where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                             select new ManagerSummary
                                             {
                                                 ID = E.Id,
                                                 Ambitions = E.AmbitionsJobExpectations,
                                                 Summarize = E.SummarizeOverallPerformanceSelf,
                                                 AreaImproveSelf = E.AreasImprovementSelf,
                                                 ActionPlanImproveSelf = E.ActionPlanImprovementSelf,
                                                 ActionPlanImprovementManager = E.ActionPlanImprovementManager,
                                                 AreasImprovementManager = E.AreasImprovementManager,
                                                 SummarizeOverallPerformanceManager = E.SummarizeOverallPerformanceManager,
                                                 OverallRatingManager = (decimal)E.OverallRatingManager,
                                                 OverallRatingManagercomment = E.ProjectManagerFeedbackcomment,
                                                 Hrfeedback = (decimal)E.Hrfeedback,
                                                 Hrfeedbackcomment = E.Hrfeedbackcomment,
                                                 ManagementFeedback = (decimal)E.ManagementFeedback,
                                                 ManagementFeedbackcomment = E.ManagementFeedbackcomment,
                                                 Emp_Id = (int)E.EmployeeId,
                                                 ProjectManagerFeedbackComment = E.ProjectManagerFeedbackcomment
                                             }).ToListAsync();

                _listManagerBehaviour = await (from TblEmployeeBehaviouralGoal E in _context.TblEmployeeBehaviouralGoal.AsNoTracking()
                                               where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                               select new ManagerBehaviourRatingComment
                                               {
                                                   id = (int)E.EmployeeId,
                                                   ManagerRating = E.RatingManagerEvaluation ?? 0,
                                                   ManagerComments = E.CommentManagerEvaluation,
                                                   IsActive = (bool)E.IsActive,
                                                   Pid = (int)E.Id,
                                               }).ToListAsync();

                managerRating._ManagerRatinglist = _listrating;
                managerRating._ManagerSummarylist = _listManagerSummary;
                managerRating._ManagerBehaviourRatinglist = _listManagerBehaviour;
                return Ok(managerRating);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("EditManagerAllRatingComment")]
        [HttpPost]
        public async Task<IActionResult> EditManagerAllRatingComment(EditManagerRatingCommentBehaviourGoal _EditManagerRatingCommentBehaviourGoal)
        {
            int idval = _EditManagerRatingCommentBehaviourGoal.ManagerRatingComment[0].id;

            var employeegoaldata = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _EditManagerRatingCommentBehaviourGoal.year && m.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).ToListAsync();
            if (employeegoaldata != null)
            {
                foreach (var item in _EditManagerRatingCommentBehaviourGoal.ManagerRatingComment)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.pid;
                    var UpdateData = _context.TblEmployeeGoal.Where(x => x.Id == PID && x.Year == _EditManagerRatingCommentBehaviourGoal.year && x.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
                    if (UpdateData != null)
                    {
                        UpdateData.RatingManager = item.Ratings;
                        UpdateData.CommentManager = item.Comments;
                        UpdateData.ManagerHasSubmitted = true;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            var employeeGoalOtherldata = await _context.TblEmployeeGoalOther.Where(m => m.EmployeeId == idval && m.IsActive == true && m.Year == _EditManagerRatingCommentBehaviourGoal.year && m.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).ToListAsync();
            if (employeeGoalOtherldata != null)
            {
                foreach (var item in _EditManagerRatingCommentBehaviourGoal.Summary)
                {
                    // Update Data Based on Primary Key//
                    int PID = item.Pid;
                    var UpdateGoalOtherData = _context.TblEmployeeGoalOther.Where(x => x.Id == PID && x.Year == _EditManagerRatingCommentBehaviourGoal.year && x.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
                    if (UpdateGoalOtherData != null)
                    {
                        UpdateGoalOtherData.SummarizeOverallPerformanceManager = item.SummarizeOverallPerformanceManager;
                        UpdateGoalOtherData.AreasImprovementManager = item.AreasImprovementManager;
                        UpdateGoalOtherData.ActionPlanImprovementManager = item.ActionPlanImprovementManager;
                        UpdateGoalOtherData.OverallRatingManager = item.OverallRatingManager;
                        UpdateGoalOtherData.OverallRatingManagercomment = item.OverallRatingManagercomment;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            try
            {
                foreach (var item in _EditManagerRatingCommentBehaviourGoal.EditBehaviourRatingComment)
                {
                    int PID = item.Pid;
                    if (PID != null)
                    {
                        var UpdateBehaviourGoalData = _context.TblEmployeeBehaviouralGoal.Where(x => x.Id == PID && x.Year == _EditManagerRatingCommentBehaviourGoal.year && x.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
                        if (UpdateBehaviourGoalData != null)
                        {
                            UpdateBehaviourGoalData.RatingManagerEvaluation = item.ManagerRating;
                            UpdateBehaviourGoalData.CommentManagerEvaluation = item.ManagerComments;
                            UpdateBehaviourGoalData.IsActive = true;
                            await _context.SaveChangesAsync();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == idval && m.Year == _EditManagerRatingCommentBehaviourGoal.year && m.Cycle == _EditManagerRatingCommentBehaviourGoal.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                employeedata.LeadAssesmentStatus = 3;
                employeedata.ProjectManagerAssesmentStatus = 2;
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        [Route("SaveHrFeedback")]
        [HttpPost]
        public async Task<IActionResult> SaveHrFeedback(HrFeedbackComments _HrCumManagmentFeedbackComments)
        {
            try
            {
                int EmpId = _HrCumManagmentFeedbackComments.id;
                var Checkemployeegoaldataexists = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == EmpId && m.IsActive == true && m.Year == _HrCumManagmentFeedbackComments.year && m.Cycle == _HrCumManagmentFeedbackComments.cycle).ToListAsync();
                if (Checkemployeegoaldataexists != null)
                {
                    int pid = _HrCumManagmentFeedbackComments.pid;
                    var employeegoaldata = _context.TblEmployeeGoalOther.Where(m => m.Id == pid && m.Year == _HrCumManagmentFeedbackComments.year && m.Cycle == _HrCumManagmentFeedbackComments.cycle).FirstOrDefault();
                    if (employeegoaldata != null)
                    {
                        employeegoaldata.Hrfeedback = _HrCumManagmentFeedbackComments.Hrrating;
                        employeegoaldata.Hrfeedbackcomment = _HrCumManagmentFeedbackComments.Hrcomment;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                    //  return Ok(true);
                }
                var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == EmpId && m.Year == _HrCumManagmentFeedbackComments.year && m.Cycle == _HrCumManagmentFeedbackComments.cycle).FirstOrDefault();
                if (employeedata != null)
                {
                    employeedata.HrassesmentStatus = 3;
                    employeedata.ManagementFeedbackStatus = 2;
                    //employeedata.EvaluationEndDate = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
                return Ok(true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("GetLeadNotification")]
        [HttpPost]
        public async Task<IActionResult> GetLeadNotification(leadGoalNotificationbyID _leadGoalNotificationbyID)
        {
            try
            {
                //  var data = await _context.LeadNotification.Where(m => m.LeadId == _leadGoalNotificationbyID.id && m.IsRead==false).ToListAsync();
                var data = await _context.LeadNotification.OrderByDescending(x => x.Id).Where(m => m.LeadId == _leadGoalNotificationbyID.id && m.IsRead == false).ToListAsync();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("SaveLeadNotification")]
        [HttpPost]
        public async Task<IActionResult> PostLeadReadNotification(leadGoalNotificationbyID _leadGoalNotificationbyID)
        {
            try
            {
                int id = _leadGoalNotificationbyID.id;
                var Notificationdata = _context.LeadNotification.Where(m => m.Id == id).FirstOrDefault();
                if (Notificationdata != null)
                {
                    Notificationdata.IsRead = true;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetHrNotification")]
        [HttpPost]
        public async Task<IActionResult> GetHrNotification(hrGoalNotificationbyID _hrGoalNotificationbyID)
        {
            try
            {
                //var data = await _context.Hrnotification.Where(m => m.Hrid == _hrGoalNotificationbyID.id && m.IsRead == false).ToListAsync();
                var data = await _context.Hrnotification.OrderByDescending(x => x.Id).Where(m => m.Hrid == _hrGoalNotificationbyID.id && m.IsRead == false).ToListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("SaveHrNotification")]
        [HttpPost]
        public async Task<IActionResult> PostreadHrNotification(hrGoalNotificationbyID _hrGoalNotificationbyID)
        {
            try
            {
                int id = _hrGoalNotificationbyID.id;
                var Notificationdata = _context.Hrnotification.Where(m => m.Id == id).FirstOrDefault();
                if (Notificationdata != null)
                {
                    Notificationdata.IsRead = true;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetYearList")]
        [HttpGet]
        public IActionResult GetYearDropdownList()
        {
            try
            {
                List<yearlist> yeardrpList = _context.Set<yearlist>().FromSql("[dbo].[bindyear]").ToList();
                return Ok(yeardrpList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisal, methodName: GetYearDropdownList", "WEB/API");
                return null;
            }
        }

        [Route("GetEmployeelistbyyearandperiod")]
        [HttpPost]
        public async Task<IActionResult> GetEmployeelistbyyearandperiod(EmployeelistbyyearPeriodModel model)
        {
            try
            {
                List<EmployeeDetails> deptList = await _context.Set<EmployeeDetails>().FromSql("dbo.Appraisalcycledata @year = {0}, @cycle = {1}", model.year, model.cycle).ToListAsync();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("GetTeamList")]
        [HttpGet]
        public IActionResult GetTeamList()
        {
            try
            {
                //var managerList = _context.ManagerList.AsNoTracking().Select(x => x.ManagerId).ToList();
                var managerList = _context.ManagerList.Where(x => x.SubManager == true).AsNoTracking().Select(x => x.ManagerId).ToList();
                List<TeamManagementModel> teamList = _context.ManagerList.Where(x => x.SubManager == false).Select(z => new TeamManagementModel
                {
                    Id = z.Id,
                    DepartmentName = _context.TblEDepartment.Where(x => x.Id == z.DeptId).Select(x => x.DeptName).FirstOrDefault(),
                    DepartmentId = Convert.ToInt32(z.DeptId),
                    ManagerName = _context.Employee.Where(x => x.Id == z.ManagerId).Select(x => x.FullName).FirstOrDefault(),
                    ManagerId = Convert.ToInt32(z.ManagerId),
                    EmployeeCount = _context.EmployeeManagerList.Where(x => x.DeptId == z.DeptId && x.ManagerId == z.ManagerId).Select(x => x.EmployeeId).Count(),
                    //TotalEmployeeCount = _context.Employee.Where(x => x.FkDepartment == z.DeptId && x.EmpStatus == "Active" && !(managerList.Contains(x.Id))).Count()
                    TotalEmployeeCount = _context.Employee.Where(x => x.FkDepartment == z.DeptId && x.EmpStatus == "Active").Count()
                }).ToList();
                return Ok(teamList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisal, methodName: GetTeamList", "WEB/API");
                return null;
            }
        }

        [Route("SaveSelectedManager")]
        [HttpPost]
        public async Task<IActionResult> SaveSelectedManagerList(SaveManagerModel _SaveManagerModel)
        {
            try
            {
                var getdata = await _context.ManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.SubManager == false && !_SaveManagerModel.ManagerId.Contains(Convert.ToString(m.ManagerId))).ToListAsync();
                var getManagerData = await _context.ManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.SubManager == false && _SaveManagerModel.ManagerId.Contains(Convert.ToString(m.ManagerId))).Select(x => x.ManagerId).ToListAsync();
                var assignEmployeeData = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && _SaveManagerModel.ManagerId.Contains(Convert.ToString(m.EmployeeId))).ToListAsync();
                if (getdata.Count > 0)
                {
                    _context.ManagerList.RemoveRange(getdata); // Remove unassigned manager
                    foreach (var data in getdata)
                    {
                        var employeedata = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.ManagerId == data.ManagerId).ToListAsync();
                        if (employeedata.Count > 0)
                        {
                            _context.EmployeeManagerList.RemoveRange(employeedata); // Remove assigned Employee
                        }
                    }
                }
                if (assignEmployeeData.Count > 0)
                {
                    _context.EmployeeManagerList.RemoveRange(assignEmployeeData); // Removing employee from Assigned employee table before assigning it as manger
                }
                await _context.SaveChangesAsync();
                for (int i = 0; i < _SaveManagerModel.ManagerId.Length; i++)
                {
                    if (!getManagerData.Contains(Convert.ToInt32(_SaveManagerModel.ManagerId[i])))
                    {
                        ManagerList obj = new ManagerList();
                        obj.DeptId = _SaveManagerModel.DepId;
                        obj.ManagerId = Convert.ToInt32(_SaveManagerModel.ManagerId[i]);
                        obj.CreatedBy = _SaveManagerModel.CreatedBy;
                        obj.CreatedDate = DateTime.UtcNow;
                        obj.IsActive = true;
                        obj.SubManager = false;
                        _context.ManagerList.Add(obj);
                        await _context.SaveChangesAsync();
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: SaveSelectedManagerList", "WEB/API");
                return null;
            }
        }

        [Route("SaveEditableManagerData")]
        [HttpPost]
        public async Task<IActionResult> SaveEditableManagerData(SaveManagerModel _SaveManagerModel)
        {
            try
            {
                var getdata = await _context.ManagerList.OrderByDescending(x => x.Id).Where(m => m.DeptId == _SaveManagerModel.DepId && m.IsActive == false).ToListAsync();
                if (getdata.Count > 0)
                {
                    _context.ManagerList.RemoveRange(getdata);

                    for (int i = 0; i < _SaveManagerModel.ManagerId.Length; i++)
                    {
                        ManagerList obj = new ManagerList();
                        obj.DeptId = _SaveManagerModel.DepId;
                        obj.ManagerId = Convert.ToInt32(_SaveManagerModel.ManagerId[i]);
                        obj.CreatedBy = _SaveManagerModel.CreatedBy;
                        obj.CreatedDate = DateTime.UtcNow;
                        obj.IsActive = true;
                        _context.ManagerList.Add(obj);
                        await _context.SaveChangesAsync();
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: SaveSelectedManagerList", "WEB/API");
                return null;
            }
        }

        [Route("GetSelManagerList")]
        [HttpPost]
        public async Task<IActionResult> GetSelManagerList(DepartmentEmployeeModel model)
        {
            try
            {
                //  var data = await _context.LeadNotification.Where(m => m.LeadId == _leadGoalNotificationbyID.id && m.IsRead==false).ToListAsync();
                var data = await _context.ManagerList.OrderByDescending(x => x.Id).Where(m => m.DeptId == model.Depid && m.IsActive == true).ToListAsync();
                //var data1 = data.Select(m => m.ManagerId).ToList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetSelectedManagerList")]
        [HttpPost]
        public async Task<IActionResult> GetSelectedManagerList(DepartmentEmployeeModel model)
        {
            try
            {
                List<SelectedManagerDetails> deptList = await _context.Set<SelectedManagerDetails>().FromSql("dbo.Emp_GetAllEmployeewithmanagerByDepartment @dept = {0}", model.Depid).ToListAsync();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("GetAllEmployee")]
        [HttpPost]
        public async Task<IActionResult> GetAllEmployeeList(DepartmentAssignEmployeeModel model)
        {
            try
            {
                List<SelectedManagerDetails> deptList = await _context.Set<SelectedManagerDetails>().FromSql("dbo.Emp_GetAllEmployeeByDepartment @dept = {0}, @managerid = {1}", model.Depid, model.MangerId).ToListAsync();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: GetAllEmployeeList", "WEB/API");
                return null;
            }
        }

        [Route("SaveSelectedEmployees")]
        [HttpPost]
        public async Task<IActionResult> SaveSelectedEmployeeList(SaveEmployeeModel _SaveEmployeeModel)
        {
            try
            {
                var getdata = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveEmployeeModel.DepId && m.ManagerId == _SaveEmployeeModel.ManagerId).ToListAsync();
                if (getdata.Count > 0)
                {
                    _context.EmployeeManagerList.RemoveRange(getdata);
                }
                for (int i = 0; i < _SaveEmployeeModel.EmployeeId.Length; i++)
                {
                    EmployeeManagerList obj = new EmployeeManagerList();
                    obj.DeptId = _SaveEmployeeModel.DepId;
                    obj.ManagerId = _SaveEmployeeModel.ManagerId;
                    obj.EmployeeId = Convert.ToInt32(_SaveEmployeeModel.EmployeeId[i]);
                    obj.CreatedBy = _SaveEmployeeModel.CreatedBy;
                    obj.CreatedDate = DateTime.UtcNow;
                    obj.Isactive = true;
                    _context.EmployeeManagerList.Add(obj);
                    await _context.SaveChangesAsync();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: SaveSelectedEmployeeList", "WEB/API");
                return null;
            }
        }

        [Route("RemovemanagerById")]
        [HttpPost]
        public async Task<IActionResult> RemoveById(ManagerModel model)
        {
            try
            {
                //var data = await _context.ManagerList.Where(m => m.ManagerId == model.MangerId && m.IsActive == true && m.SubManager == false).FirstOrDefaultAsync();
                var data = await _context.ManagerList.Where(m => m.ManagerId == model.MangerId && m.IsActive == true).FirstOrDefaultAsync();
                if (data != null)
                {
                    _context.ManagerList.Remove(data);
                    var deleteEmployee = await _context.EmployeeManagerList.Where(m => m.ManagerId == model.MangerId && m.Isactive == true).ToListAsync();
                    var subManagerId = _context.EmployeeManagerList.Where(m => m.ManagerId == model.MangerId && m.Isactive == true).Select(x => x.EmployeeId).ToList();
                    var subManager = await _context.ManagerList.Where(x => subManagerId.Contains(x.ManagerId)).ToListAsync();

                    var employeeId = _context.EmployeeManagerList.Where(m => subManagerId.Contains(m.ManagerId) && m.Isactive == true).Select(x => x.EmployeeId).ToList();
                    var goalsettingform = await _context.TblEmployeeGoalSettingForm.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalsettingform1 = await _context.TblEmployeeGoalSettingForm.Where
                        (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalform = await _context.TblEmployeeGoal.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalform1 = await _context.TblEmployeeGoal.Where
                        (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalOther = await _context.TblEmployeeGoalOther.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalOther1 = await _context.TblEmployeeGoalOther.Where
                       (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalbehaviour = await _context.TblEmployeeBehaviouralGoal.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalbehaviour1 = await _context.TblEmployeeBehaviouralGoal.Where
                       (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();

                    if (deleteEmployee.Count > 0)
                    {
                        _context.TblEmployeeGoalSettingForm.RemoveRange(goalsettingform);
                        _context.TblEmployeeGoalSettingForm.RemoveRange(goalsettingform1);
                        _context.TblEmployeeGoal.RemoveRange(goalform);
                        _context.TblEmployeeGoal.RemoveRange(goalform1);
                        _context.TblEmployeeGoalOther.RemoveRange(goalOther);
                        _context.TblEmployeeGoalOther.RemoveRange(goalOther1);
                        _context.TblEmployeeBehaviouralGoal.RemoveRange(goalbehaviour);
                        _context.TblEmployeeBehaviouralGoal.RemoveRange(goalbehaviour1);
                        _context.ManagerList.RemoveRange(subManager);
                        _context.EmployeeManagerList.RemoveRange(deleteEmployee);
                    }
                    _context.SaveChanges();
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetAllManagerFromAllDeptList")]
        [HttpGet]
        public async Task<IActionResult> GetAllManagerFromAllDeptList()
        {
            try
            {
                var data = await (from ManagerList ML in _context.ManagerList
                                  join E in _context.Employee on ML.ManagerId equals E.Id
                                  join D in _context.TblEDepartment on ML.DeptId equals D.Id
                                  select new AllSelectedManagerDetails
                                  {

                                      ID = E.Id,
                                      ManagerId = (int)ML.ManagerId,
                                      FullName = E.FullName,
                                      Department = D.DeptName,
                                      DepartmentId = ML.DeptId == null ? 0 : Convert.ToInt32(ML.DeptId)
                                  }).ToListAsync();




                // var AllManagerList1 = await _context.ManagerList.Where(m => m.IsActive == true).ToListAsync();
                //var AllManagerList =
                // List < SelectedManagerDetails > deptList = await _context.Set<SelectedManagerDetails>().FromSql("dbo.Emp_GetAllEmployeewithmanagerByDepartment").ToListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: AllEmployees", "WEB/API");
                return null;
            }
        }

        [Route("GetEmployeeListAssignToManager")]
        [HttpPost]
        public async Task<IActionResult> EmployeeListAssignToManager(DepartmentWiseAssignEmployeeModel model)
        {
            try
            {
                List<AssignEmployeeModel> _AssignEmployeeList = await _context.Set<AssignEmployeeModel>().FromSql("[dbo].[EmployeeListAssignToManager] @Depid={0},@ManagerId={1}, @Cycle = {2},@Year ={3}", model.Depid, model.ManagerId, model.Cycle, model.Year).ToListAsync();
                return Ok(_AssignEmployeeList);

            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: GetAllEmployeeList", "WEB/API");
                return null;
            }
        }

        [Route("GetSubManagerForAppraisal")]
        [HttpGet]
        public IActionResult GetSubManagerForAppraisal()
        {
            try
            {
                var managerList = _context.ManagerList.AsNoTracking().Select(x => x.ManagerId).ToList();
                var submanagerList = _context.ManagerList.Where(x => x.SubManager == false).Select(x => x.ManagerId).ToList();
                List<TeamManagementModel> teamList = _context.ManagerList.Where(x => x.SubManager == true).Select(z => new TeamManagementModel
                {
                    Id = z.Id,
                    DepartmentName = _context.TblEDepartment.Where(x => x.Id == z.DeptId).Select(x => x.DeptName).FirstOrDefault(),
                    DepartmentId = Convert.ToInt32(z.DeptId),
                    ManagerName = _context.Employee.Where(x => x.Id == z.ManagerId).Select(x => x.FullName).FirstOrDefault(),
                    ManagerId = Convert.ToInt32(z.ManagerId),
                    EmployeeCount = _context.EmployeeManagerList.Where(x => x.DeptId == z.DeptId && x.ManagerId == z.ManagerId).Select(x => x.EmployeeId).Count(),
                    TotalEmployeeCount = _context.Employee.Where(x => x.FkDepartment == z.DeptId && x.EmpStatus == "Active" && !(submanagerList.Contains(x.Id))).Count()
                }).ToList();
                return Ok(teamList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: GetSubManagerForAppraisal", "WEB/API");
                return null;
            }
        }

        [Route("GetSelectedSubManagerList")]
        [HttpPost]
        public async Task<IActionResult> GetSelectedSubManagerList(DepartmentEmployeeModel model)
        {
            try
            {
                List<SelectedManagerDetails> deptList = await _context.Set<SelectedManagerDetails>().FromSql("dbo.Emp_GetAllEmployeewithSubmanagerByDepartment @dept = {0}, @managerid = {1}", model.Depid, model.MangerId).ToListAsync();
                return Ok(deptList);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: GetSelectedSubManagerList", "WEB/API");
                return null;
            }
        }

        [Route("SaveSelectedSubManager")]
        [HttpPost]
        public async Task<IActionResult> SaveSelectedSubManager(SaveSubManagerModel _SaveManagerModel)
        {
            try
            {
                var getdata = await _context.ManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.SubManager == true && m.ManagerId == _SaveManagerModel.ManagerId && !_SaveManagerModel.SubManagerId.Contains(Convert.ToString(m.ManagerId))).ToListAsync();
                var getManagerData = await _context.ManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.SubManager == true && _SaveManagerModel.SubManagerId.Contains(Convert.ToString(m.ManagerId))).Select(x => x.ManagerId).ToListAsync();
                var assignEmployeeData = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.ManagerId == _SaveManagerModel.ManagerId && !_SaveManagerModel.SubManagerId.Contains(Convert.ToString(m.EmployeeId))).ToListAsync();
                var managerId = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.ManagerId == _SaveManagerModel.ManagerId && !_SaveManagerModel.SubManagerId.Contains(Convert.ToString(m.EmployeeId))).Select(m => m.EmployeeId).ToListAsync();
                var managerList = await _context.ManagerList.Where(m => m.IsActive == true && managerId.Contains(m.ManagerId)).ToListAsync();
                if (getdata.Count > 0)
                {
                    _context.ManagerList.RemoveRange(getdata); // Remove unassigned manager
                    foreach (var data in getdata)
                    {
                        var employeedata = await _context.EmployeeManagerList.Where(m => m.DeptId == _SaveManagerModel.DepId && m.ManagerId == data.ManagerId).ToListAsync();
                        if (employeedata.Count > 0)
                        {
                            _context.EmployeeManagerList.RemoveRange(employeedata); // Remove assigned Employee
                        }
                    }
                }
                if (assignEmployeeData.Count > 0)
                {
                    _context.ManagerList.RemoveRange(managerList);
                    _context.EmployeeManagerList.RemoveRange(assignEmployeeData); // Removing employee from Assigned employee table before assigning it as manger
                }
                await _context.SaveChangesAsync();
                for (int i = 0; i < _SaveManagerModel.SubManagerId.Length; i++)
                {
                    if (!getManagerData.Contains(Convert.ToInt32(_SaveManagerModel.SubManagerId[i])))
                    {
                        ManagerList obj = new ManagerList();
                        obj.DeptId = _SaveManagerModel.DepId;
                        obj.ManagerId = Convert.ToInt32(_SaveManagerModel.SubManagerId[i]);
                        obj.CreatedBy = _SaveManagerModel.CreatedBy;
                        obj.CreatedDate = DateTime.UtcNow;
                        obj.IsActive = true;
                        obj.SubManager = true;
                        _context.ManagerList.Add(obj);
                        await _context.SaveChangesAsync();

                        EmployeeManagerList objEmp = new EmployeeManagerList();
                        objEmp.DeptId = _SaveManagerModel.DepId;
                        objEmp.ManagerId = _SaveManagerModel.ManagerId;
                        objEmp.EmployeeId = Convert.ToInt32(_SaveManagerModel.SubManagerId[i]);
                        objEmp.CreatedBy = _SaveManagerModel.CreatedBy;
                        objEmp.CreatedDate = DateTime.UtcNow;
                        objEmp.Isactive = true;
                        _context.EmployeeManagerList.Add(objEmp);
                        await _context.SaveChangesAsync();
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: SaveSelectedManagerList", "WEB/API");
                return null;
            }
        }

        [Route("RemoveSubManagerById")]
        [HttpPost]
        public async Task<IActionResult> RemoveSubManagerById(ManagerModel model)
        {
            try
            {
                var data = await _context.ManagerList.Where(m => m.ManagerId == model.MangerId && m.IsActive == true && m.SubManager == true).FirstOrDefaultAsync();
                if (data != null)
                {
                    _context.ManagerList.Remove(data);
                    var deleteEmployee = await _context.EmployeeManagerList.Where(m => m.ManagerId == model.MangerId && m.Isactive == true).ToListAsync();

                    var subManagerId = _context.EmployeeManagerList.Where(m => m.ManagerId == model.MangerId && m.Isactive == true).Select(x => x.EmployeeId).ToList();
                    var subManager = await _context.ManagerList.Where(x => subManagerId.Contains(x.ManagerId)).ToListAsync();
                    var employeeId = _context.EmployeeManagerList.Where(m => subManagerId.Contains(m.ManagerId) && m.Isactive == true).Select(x => x.EmployeeId).ToList();
                    var goalsettingform = await _context.TblEmployeeGoalSettingForm.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalsettingform1 = await _context.TblEmployeeGoalSettingForm.Where
                        (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalform = await _context.TblEmployeeGoal.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalform1 = await _context.TblEmployeeGoal.Where
                        (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalOther = await _context.TblEmployeeGoalOther.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalOther1 = await _context.TblEmployeeGoalOther.Where
                       (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalbehaviour = await _context.TblEmployeeBehaviouralGoal.Where
                        (x => subManagerId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    var goalbehaviour1 = await _context.TblEmployeeBehaviouralGoal.Where
                       (x => employeeId.Contains(x.EmployeeId) && x.Year == model.Year && x.Cycle == model.Cycle).ToListAsync();
                    if (deleteEmployee.Count > 0)
                    {
                        _context.TblEmployeeGoalSettingForm.RemoveRange(goalsettingform);
                        _context.TblEmployeeGoalSettingForm.RemoveRange(goalsettingform1);
                        _context.TblEmployeeGoal.RemoveRange(goalform);
                        _context.TblEmployeeGoal.RemoveRange(goalform1);
                        _context.TblEmployeeGoalOther.RemoveRange(goalOther);
                        _context.TblEmployeeGoalOther.RemoveRange(goalOther1);
                        _context.TblEmployeeBehaviouralGoal.RemoveRange(goalbehaviour);
                        _context.TblEmployeeBehaviouralGoal.RemoveRange(goalbehaviour1);
                        _context.ManagerList.RemoveRange(subManager);

                        _context.EmployeeManagerList.RemoveRange(deleteEmployee);
                    }
                    _context.SaveChanges();
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("EmployeeList")]
        [HttpGet]
        public IActionResult EmployeeList()
        {
            try
            {
                List<EmployeeEmailListModel> employeeEmailLists = (from e in _context.Employee
                                                                   join el in _context.EmployeeEmailList on e.EmpCode equals el.EmpCode into Details
                                                                   where e.EmpStatus == "Active" && e.Id != 122
                                                                   from m in Details.DefaultIfEmpty()
                                                                   select new EmployeeEmailListModel
                                                                   {
                                                                       Name = e.FullName,
                                                                       EmpCode = e.EmpCode,
                                                                       OfficialEmail1 = e.OfficialEmail,
                                                                       OfficialEmail2 = m != null ? m.OfficialEmail2 : ""
                                                                   }).ToList();
                return Ok(employeeEmailLists);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("EmployeeEmailEdit")]
        [HttpPost]
        public async Task<IActionResult> EmployeeEmailEdit(EmployeeEmailListModel employeeEmailListModel)
        {
            try
            {
                var email = await _context.EmployeeEmailList.Where(x => x.EmpCode == employeeEmailListModel.EmpCode).ToListAsync();
                if (email.Count > 0)
                {
                    _context.EmployeeEmailList.RemoveRange(email);
                }
                await _context.SaveChangesAsync();
                var newEmail = new EmployeeEmailList
                {
                    Name = employeeEmailListModel.Name,
                    EmpCode = employeeEmailListModel.EmpCode,
                    OfficialEmail1 = employeeEmailListModel.OfficialEmail1,
                    OfficialEmail2 = employeeEmailListModel.OfficialEmail2,
                    IsActive = true
                };
                await _context.EmployeeEmailList.AddAsync(newEmail);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: APIAppraisalController, methodName: EmployeeEmailEdit", "WEB/API");
                return null;
            }
        }

        private bool Checkholidaystatusbydate(DateTime applieddate)
        {
            int result;
            result = _context.TblECalendarHoliday.Where(x => x.IsDeleted == false && x.OccasionDate == applieddate.Date && x.IsPublished == true).Count();
            if (result == 1)
                return true;
            else
                return false;
        }

        private DateTime GetDate(int count)
        {
            int flag = count;
            DateTime result = DateTime.Now.Date;
            DateTime dateTime = DateTime.Now.AddDays(flag).Date;
            while (count != -1)
            {
                if (Checkholidaystatusbydate(result) == true || result.DayOfWeek.ToString().ToLower() == "saturday" || result.DayOfWeek.ToString().ToLower() == "sunday")
                {
                    flag++;
                    result = result.AddDays(1).Date;
                    dateTime = DateTime.Now.AddDays(flag).Date;
                }
                else
                {
                    result = result.AddDays(1).Date;
                    count--;
                }
            }
            return dateTime;
        }

        [Route("SaveManagementFeedbackAndComment")]
        [HttpPost]
        public async Task<IActionResult> SaveManagementFeedbackAndComment(ManagmentFeedbackComments _ManagmentFeedbackComments)
        {
            try
            {
                int EmpId = _ManagmentFeedbackComments.id;
                var Checkemployeegoaldataexists = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == EmpId && m.IsActive == true && m.Year == _ManagmentFeedbackComments.year && m.Cycle == _ManagmentFeedbackComments.cycle).ToListAsync();
                if (Checkemployeegoaldataexists != null)
                {
                    int pid = _ManagmentFeedbackComments.pid;
                    var employeegoaldata = _context.TblEmployeeGoalOther.Where(m => m.Id == pid && m.Year == _ManagmentFeedbackComments.year && m.Cycle == _ManagmentFeedbackComments.cycle).FirstOrDefault();
                    if (employeegoaldata != null)
                    {
                        employeegoaldata.ManagementFeedback = _ManagmentFeedbackComments.Managmentrating;
                        employeegoaldata.ManagementFeedbackcomment = _ManagmentFeedbackComments.Managmentcomment;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                if (_ManagmentFeedbackComments.semiedit == 0)
                {
                    var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == EmpId && m.Year == _ManagmentFeedbackComments.year && m.Cycle == _ManagmentFeedbackComments.cycle).FirstOrDefault();
                    if (employeedata != null)
                    {
                        employeedata.ManagementFeedbackStatus = 3;
                        employeedata.EvaluationEndDate = DateTime.Now;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return Ok(true);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [Route("SaveProjectManagerFeedbackAndComment")]
        [HttpPost]
        public async Task<IActionResult> SaveProjectManagerFeedbackAndComment(ProjectManagerFeedbackComments _projectManagerFeedbackComments)
        {
            try
            {
                int EmpId = _projectManagerFeedbackComments.id;
                var Checkemployeegoaldataexists = await _context.TblEmployeeGoal.Where(m => m.EmployeeId == EmpId && m.IsActive == true && m.Year == _projectManagerFeedbackComments.year && m.Cycle == _projectManagerFeedbackComments.cycle).ToListAsync();
                if (Checkemployeegoaldataexists != null)
                {
                    int pid = _projectManagerFeedbackComments.pid;
                    var employeegoaldata = _context.TblEmployeeGoalOther.Where(m => m.Id == pid && m.Year == _projectManagerFeedbackComments.year && m.Cycle == _projectManagerFeedbackComments.cycle).FirstOrDefault();
                    if (employeegoaldata != null)
                    {
                        employeegoaldata.SummarizeOverallPerformanceManager = _projectManagerFeedbackComments.SummarizeOverallPerformanceManager;
                        employeegoaldata.ActionPlanImprovementManager = _projectManagerFeedbackComments.ActionPlanImprovementManager;
                        employeegoaldata.AreasImprovementManager = _projectManagerFeedbackComments.AreasImprovementManager;
                        employeegoaldata.OverallRatingManager = _projectManagerFeedbackComments.ProjectManagerrating;
                        employeegoaldata.ProjectManagerFeedbackcomment = _projectManagerFeedbackComments.ProjectManagercomment;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                if (_projectManagerFeedbackComments.semiedit == 0)
                {
                    var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == EmpId && m.Year == _projectManagerFeedbackComments.year && m.Cycle == _projectManagerFeedbackComments.cycle).FirstOrDefault();
                    if (employeedata != null)
                    {
                        employeedata.ProjectManagerAssesmentStatus = 3;
                        employeedata.HrassesmentStatus = 2;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return NotFound();
                    }
                    var managerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == _projectManagerFeedbackComments.id && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    var manager = _context.ManagerList.Where(x => x.ManagerId == managerId && x.IsActive == true && x.SubManager == false).Select(x => x.ManagerId).FirstOrDefault();
                    var employeeId = _context.ManagerList.Where(x => x.ManagerId == managerId && x.IsActive == true && x.SubManager == true).Select(x => x.ManagerId).FirstOrDefault();
                    if (manager == null)
                    {
                        managerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    }
                    // Email Notification Code
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = employeedata.CreatedBy,
                        EventId = (int)NotificationType.EventType.ManagerAssesmentEnd,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = _projectManagerFeedbackComments.id,
                        ManagerId = managerId
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();
                }

                return Ok(true);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [Route("GetRcInfoById")]
        [HttpPost]
        public async Task<IActionResult> GetRcInfo(EmployeeGoalEMPModel _EmployeeGoalEMPModel)
        {
            try
            {
                RatingDetail ratingDetail = new RatingDetail();
                List<GoalRCList> _listrating = new List<GoalRCList>();
                SummaryList _listSummary = new SummaryList();
                List<BehaviourRatingList> _listBehaviour = new List<BehaviourRatingList>();
                _listrating = await (from TblEmployeeGoal E in _context.TblEmployeeGoal.AsNoTracking()
                                     where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                     select new GoalRCList
                                     {
                                         ID = E.Id,
                                         GoalCategoryId = E.MasterGoalCategoryId,
                                         GoalDescription = E.Description,
                                         Target = E.Target,
                                         Ratings = E.RatingSelf,
                                         Comments = E.CommentSelf,
                                         RatingManager = E.RatingManager,
                                         CommentManager = E.CommentManager
                                     }).ToListAsync();

                _listSummary = await (from TblEmployeeGoalOther E in _context.TblEmployeeGoalOther.AsNoTracking()
                                      where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                      select new SummaryList
                                      {
                                          ID = E.Id,
                                          Ambitions = E.AmbitionsJobExpectations,
                                          Summarize = E.SummarizeOverallPerformanceSelf,
                                          AreaImproveSelf = E.AreasImprovementSelf,
                                          ActionPlanImproveSelf = E.ActionPlanImprovementSelf,
                                          ActionPlanImprovementManager = E.ActionPlanImprovementManager,
                                          AreasImprovementManager = E.AreasImprovementManager,
                                          SummarizeOverallPerformanceManager = E.SummarizeOverallPerformanceManager,
                                          OverallRatingManager = E.OverallRatingManager,
                                          OverallRatingManagercomment = E.ProjectManagerFeedbackcomment,
                                          Hrfeedback = E.Hrfeedback,
                                          Hrfeedbackcomment = E.Hrfeedbackcomment,
                                          ManagementFeedback = E.ManagementFeedback,
                                          ManagementFeedbackcomment = E.ManagementFeedbackcomment
                                      }).FirstOrDefaultAsync();

                _listBehaviour = await (from TblEmployeeBehaviouralGoal E in _context.TblEmployeeBehaviouralGoal.AsNoTracking()
                                        where E.EmployeeId == _EmployeeGoalEMPModel.id && E.IsActive == true && E.Year == _EmployeeGoalEMPModel.year && E.Cycle == _EmployeeGoalEMPModel.cycle
                                        select new BehaviourRatingList
                                        {
                                            ID = E.Id,
                                            ManagerRating = E.RatingManagerEvaluation,
                                            ManagerComments = E.CommentManagerEvaluation,
                                            BehaviourGoalId = E.FkbehaviouralGoalsMasterId
                                        }).ToListAsync();
                ratingDetail.Emp_Id = _EmployeeGoalEMPModel.id;
                ratingDetail.GoalRCList = _listrating;
                ratingDetail.SummaryList = _listSummary;
                ratingDetail.BehaviourRatingList = _listBehaviour;
                return Ok(ratingDetail);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [Route("GetAssesmentStatus")]
        [HttpPost]
        public async Task<IActionResult> GetAssesmentStatus(EmployeeGoalEMPModel _employeeGoalEMPModel)
        {
            var assesmentStatus = await _context.TblEmployeeGoalSettingForm.Where(x => x.EmployeeId == _employeeGoalEMPModel.id && x.Cycle == _employeeGoalEMPModel.cycle &&
                                             x.Year == _employeeGoalEMPModel.year).Select(x => new AssesmentStatus
                                             {
                                                 Emp_Id = _employeeGoalEMPModel.id,
                                                 HRInitiateFormStatus = (int)x.HrinitiateFormStatus,
                                                 GoalSettingByLeadStatus = (int)x.GoalsettingByLeadStatus,
                                                 SelfAssesmentStatus = (int)x.SelfAssesmentStatus,
                                                 LeadAssesmentStatus = (int)x.LeadAssesmentStatus,
                                                 ProjectManagerAssesmentStatsu = (int)x.ProjectManagerAssesmentStatus,
                                                 HRAssesmentStatus = (int)x.HrassesmentStatus,
                                                 ManagementFeedbackStatus = (int)x.ManagementFeedbackStatus
                                             }).FirstOrDefaultAsync();
            return Ok(assesmentStatus);
        }

        [Route("EditFormByHR")]
        [HttpPost]
        public async Task<IActionResult> EditFormByHR(EditFormHR editFormHR)
        {
            try
            {
                var goalUpdate = await _context.TblEmployeeGoal.Where(x => x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).ToListAsync();
                if (goalUpdate != null)
                {
                    foreach (var goal in editFormHR.ManagerRatingAndComments)
                    {
                        var updateData = await _context.TblEmployeeGoal.Where(x => x.Id == goal.Pid && x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).FirstOrDefaultAsync();
                        if (updateData != null)
                        {
                            updateData.RatingManager = goal.Ratings;
                            updateData.CommentManager = goal.Comments;
                            if (editFormHR.semiedit == 0)
                                updateData.ManagerHasSubmitted = true;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                var behaviourgoalUpdate = await _context.TblEmployeeBehaviouralGoal.Where(x => x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).ToListAsync();
                if (behaviourgoalUpdate != null)
                {
                    foreach (var behavioural in editFormHR.BehaviouralRatingAndComments)
                    {
                        var updateData = await _context.TblEmployeeBehaviouralGoal.Where(x => x.Id == behavioural.Pid && x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).FirstOrDefaultAsync();
                        if (updateData != null)
                        {
                            updateData.RatingManagerEvaluation = behavioural.Ratings;
                            updateData.CommentManagerEvaluation = behavioural.Comments;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                var summarygoalUpdate = await _context.TblEmployeeGoalOther.Where(x => x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).ToListAsync();
                if (summarygoalUpdate != null)
                {
                    foreach (var summary in editFormHR.SummaryClosure)
                    {
                        var updateData = await _context.TblEmployeeGoalOther.Where(x => x.Id == summary.Id && x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).FirstOrDefaultAsync();
                        if (updateData != null)
                        {
                            updateData.SummarizeOverallPerformanceManager = summary.SummarizeOverallPerformanceManager;
                            updateData.AreasImprovementManager = summary.AreaofImprovementManager;
                            updateData.ActionPlanImprovementManager = summary.ActionPlanImprovementManager;
                            updateData.OverallRatingManager = summary.ProjectManagerrating;
                            updateData.ProjectManagerFeedbackcomment = summary.ProjectManagercomment;
                            updateData.Hrfeedback = summary.HRrating;
                            updateData.Hrfeedbackcomment = summary.HRComment;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                if (editFormHR.semiedit == 0)
                {
                    var status = await _context.TblEmployeeGoalSettingForm.Where(x => x.EmployeeId == editFormHR.Emp_Id && x.Year == editFormHR.Year && x.Cycle == editFormHR.Cycle).FirstOrDefaultAsync();
                    status.HrassesmentStatus = 3;
                    status.ManagementFeedbackStatus = 2;
                    await _context.SaveChangesAsync();
                    // Email Notification Code
                    var EmailQueue = new AmsemailQueue()
                    {
                        EmployeeId = status.ManagementId,
                        EventId = (int)NotificationType.EventType.ManagementFeedback,
                        PendingDate = DateTime.Now.Date,
                        CreatedDate = DateTime.Now.Date,
                        IsEmailSent = false,
                        IsRead = false,
                        IsActive = true,
                        EmailType = (int)NotificationType.EventType.IntimationEmail,
                        FkEmployeeId = status.EmployeeId,
                        ManagerId = status.ManagementId
                    };
                    _context.AmsemailQueue.Add(EmailQueue);
                    await _context.SaveChangesAsync();
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [Route("ReplaceManager")]
        [HttpPost]
        public async Task<ActionResult> ReplaceManger(ReplaceManagerModel managerModel)
        {
            var oldManagerId = await _context.ManagerList.Where(x => x.ManagerId == managerModel.OldManagerId && x.IsActive == true && x.SubManager == false).FirstOrDefaultAsync();
            if (oldManagerId != null)
            {
                var ManagerId = await _context.ManagerList.Where(x => x.ManagerId == managerModel.NewManagerId && x.IsActive == true && x.SubManager == true).FirstOrDefaultAsync();
                if (ManagerId == null)
                {
                    oldManagerId.ManagerId = managerModel.NewManagerId;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ManagerId.SubManager = false;
                    _context.Remove(oldManagerId);
                    await _context.SaveChangesAsync();
                }
                var employeelist = await _context.EmployeeManagerList.Where(x => x.ManagerId == managerModel.OldManagerId && x.Isactive == true).ToListAsync();
                var employee = await _context.EmployeeManagerList.Where(x => x.EmployeeId == managerModel.NewManagerId && x.Isactive == true).FirstOrDefaultAsync();
                if (employee != null)
                {
                    _context.Remove(employee);
                    await _context.SaveChangesAsync();
                }
                if (employeelist != null)
                {
                    employeelist.ForEach(x => x.ManagerId = managerModel.NewManagerId);
                    _context.SaveChanges();
                }
                var employee1 = await _context.TblEmployeeGoalSettingForm.Where(x => x.ManagerId == managerModel.OldManagerId && x.IsActive == true).ToListAsync();
                if (employee1 != null)
                {
                    employee1.ForEach(x => x.ManagerId = managerModel.NewManagerId);
                    await _context.SaveChangesAsync();
                }
            }
            return Ok(true);
        }

        [Route("ReplaceSubManager")]
        [HttpPost]
        public async Task<ActionResult> ReplaceSubManger(ReplaceSubManagerModel replaceSubManagerModel)
        {
            var oldManagerId = await _context.ManagerList.Where(x => x.ManagerId == replaceSubManagerModel.OldSubManagerId && x.IsActive == true && x.SubManager == true).FirstOrDefaultAsync();
            if (oldManagerId != null)
            {
                oldManagerId.ManagerId = replaceSubManagerModel.NewSubManagerId;
                await _context.SaveChangesAsync();

                var employeelist = await _context.EmployeeManagerList.Where(x => x.ManagerId == replaceSubManagerModel.OldSubManagerId && x.Isactive == true).ToListAsync();
                var employee = await _context.EmployeeManagerList.Where(x => x.EmployeeId == replaceSubManagerModel.OldSubManagerId && x.Isactive == true).FirstOrDefaultAsync();
                if (employee != null)
                {
                    var emp = await _context.EmployeeManagerList.Where(x => x.EmployeeId == replaceSubManagerModel.NewSubManagerId && x.Isactive == true).FirstOrDefaultAsync();
                    if (emp != null)
                    {
                        _context.Remove(emp);
                    }
                    employee.EmployeeId = replaceSubManagerModel.NewSubManagerId;
                    await _context.SaveChangesAsync();
                }
                if (employeelist != null)
                {
                    employeelist.ForEach(x => x.ManagerId = replaceSubManagerModel.NewSubManagerId);
                    await _context.SaveChangesAsync();
                }
            }
            return Ok(true);
        }

        [Route("GetDeptEmp")]
        [HttpGet]
        public async Task<ActionResult> GetDeptEmp(int deptId, int managerId)
        {
            var empList = await _context.Employee.Where(x => x.FkDepartment == deptId && x.Id != managerId && x.EmpStatus == "Active").Select(x => new { x.Id, x.FullName }).ToListAsync();
            return Ok(empList);
        }

        [Route("RejectEmployeeGoal")]
        [HttpPost]
        public async Task<IActionResult> RejectEmployeeGoal(RejectReasonComments rejectReason)
        {
            int id = rejectReason.id;
            var employeedata = _context.TblEmployeeGoalSettingForm.Where(m => m.EmployeeId == id && m.Year == rejectReason.year && m.Cycle == rejectReason.cycle).FirstOrDefault();
            if (employeedata != null)
            {
                AmsemailQueue queue = new AmsemailQueue();
                // HR notification for form Rejection
                if (employeedata.HrassesmentStatus == 3)
                {
                    employeedata.HrassesmentStatus = 2;
                    await _context.SaveChangesAsync();
                    queue.EmployeeId = (int)employeedata.CreatedBy;
                    queue.EventId = (int)NotificationType.EventType.FormRejectionHR;
                    queue.PendingDate = GetDate(1);//DateTime.Now.Date.AddDays(1),
                    queue.CreatedDate = DateTime.Now.Date;
                    queue.IsEmailSent = false;
                    queue.IsRead = false;
                    queue.IsActive = true;
                    queue.EmailType = (int)NotificationType.EventType.IntimationEmail;
                    queue.FkEmployeeId = employeedata.EmployeeId;
                    queue.ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    queue.ReasonforReject = rejectReason.reason;
                    _context.AmsemailQueue.Add(queue);
                    await _context.SaveChangesAsync();
                }
                else if (employeedata.ProjectManagerAssesmentStatus == 3)
                {
                    employeedata.ProjectManagerAssesmentStatus = 2;
                    await _context.SaveChangesAsync();
                    var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId).Select(x => x.ManagerId).FirstOrDefault();
                    var ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == SubManagerId).Select(x => x.ManagerId).FirstOrDefault();
                    queue.EmployeeId = (int)ManagerId;
                    queue.EventId = (int)NotificationType.EventType.FormRejectionManager;
                    queue.PendingDate = GetDate(1);//DateTime.Now.Date.AddDays(1),
                    queue.CreatedDate = DateTime.Now.Date;
                    queue.IsEmailSent = false;
                    queue.IsRead = false;
                    queue.IsActive = true;
                    queue.EmailType = (int)NotificationType.EventType.IntimationEmail;
                    queue.FkEmployeeId = employeedata.EmployeeId;
                    queue.ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    queue.ReasonforReject = rejectReason.reason;
                    _context.AmsemailQueue.Add(queue);
                    await _context.SaveChangesAsync();
                }
                else if (employeedata.LeadAssesmentStatus == 3)
                {
                    employeedata.LeadAssesmentStatus = 2;
                    await _context.SaveChangesAsync();
                    var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId).Select(x => x.ManagerId).FirstOrDefault();
                    queue.EmployeeId = (int)SubManagerId;
                    queue.EventId = (int)NotificationType.EventType.FormRejectionLead;
                    queue.PendingDate = GetDate(1);//DateTime.Now.Date.AddDays(1),
                    queue.CreatedDate = DateTime.Now.Date;
                    queue.IsEmailSent = false;
                    queue.IsRead = false;
                    queue.IsActive = true;
                    queue.EmailType = (int)NotificationType.EventType.IntimationEmail;
                    queue.FkEmployeeId = employeedata.EmployeeId;
                    queue.ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    queue.ReasonforReject = rejectReason.reason;
                    _context.AmsemailQueue.Add(queue);
                    await _context.SaveChangesAsync();
                }
                else if (employeedata.SelfAssesmentStatus == 3)
                {
                    employeedata.SelfAssesmentStatus = 2;
                    await _context.SaveChangesAsync();
                    var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId).Select(x => x.ManagerId).FirstOrDefault();
                    queue.EmployeeId = (int)SubManagerId;
                    queue.EventId = (int)NotificationType.EventType.FormRejectionEmployee;
                    queue.PendingDate = GetDate(1);//DateTime.Now.Date.AddDays(1),
                    queue.CreatedDate = DateTime.Now.Date;
                    queue.IsEmailSent = false;
                    queue.IsRead = false;
                    queue.IsActive = true;
                    queue.EmailType = (int)NotificationType.EventType.IntimationEmail;
                    queue.FkEmployeeId = employeedata.EmployeeId;
                    queue.ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    queue.ReasonforReject = rejectReason.reason;
                    _context.AmsemailQueue.Add(queue);
                    await _context.SaveChangesAsync();
                }
                else if (employeedata.GoalsettingByLeadStatus == 3)
                {
                    employeedata.GoalsettingByLeadStatus = 2;
                    await _context.SaveChangesAsync();
                    var SubManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId).Select(x => x.ManagerId).FirstOrDefault();
                    queue.EmployeeId = (int)SubManagerId;
                    queue.EventId = (int)NotificationType.EventType.FormRejectionGoal;
                    queue.PendingDate = GetDate(1);//DateTime.Now.Date.AddDays(1),
                    queue.CreatedDate = DateTime.Now.Date;
                    queue.IsEmailSent = false;
                    queue.IsRead = false;
                    queue.IsActive = true;
                    queue.EmailType = (int)NotificationType.EventType.IntimationEmail;
                    queue.FkEmployeeId = employeedata.EmployeeId;
                    queue.ManagerId = _context.EmployeeManagerList.Where(x => x.EmployeeId == employeedata.EmployeeId && x.Isactive == true).Select(x => x.ManagerId).FirstOrDefault();
                    queue.ReasonforReject = rejectReason.reason;
                    _context.AmsemailQueue.Add(queue);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return NotFound();
            }
            return Ok(true);
        }

        //[Route("RejectEmployeeGoal")]
        //[HttpGet]
        //public async Task<IActionResult> GetAllForms(AllEmployeeForms employeeForms)
        //{
        //    var allforms = await _context.TblEmployeeGoalSettingForm.ToListAsync();
        //    if (employeeForms.year != null && employeeForms.cycle == null && employeeForms.department == null)
        //    {
        //        var yearlyForms = await _context.TblEmployeeGoalSettingForm.Where(x => x.Year == employeeForms.year).ToListAsync();
        //        return Ok(yearlyForms);
        //    }
        //    else if (employeeForms.year != null && employeeForms.cycle != null && employeeForms.department == null)
        //    {
        //        var yearlyCycleForms = await _context.TblEmployeeGoalSettingForm.Where(x => x.Year == employeeForms.year && x.Cycle == employeeForms.cycle).ToListAsync();
        //        return Ok(yearlyCycleForms);
        //    }
        //    else if (employeeForms.year != null && employeeForms.cycle != null && employeeForms.department != null)
        //    {
        //        var yearlyCycleForms = await _context.TblEmployeeGoalSettingForm.Where(x => x.Year == employeeForms.year && x.Cycle == employeeForms.cycle).ToListAsync();
        //        return Ok(yearlyCycleForms);
        //    }
        //    return Ok(allforms);
        //}
    }
}