using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    public class EmployeeDailyLogController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public EmployeeDailyLogController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index(DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                string fromDate = "";
                string ToDate = "";
                if (StartDate != null || EndDate != null)
                {
                    fromDate = StartDate.Value.ToString("yyyy-MM-dd");
                    ToDate = EndDate.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    if (!string.IsNullOrEmpty(HttpContext.Session.GetString("fromDate")))
                    {
                        ViewBag.StartDate = HttpContext.Session.GetString("fromDate");
                        ViewBag.EndDate = HttpContext.Session.GetString("ToDate");
                        fromDate = HttpContext.Session.GetString("fromDate");
                        ToDate = HttpContext.Session.GetString("ToDate");
                        HttpContext.Session.Clear();
                    }
                    else
                    {
                        fromDate = null;
                        ToDate = null;
                    }
                }
                var EmployeDeatils = await model.LateComingDetails(fromDate, ToDate);
                return View(EmployeDeatils);
            }
            catch (Exception e)
            {
                return NotFound();
            }

        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> LateComingHistory(DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                var fromDate = "";
                var ToDate = "";
                if (StartDate != null || EndDate != null)
                {

                    fromDate = StartDate.Value.ToString("yyyy-MM-dd");
                    ToDate = EndDate.Value.ToString("yyyy-MM-dd");
                    HttpContext.Session.SetString("fromDate", fromDate);
                    HttpContext.Session.SetString("ToDate", ToDate);
                }
                else
                {
                    fromDate = null;
                    ToDate = null;
                }
                var EmployeDeatils = await model.LateComingDetails(fromDate, ToDate);
                return PartialView("_LateComingHistory", EmployeDeatils);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult LateComing_Details_History(string StartDate, string EndDate, int UserID)
        {
            try
            {
                TempData["StartDate"] = StartDate;
                TempData["EndDate"] = EndDate;
                TempData["UserID"] = UserID;
                if (!string.IsNullOrWhiteSpace(StartDate))
                {
                    HttpContext.Session.SetString("fromDate", StartDate);

                }
                if (!string.IsNullOrWhiteSpace(EndDate))
                {
                    HttpContext.Session.SetString("ToDate", EndDate);

                }
                return Json(new { status = "true", newurl = Url.Action("LateComingDetailsHistory") });
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, message = ex.Message });
            }
        }


        [HttpGet]
        public async Task<ActionResult> LateComingDetailsHistory()
        {
            string StartDate = null;
            string EndDate = null;
            int? UserID = null;
            if (TempData["StartDate"] != null && TempData["EndDate"] != null && TempData["UserID"] != null)
            {
                StartDate = TempData["StartDate"].ToString();
                EndDate = TempData["EndDate"].ToString();
                UserID = Convert.ToInt32(TempData["UserID"]);
                TempData["StartDate"] = StartDate;
                TempData["EndDate"] = EndDate;
                TempData["UserID"] = UserID;
            }
            else
            {
                UserID = Convert.ToInt32(TempData["UserID"]);
                TempData["UserID"] = UserID;
            }

            var EmployeHistory = await model.LateComing_Details_History(StartDate, EndDate, UserID, 1);
            var workingHoursDetails = await model.EmpWorkingHoursDetail(StartDate, EndDate, UserID, 0);
            if (workingHoursDetails.Count > 0)
            {
                //Actual working hours is swaped with total working hours
                ViewData["ActualWorkingHours"] = workingHoursDetails[0].TotalWorkingHours;
                ViewData["TotalWorkingHours"] = workingHoursDetails[0].ActualWorkingHours;
            }
            else
            {
                ViewData["ActualWorkingHours"] = 0;
                ViewData["TotalWorkingHours"] = 0;
            }
            return View(EmployeHistory);
        }
        [HttpGet]
        public async Task<IActionResult> LessWorkingHoursHistory(DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                string fromDate = "";
                string ToDate = "";
                if (StartDate != null || EndDate != null)
                {
                    fromDate = StartDate.Value.ToString("yyyy-MM-dd");
                    ToDate = EndDate.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    if (!string.IsNullOrEmpty(HttpContext.Session.GetString("fromDate")))
                    {
                        ViewBag.StartDate = HttpContext.Session.GetString("fromDate");
                        ViewBag.EndDate = HttpContext.Session.GetString("ToDate");
                        fromDate = HttpContext.Session.GetString("fromDate");
                        ToDate = HttpContext.Session.GetString("ToDate");
                        HttpContext.Session.Clear();
                    }
                    else
                    {
                        fromDate = null;
                        ToDate = null;
                    }
                }
                var EmployeDeatils = await model.LessWorkingHour_Details(fromDate, ToDate);

                return PartialView("_LessWorkingHours", EmployeDeatils);
            }
            catch (Exception e)
            {
                return NotFound();
            }

        }
    }
}