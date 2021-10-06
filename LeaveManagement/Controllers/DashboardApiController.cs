using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardApiController : ControllerBase
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public DashboardApiController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }


        [Route("pendingleave/{id}")]
        [HttpGet]
        public async Task<IActionResult> PendingLeaves([FromQuery]int id)
        {
            try
            {
                PendingLeaves leaveData = await model.pendingLeaves(id);
                return Ok(leaveData);
            }
            catch (Exception ex)
            {
                return Unauthorized();
                throw;
            }
        }


        [Route("leavestatus/{id}")]
        [HttpGet]
        public async Task<IActionResult> empLeaveStatus([FromQuery]int id)
        {
            try
            {
                List<EmpLeavesStatus> _list = await model.empLeaveStatus(id);
                return Ok(_list);
            }
            catch(Exception ex)
            {
                return Unauthorized();
            }

            //if(_list.Count()== 0)
            //{
            //    return Unauthorized();
            //}
           
        }


        [Route("profile/{id}")]
        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] int id)
        {
            SingleEmployee employee = await model.profile(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }


        [Route("GetUserImagePath/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetUserImagePath([FromQuery] int id)
        {
            GetUserImagePath employee = await model.ImagePath(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("getLeaveTypes")]
        [HttpGet]
        public async Task<IActionResult> GetLeaveTypes()
        {
            try
            {
                var data = _context.TblELeaveType.ToList();
                data.RemoveAll(m => m.Description == "Sudden Leave");
                data.RemoveAll(m => m.Description == "Half Day");
                data.RemoveAll(m => m.Description == "Total Leave");
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }


        [Route("applyleave")]
        [HttpPost]
        public async Task<IActionResult> applyLeave(ApplyLeaveViewModel applyLeaveModel)
        {
            try
            {
                LeaveStatus obj = new LeaveStatus();
                // get the emp_id
                string Emp_Id;
                string Hr_Id = string.Empty;
                var employeedata = _context.Employee.Where(m => m.Id == applyLeaveModel.ID).FirstOrDefault();
                
                if (employeedata != null)
                {
                    Emp_Id = employeedata.EmpId;
                    bool isProb = false;
                    Emp_ProbationStatusWithColName is_ProbationStatus = await model.Emp_ProbationStatus(applyLeaveModel.ID);
                    if (is_ProbationStatus.IsProbationStatus == 1) {
                        isProb = true;
                    } else {
                        isProb = false;
                    }


                    // get the firstline manager and second line manager based on empcode
                    FirstLineManager firstLineManager = await model.GetFirstLineManager(Emp_Id);
                    SecondLineManager secondLineManager = new SecondLineManager();
                    Hr_Id= model.GetHrName();
                    if (firstLineManager != null)
                    {
                        secondLineManager = await model.GetSecondLineManager(firstLineManager.emp_id);
                    }

                    // get department Id

                    int? deptId = employeedata.FkDepartment;
                    bool isElcFlag = false;
                    if (applyLeaveModel.Elc > 0.0M)
                    {
                        isElcFlag = true;
                    }
                    obj = new LeaveStatus
                    {
                        EmpId = Emp_Id,
                        FkLeaveType = applyLeaveModel.LeaveType,
                        Department = Convert.ToString(deptId),
                        FromDate = applyLeaveModel.FromDate,
                        ToDate = applyLeaveModel.ToDate,
                        LeaveReason = applyLeaveModel.LeaveReason,
                        FirstLineManagerId = firstLineManager != null ? firstLineManager.emp_id : null,
                        FirstLineManagerStatus = 1,
                        SecondLineManagerId = secondLineManager != null ? secondLineManager.emp_id : null,
                        SecondLineManagerStatus = 1,
                        HrId = Hr_Id,
                        HrStatus = 1,
                        EmpLeaveStatus=1,
                        IsHalfDay = applyLeaveModel.HalfDay,
                        LeaveAppliedDate = DateTime.Now,
                        CreatedOn = DateTime.Now,
                        IsProbationLeave = isProb,
                        CreatedBy = Emp_Id,
                        IsLwp=applyLeaveModel.IsLeaveWithoutPay,
                        //Extra Column added on 20.02.2019
                        Elc = applyLeaveModel.Elc,
                        IsElcflag = isElcFlag
                    };
                    _context.LeaveStatus.Add(obj);
                    await _context.SaveChangesAsync();
                    return Ok(obj.Id);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }


        [Route("appversion")]
        [HttpGet]
        public async Task<IActionResult> GetAppVersionInfo()
        {
            return Ok(await model.GetAppVersionInfo());
        }


        [Route("CheckProhbation")]
        [HttpGet]
        public async Task<IActionResult> GetProhbationInfo(int userID)
        {
            return Ok(await model.GetProhbation(userID));
        }


        [Route("ExceptionLog")]
        [HttpGet]
        public async Task<IActionResult> GetExceptionInfo(ExceptionTrace exceptionTrace)
        {
            return Ok(await model.ExceptionLogger(exceptionTrace));
        }

        [Route("Prohibition")]
        [HttpGet]
        public async Task<IActionResult> GetProhibitionLeave(int UserID)
        {
            return Ok(await model.ProhbitionEmployeeLeaves(UserID));
        }

        [Route("leaveApplied")]
        [HttpPost]
        public async Task<IActionResult> GetLevaeStatus(LeaveAppliedCount model)
        {
            int counter = 0;            
            var data = await _context.LeaveStatus.Where(x => x.EmpId ==model.userid).Select(x => new
            {
                id = x.Id,
                start = x.FromDate,
                end = x.ToDate
            }
            ).ToListAsync();
            if (data != null)
            {

                var datesApplied = new List<DateTime>();

                for (var dt = model.from; dt <= model.to; dt = dt.AddDays(1))
                {
                    datesApplied.Add(dt);
                }
                foreach (var date in datesApplied)
                {
                    foreach (var item in data)
                    {
                        //var dd = Enumerable.Range(0, 1 + item.end.Value.Subtract(item.start.Value).Days)
                        //         .Select(offset => item.start.Value.AddDays(offset))
                        //                    .ToArray();

                        var dates = new List<DateTime>();

                        for (var dt = item.start; dt <= item.end; dt = dt.Value.AddDays(1))
                        {
                            dates.Add(dt ?? DateTime.Now.Date);
                        }
                        foreach (var app in dates)
                        {
                            if (app.Date == date)
                            {
                                counter++;
                                //break;
                                return Ok(counter);
                            }
                        }
                    }
                }



            }
            return Ok(counter);
        }


    }
}