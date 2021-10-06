using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEModule
    {
        public TblEModule()
        {
            ModulePermissions = new HashSet<ModulePermission>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ModulePermission> ModulePermissions { get; set; }
    }
}
