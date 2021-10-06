using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TblEModule
    {
        public TblEModule()
        {
            ModulePermission = new HashSet<ModulePermission>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<ModulePermission> ModulePermission { get; set; }
    }
}
