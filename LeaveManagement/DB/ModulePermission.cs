using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class ModulePermission
    {
        public int Id { get; set; }
        public int? FkModule { get; set; }
        public int? FkRole { get; set; }
        public bool? CanAdd { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanDelete { get; set; }
        public bool? CanView { get; set; }

        public TblEModule FkModuleNavigation { get; set; }
        public TblERole FkRoleNavigation { get; set; }
    }
}
