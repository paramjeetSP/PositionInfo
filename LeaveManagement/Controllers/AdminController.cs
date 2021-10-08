using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    //[Authorize(Roles = "Admin")]
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
            return View();
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
        public async Task<IActionResult> TopLeaveDept1()
        {
            var leaves = await model.TotalDeptLeaves1();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
        public async Task<IActionResult> TopLeaveDept2()
        {
            var leaves = await model.TotalDeptLeaves2();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
        public async Task<IActionResult> TopLeaveDept3()
        {
            var leaves = await model.TotalDeptLeaves3();
            List<GraphModel> graph = leaves.Select(x => new GraphModel
            {
                y = x.ActualCount,
                name = x.DeptName
            }).ToList();
            return Json(graph);
        }
    }
}