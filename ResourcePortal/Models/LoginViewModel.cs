using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResourcePortal.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username required !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password required !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string AuthCode { get; set; }
        public bool RememberMe { get; set; }
    }
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string FullName { get; set; }
        public string Dept { get; set; }
        public string Grade { get; set; }
        public List<Roles> Roles { get; set; }
    }
    public class Roles
    {
        public int Id { get; set; }
        public string Role { get; set; }
    }
}
