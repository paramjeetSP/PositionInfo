using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class EmployeeRole
    {
        public int Id { get; set; }
        public int FkRole { get; set; }
        public int FkEmployee { get; set; }

        public virtual TblERole FkRoleNavigation { get; set; }
    }
}
