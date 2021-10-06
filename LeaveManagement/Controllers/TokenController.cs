using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.Database;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private Recovered_hrmsnewContext _context;
        private readonly IConfiguration _configuration;

        public TokenController(Recovered_hrmsnewContext context,IConfiguration configuration   )
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: api/token
        [HttpPost]
        public  IActionResult Get(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user =  _context.Employee.Where(x => x.EmpId == model.UserName && x.LoginPassword == model.Password && x.EmpStatus=="Active").FirstOrDefault();
                if (user != null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, user.EmpId),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    var token = new JwtSecurityToken
                    (
                        issuer: _configuration["Token:Issuer"],
                        audience: _configuration["Token:Audience"],
                        claims: claims,
                        expires: DateTime.UtcNow.AddDays(60),
                        notBefore: DateTime.UtcNow,
                        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:Key"])),
                                SecurityAlgorithms.HmacSha256)
                    );                    
                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                }
                else
                {
                    return Unauthorized();
                }
            }
            return BadRequest();
        }

    }
}