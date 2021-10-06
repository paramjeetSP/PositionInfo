using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class PositionInfo : Controller
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        private Logging _logging;

        public PositionInfo(Recovered_hrmsnewContext context)
        {
            _context = context;
            _logging = new Logging();
            model = new DashboardViewModel(context);
        }
        public IActionResult Index()
        {
            var list = model.EmployeesList();
            return View(list);
        }

        public async Task<IActionResult> EditEmpResourse(int ID)
        {
            var editLeaves = await model.editEmpRes(ID);

            return PartialView("_EditEmpResourse", editLeaves);
        }
        public async Task<IActionResult> SaveBalanceLeaveChangesBasedID(EmployeeResDetails updateLeaveData)
        {
            bool editLeaves = await model.updateEmpResData(updateLeaveData);
            return Json(new { success = editLeaves });
        }
    }
}
