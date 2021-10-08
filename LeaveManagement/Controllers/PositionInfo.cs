using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using LeaveManagement.SP;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class PositionInfo : Controller
    {
        private readonly DashboardViewModel model;

        public PositionInfo(Recovered_hrmsnewContext context, StoredProcedure spcontext)
        {
            model = new DashboardViewModel(context, spcontext);
        }
        public IActionResult Index()
        {
            var list = model.EmployeesList();
            return View(list);
        }
        public async Task<IActionResult> EditEmpResourse(int ID)
        {
            var editLeaves = await model.EditEmpRes(ID);
            return PartialView("_EditEmpResourse", editLeaves);
        }
        public async Task<IActionResult> SaveResChangesBasedID(EmployeeResDetails updateLeaveData)
        {
            bool editLeaves = await model.UpdateEmpResData(updateLeaveData);
            return Json(new { success = editLeaves });
        }
    }
}
