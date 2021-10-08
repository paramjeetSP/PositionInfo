using LeaveManagement.Database;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LeaveManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly Recovered_hrmsnewContext _context;
        public AccountController(Recovered_hrmsnewContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult PageNotFound()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            bool isUservalid = false;
            EmployeeViewModel user = _context.Employee.Where(usr => usr.EmpId == model.UserName &&
            usr.LoginPassword == model.Password &&
            usr.EmpStatus == "Active").Select(x => new EmployeeViewModel
            {
                Id = x.Id,
                EmpId = x.EmpId,
                FullName = x.FullName,
                Roles = _context.EmployeeRole.Join(_context.TblERole, a => a.FkRole, b => b.Id, (a, b) => new { a, b }).Where(i => i.a.FkEmployee == x.Id).Select(z => new Roles
                {
                    Id = z.b.Id,
                    Role = z.b.RoleName
                }).ToList(),
            }).SingleOrDefault();
            if (user != null)
            {
                isUservalid = true;
            }
            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.EmpId),
                    new Claim("FullName", user.FullName),
                    new Claim("EmpId", user.Id.ToString())
                };
                if (user != null && user.Roles.Count > 0)
                {
                    foreach (var role in user.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.Role));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "User"));
                }
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties
                {
                    IsPersistent = model.RememberMe
                };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal, props).Wait();
                var roleData = user.Roles.Where(x => x.Role == "HR" || x.Role == "Admin").FirstOrDefault();
                if (roleData != null)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password!");
                ViewData["message"] = "Invalid UserName or Password!";
            }

            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}