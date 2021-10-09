using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.SP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagement.Controllers
{
    [Authorize]
    public class PositionHRInfo : Controller
    {
        private readonly DashboardViewModel model;

        public PositionHRInfo(Recovered_hrmsnewContext context, StoredProcedure spcontext, IHttpContextAccessor httpContextAccessor)
        {
            model = new DashboardViewModel(context, spcontext, httpContextAccessor);
        }
        public IActionResult Index()
        {
            var list = model.HREmployeesList();
            return View(list);
        }
        public async Task<IActionResult> EditEmpResourse(int ID)
        {
            var editLeaves = await model.EditHREmpRes(ID);
            return PartialView("_HRPositionInfo", editLeaves);
        }
        public async Task<IActionResult> SaveHRChangesBasedID(HrpositionInfo updateLeaveData)
        {
            bool editLeaves = await model.UpdateEmpHRResData(updateLeaveData);
            return Json(new { success = editLeaves });
        }
        public async Task<IActionResult> ViewEmpskills(int ID)
        {
            var editLeaves = await model.EditHREmpRes(ID);
            return PartialView("_SkillsInfo", editLeaves);
        }
    }
}
