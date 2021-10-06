using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        private Logging _logging;

        public AdminController(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging();
            model = new DashboardViewModel(context);
        }
        public IActionResult Index()
        {
            DepartmentList dept = new DepartmentList();
            var deptList = model.DepartmentList();
            dept = deptList.Where(y => y.DeptName == "MED").FirstOrDefault();
            ViewData["DepartmentsList"] = new SelectList(deptList, "ID", "DeptName", dept.ID);

            //dept = deptList.Where(x => x.Text == "MED").FirstOrDefault().Selected(); (x => new DepartmentList
            //{ DeptName = x.Text,
            //   ID = Convert.ToInt32(x.Value)
            //});
            //.Select(x => new SelectListItem
            //{
            //    Value = x.ID.ToString(),
            //    Text = x.DeptName
            //})
            return View();
        }

        public async Task<IActionResult> EmployeeList()
        {
            var list = await model.AllEmployees();
            return View(list);
        }
        public async Task<IActionResult> EmployeeDetails(int id)
        {
            var employee = await model.profile(id);
            // The below code is used to get the leave details as per leave type, created on 8-feb-2019
            //var leaveTypeData = await model.EmpLeaveTakenAndLeftDetails(id);
            ViewData["IsProhbitionPeriod"] = await model.GetProhbation(id);
            if (await model.GetProhbation(id))
            {
                ViewData["leaveHistory"] = await model.ProhbitionEmployeeLeaves(id); ;
            }
            else
            {
                ViewData["leaveHistory"] = await model.EmpLeaveTakenAndLeftDetails(id);
            }
            // ends
            return View(employee);
        }
        public async Task<IActionResult> EmpLeaves(int id)
        {
            var pendingLeaves = await model.pendingLeaves(id);

            return PartialView("_EmpLeaves", pendingLeaves);
        }

        public async Task<IActionResult> EditEmpLeaveBasedOnLeaveID(int LeaveID)
        {
            var editLeaves = await model.editLeaves(LeaveID);

            return PartialView("_EditEmpLeave", editLeaves);
        }
        public async Task<IActionResult> EditBalanceEmpLeave(int ID)
        {
            var editLeaves = await model.editBalanceLeaves(ID);

            return PartialView("_EditBalanceEmpLeave", editLeaves);
        }
        public async Task<IActionResult> GetEmpLeave(int EmpId, int fkLeaveType)
        {
            // SaveNewLeaveData obj = new SaveNewLeaveData();         
            // obj.Id = Emp_Id;
            //obj.fkLeaveType = fkLeaveType;
            //obj.FromDate = DateTime.Now;
            // obj.ToDate = DateTime.Now;
            SaveNewLeaveData SaveNewLeaveData = new SaveNewLeaveData();
            var data = EmpLeaveTakenAndLeftDetails(EmpId);
            SaveNewLeaveData = (from emp in _context.Employee
                                join dept in _context.TblEDepartment on emp.FkDepartment equals dept.Id
                                join emp1 in _context.Employee on emp.ReportingTo equals emp1.Id
                                join emp2 in _context.Employee on emp.ProjectReportingTo equals emp2.Id
                                where emp.Id == EmpId
                                orderby emp.Id
                                select new SaveNewLeaveData
                                {
                                    Id = emp.Id,
                                    Emp_Id = emp.EmpId,
                                    Department = dept.Id,
                                    FirstLineManager_id = emp1.EmpId,
                                    SecondLineManager_id = emp2.EmpId,
                                    fkLeaveType = fkLeaveType,
                                    FromDate = DateTime.Now,
                                    ToDate = DateTime.Now,
                                    fkEmploymentStatus = emp.FkEmploymentStatus,
                                    CasualLeaveTaken = data.Result.CasualLeaveTaken,
                                    CasualLeavesLeft = data.Result.CasualLeavesLeft,
                                    SickLeaveTaken = data.Result.SickLeaveTaken,
                                    SickLeavesLeft = data.Result.SickLeavesLeft,
                                    PaidLeaveTaken = data.Result.PaidLeaveTaken,
                                    PaidLeavesLeft = data.Result.PaidLeavesLeft,
                                    WorkFromHomeLeft = data.Result.WorkFromHomeLeft,
                                    WorkFromHomeTaken = data.Result.WorkFromHomeTaken,
                                    LWP = data.Result.LWP
                                }).FirstOrDefault();
            return PartialView("_AddEmpLeave", SaveNewLeaveData);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmpLeave(SaveNewLeaveData saveNewLeaveData)
        {

            var editLeaves = await model.SaveNewLeaveData(saveNewLeaveData);




            return PartialView("_EditEmpLeave");
        }

        public async Task<ClsEmp_GetEmployeePendingLeaves> EmpLeaveTakenAndLeftDetails(int userId)
        {
            try
            {
                ClsEmp_GetEmployeePendingLeaves clsEmpLeaveTakenAndLeftDetails = new ClsEmp_GetEmployeePendingLeaves();

                clsEmpLeaveTakenAndLeftDetails = await _context.Set<ClsEmp_GetEmployeePendingLeaves>().FromSql("dbo.[Emp_GetEmployeePendingLeaves] @Userid = {0}", userId).FirstOrDefaultAsync();
                // clsEmpLeaveTakenAndLeftDetails = await _context.Set<ClsEmpLeaveTakenAndLeftDetails>().FromSql("dbo.[Emp_TakenAndLeftLeaveDetails] @Userid = {0}", userId).FirstOrDefaultAsync();
                return clsEmpLeaveTakenAndLeftDetails;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ControllerName: DashboardViewModel, methodName: EmpLeaveTakenAndLeftDetails, Parameter: userId=" + userId, "WEB/API");
                return null;
            }

        }



        public async Task<IActionResult> SaveLeaveChangesBasedOnLeaveID(UpdateLeaveData updateLeaveData)
        {
            var editLeaves = await model.updateLeavesData(updateLeaveData);

            return Json(new { success = true });
        }
        public async Task<IActionResult> SaveBalanceLeaveChangesBasedID(UpdateBalanceLeaveData updateLeaveData)
        {
            var editLeaves = await model.updateBalanceLeavesData(updateLeaveData);

            return Json(new { success = true });
        }
        public async Task<IActionResult> TopLeaveDept()
        {
            var leaves = await model.TotalDeptLeaves();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }

        public async Task<IActionResult> TopLeaveByDept()
        {
            var leaves = await model.TopLeavesByDept();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.total,
                name = x.name
            }).ToList();
            return Json(graph);
        }

        public async Task<IActionResult> Top5EmployeeByDepartment(int DepId)
        {
            var leaves = await model.TopDepartmentLeaves(DepId);
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.total,
                name = x.name
            }).ToList();
            return Json(graph);
        }

        public async Task<IActionResult> Top5Leave()
        {
            try
            {
                var leaves = await model.TopLeaves();
                List<GraphModel> graph = leaves.Select(x => new GraphModel
                {
                    y = x.total,
                    name = x.name
                }).ToList();
                return Json(graph);
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "ContollerName: AdminController, methodName: Top5Leave", "WebPart");
                return Json(false);
            }
        }

        public IActionResult EmpPieChart(int userID)
        {
            var pendingLeaves = model.pendingLeavesDetails(userID);
            List<LeaveGraph> leaves = new List<LeaveGraph>();
            leaves.Add(new LeaveGraph { LeaveName = "Casual Leave", LeaveCount = pendingLeaves.CasualLeavesLeft });
            leaves.Add(new LeaveGraph { LeaveName = "Sick Leave", LeaveCount = pendingLeaves.SickLeavesLeft });
            leaves.Add(new LeaveGraph { LeaveName = "Paid Leave", LeaveCount = pendingLeaves.PaidLeavesLeft });
            leaves.Add(new LeaveGraph { LeaveName = "Total Leaves", LeaveCount = pendingLeaves.TotalLeavesLeft });

            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.LeaveCount,
                name = x.LeaveName
            }).ToList();
            return Json(graph);
        }

        public async Task<IActionResult> EmployeeLeavesDetails(int id, int LeaveType, int lwp)
        {
            var EmployeDeatils = await model.LeaveHistoryByID(id, LeaveType, lwp);
            return PartialView("_EmployeeLeavesDetails", EmployeDeatils);
        }

        public async Task<IActionResult> EmployeeLeavesLWPDetails(int id, int lwp)
        {
            try
            {
                var EmployeDeatils = await model.LeaveHistoryLWPByID(id, lwp);
                return PartialView("_EmployeeLeavesLWPDetails", EmployeDeatils);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> EmployeeBalanceLeavesDetails(int id)
        {
            try
            {
                var EmployeDeatils = await model.BalanceLeaveByID(id);
                return PartialView("_EmployeeBalanceLeave", EmployeDeatils);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> LeaveCountsByID(int userID)
        {
            PendingLeaves allocateLeaves = new PendingLeaves();
            decimal AllocatedLeaves = 0;
            decimal AllocatedCasualLeaves = 0;
            decimal AllocatedSickLeaves = 0;
            decimal AllocatedPaidLeaves = 0;
            decimal TotalLeaveLeft = 0;
            decimal CasualLeavesTakenCount = 0;
            decimal SickLeavesTakenCount = 0;
            decimal PaiedLeavesTakenCount = 0;
            decimal LWPLeavesTakenCount = 0;

            var LeavesTypes = await model.SummarisedLeavesCounts(userID, 5, 0);
            //var CasualLeaves = await model.SummarisedLeavesCounts(userID,1,0);
            //var SickLeaves = await model.SummarisedLeavesCounts(userID,3,0);

            var PaiedLeavesTaken = model.LeavesCountsPerYearByID(userID, 5, 0);
            var CasualLeavesTaken = model.LeavesCountsPerYearByID(userID, 1, 0);
            var SickLeavesTaken = model.LeavesCountsPerYearByID(userID, 3, 0);
            var LWPLeavesTaken = model.LeavesCountsPerYearLWPByID(userID, 3, 1);

            allocateLeaves = await model.pendingLeaves(userID);
            if (allocateLeaves != null)
            {
                AllocatedLeaves = allocateLeaves.AllowedTotalLeaves;
                TotalLeaveLeft = allocateLeaves.TotalLeavesLeft;
                AllocatedCasualLeaves = allocateLeaves.AllowedCasualLeaves;
                AllocatedSickLeaves = allocateLeaves.AllowedSickLeaves;
                AllocatedPaidLeaves = allocateLeaves.PaidLeavesLeft;
            }


            List<LeaveTakenBar> TakenLeaves = new List<LeaveTakenBar>();

            if (CasualLeavesTaken == null)
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = 0 });
            }
            else
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = CasualLeavesTaken.CL });
                CasualLeavesTakenCount = CasualLeavesTaken.CL;
            }

            if (SickLeavesTaken == null)
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = 0 });
            }
            else
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = SickLeavesTaken.SL });
                SickLeavesTakenCount = SickLeavesTaken.SL;
            }

            if (PaiedLeavesTaken == null)
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = 0 });
            }
            else
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = PaiedLeavesTaken.PL });
                PaiedLeavesTakenCount = PaiedLeavesTaken.PL;
            }

            if (LWPLeavesTaken == null)
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = 0 });
            }
            else
            {
                TakenLeaves.Add(new LeaveTakenBar { LeaveTakenCount = LWPLeavesTaken.TL });
                LWPLeavesTakenCount = LWPLeavesTaken.TL;
            }

            List<LeaveLeftBar> LeftLeaves = new List<LeaveLeftBar>();

            if (LeavesTypes == null)
            {
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = 0 });
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = 0 });
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = 0 });
            }
            else
            {
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = LeavesTypes.CasualLeavesLeft });
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = LeavesTypes.SickLeavesLeft });
                LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = LeavesTypes.PaidLeavesLeft });
            }
            LeftLeaves.Add(new LeaveLeftBar { LeaveLeftCount = 0 });


            List<LeaveProgessBar> leaves = new List<LeaveProgessBar>();
            leaves.Add(new LeaveProgessBar { leaveTakenBar = TakenLeaves, leaveLeftBar = LeftLeaves });
            //List<GraphModel> graph = leaves.Select(x => new GraphModel
            //{
            //    y = x.LeaveCount,
            //    name = x.LeaveName
            //}).ToList();
            return Json(
                new
                {
                    Leaves = leaves,
                    allocatedCount = AllocatedLeaves,
                    casualLeavesTakenCount = CasualLeavesTakenCount,
                    sickLeavesTakenCount = SickLeavesTakenCount,
                    paiedLeavesTakenCount = PaiedLeavesTakenCount,
                    lwpLeavesTakenCount = LWPLeavesTakenCount,
                    totalLeaveLeft = TotalLeaveLeft,
                    allocatedCasualLeaves = AllocatedCasualLeaves,
                    allocatedSickLeaves = AllocatedSickLeaves,
                    allocatedPaidLeaves = AllocatedPaidLeaves
                });
        }
    }
}