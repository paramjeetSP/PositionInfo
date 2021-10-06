using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RandomCodeGeneratorController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public RandomCodeGeneratorController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }

        [HttpGet]
        [Route("AuthenticationCode")]
        public async Task<IActionResult> Index()
        {
            //var EmployeeList = await model.EmployeeListWithCodeGenerator();
            return View();
        }

        [HttpGet]
        [Route("AuthCodeGrid")]
        public async Task<IActionResult> GetAuthCodeGrid()
        {
            var EmployeeList = await model.EmployeeListWithCodeGenerator();
            return PartialView("~/Views/Shared/_AuthCodeTable.cshtml", EmployeeList);
        }
        public async Task<IActionResult> GenerateCode(int userID)
        {
            var Is_CodeGenerated = await model.CodeGenerator(userID);
            if (Is_CodeGenerated)
            {
                return Json(Is_CodeGenerated);
            }
            return Json(false);
        }
    }
}