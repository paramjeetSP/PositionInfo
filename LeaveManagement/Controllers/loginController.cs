using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.BAL;
using LeaveManagement.Database;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private Recovered_hrmsnewContext _context;
        private DashboardViewModel model;
        public loginController(Recovered_hrmsnewContext context)
        {
            _context = context;
            model = new DashboardViewModel(context);
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Employee employee = await model.Login(viewModel.UserName, viewModel.Password, viewModel.AuthCode);
                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    return Unauthorized();
                }
            }
            return BadRequest("Invalid request!");
        }

        [HttpGet]
        public IActionResult test()
        {
            return Ok();
        }
    }
}