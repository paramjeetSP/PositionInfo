using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class PositionInfo : Controller
    {
        private DashboardViewModel model;

        public PositionInfo(Recovered_hrmsnewContext context)
        {
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
