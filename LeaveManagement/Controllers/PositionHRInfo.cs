using LeaveManagement.BAL;
using LeaveManagement.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
