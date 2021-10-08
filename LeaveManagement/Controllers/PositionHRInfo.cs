using LeaveManagement.BAL;
using LeaveManagement.Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    public class PositionHRInfo : Controller
    {
        private DashboardViewModel model;

        public PositionHRInfo(Recovered_hrmsnewContext context)
        {
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
