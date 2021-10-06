using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles="User")]
    public class DashboardController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public DashboardController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }
        public async Task<IActionResult> Index()
        {
            int userid = UserID();
            var pendingLeaves = await model.pendingLeaves(userid);
            return View(pendingLeaves);
        }

        private int UserID()
        {
            var loggedInUser = HttpContext.User;
            //  var loggedInUserName = loggedInUser.Identity.Name; // This is our username we set earlier in the claims.
            var loggedInUserId = loggedInUser.Claims.FirstOrDefault(x => x.Type == "EmpId").Value; //Another way to get the name or any other claim we set.
            int userid = 0;
            int.TryParse(loggedInUserId, out userid);
            return userid;
        }

        public async Task<IActionResult> PieChart()
        {
            int userid = UserID();
            var pendingLeaves = await model.pendingLeaves(userid);
            List<LeaveGraph> leaves = new List<LeaveGraph>();
            leaves.Add(new LeaveGraph { LeaveName = "Casual Leave", LeaveCount = pendingLeaves.CasualLeavesLeft });
            leaves.Add(new LeaveGraph { LeaveName = "Sick Leave", LeaveCount = pendingLeaves.SickLeavesLeft });
            leaves.Add(new LeaveGraph { LeaveName = "Paid Leave", LeaveCount = pendingLeaves.PaidLeavesLeft });
            //leaves.Add(new LeaveGraph { LeaveName = "Total Leaves", LeaveCount = pendingLeaves.TotalLeavesLeft });

            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.LeaveCount,
                name = x.LeaveName
            }).ToList();
            return Json(graph);

        }

        public async Task<IActionResult> LeaveSummary()
        {
            int userId = UserID();
            var summary = await model.empLeaveStatus(userId);
            return View(summary);
        }
    }
}