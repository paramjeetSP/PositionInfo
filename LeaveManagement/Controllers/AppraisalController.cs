using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.BAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaveManagement.Controllers
{
    public class AppraisalController : Controller
    {
        private readonly Recovered_hrmsnewContext _context;
        private Logging _logging;
        private DashboardViewModel model;
        public AppraisalController(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging(context);
            model = new DashboardViewModel(context);
        }
        // GET: /<controller>/
        public  async Task<IActionResult> Index()
        {
            //  return View();
            var list = await model.AllEmployees();
            return View(list);

        }
        public async Task<IActionResult> EmployeeDetails(int id)
        {
            var employee = await model.profile(id);
            // The below code is used to get the leave details as per leave type, created on 8-feb-2019
            //var leaveTypeData = await model.EmpLeaveTakenAndLeftDetails(id);
           // ViewData["IsProhbitionPeriod"] = await model.GetProhbation(id);
            //if (await model.GetProhbation(id))
            //{
            //    ViewData["leaveHistory"] = await model.ProhbitionEmployeeLeaves(id); ;
            //}
            //else
            //{
            //    ViewData["leaveHistory"] = await model.EmpLeaveTakenAndLeftDetails(id);
            //}
            // ends
            return View(employee);
        }

    }
}
