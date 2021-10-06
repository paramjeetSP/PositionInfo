using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class EmployeeRole
    {
        public int Id { get; set; }
        public int FkRole { get; set; }
        public int FkEmployee { get; set; }

        public TblERole FkRoleNavigation { get; set; }
    }
}
