using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblERole
    {
        public TblERole()
        {
            EmployeeRoles = new HashSet<EmployeeRole>();
            ModulePermissions = new HashSet<ModulePermission>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
        public virtual ICollection<ModulePermission> ModulePermissions { get; set; }
    }
}
