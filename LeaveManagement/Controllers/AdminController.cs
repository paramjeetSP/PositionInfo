using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using LeaveManagement.SP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly DashboardViewModel model;

        public AdminController(Recovered_hrmsnewContext context, StoredProcedure spcontext, IHttpContextAccessor httpContextAccessor)
        {
            model = new DashboardViewModel(context, spcontext, httpContextAccessor);
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> PartialAvailable()
        {
            var leaves = await model.PartialAvailable();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
        public async Task<IActionResult> FullAvailable()
        {
            var leaves = await model.FullAvailable();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
        public async Task<IActionResult> OpenPosition()
        {
            var leaves = await model.OpenPosition();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
        public async Task<IActionResult> ClosedPosition()
        {
            var leaves = await model.ClosedPosition();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
    }
}