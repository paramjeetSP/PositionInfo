using ResourcePortal.BAL;
using ResourcePortal.Database;
using ResourcePortal.Models.SpModels;
using ResourcePortal.SP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResourcePortal.Controllers
{
    [Authorize]
    public class PositionInfo : Controller
    {
        private readonly DashboardViewModel model;

        public PositionInfo(Recovered_hrmsnewContext context, StoredProcedure spcontext, IHttpContextAccessor httpContextAccessor)
        {
            model = new DashboardViewModel(context, spcontext, httpContextAccessor);
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
            return Json(await model.UpdateEmpResData(updateLeaveData));
        }
        public async Task<IActionResult> ViewEmpskills(int ID)
        {
            var editLeaves = await model.EditEmpRes(ID);
            return PartialView("_SkillsHRInfo", editLeaves);
        }
    }
}
