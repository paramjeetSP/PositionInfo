using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TblERole
    {
        public TblERole()
        {
            EmployeeRole = new HashSet<EmployeeRole>();
            ModulePermission = new HashSet<ModulePermission>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public ICollection<EmployeeRole> EmployeeRole { get; set; }
        public ICollection<ModulePermission> ModulePermission { get; set; }
    }
}
