using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username required !")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password required !")]
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
        public List<Roles> Roles { get; set; }
       
    }

    public class EmployeeViewApiModel
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string FullName { get; set; }
        public List<Roles> Roles { get; set; }

    }
    public class Roles
    {
        public int Id { get; set; }       
        public string Role { get; set; }
    }

}
