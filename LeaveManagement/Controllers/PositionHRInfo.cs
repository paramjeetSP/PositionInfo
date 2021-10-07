using LeaveManagement.BAL;
using LeaveManagement.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace LeaveManagement.Controllers
{
    public class PositionHRInfo : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        private Logging _logging;

        public PositionHRInfo(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging();
            model = new DashboardViewModel(context);
        }
        public IActionResult Index()
        {
            var list = model.HREmployeesList();
            return View(list);
        }

        public async Task<IActionResult> EditEmpResourse(int ID)
        {
            var editLeaves = await model.editHREmpRes(ID);
            return PartialView("_HRPositionInfo", editLeaves);
        }

        public async Task<IActionResult> SaveBalanceLeaveChangesBasedID(HrpositionInfo updateLeaveData)
        {
            bool editLeaves = await model.updateEmpHRResData(updateLeaveData);
            return Json(new { success = editLeaves });
        }
    }
}
