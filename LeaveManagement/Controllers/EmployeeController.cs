using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles ="User")]
    public class EmployeeController : Controller
    {
        private Recovered_hrmsnewContext _context;
        public EmployeeController(Recovered_hrmsnewContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}