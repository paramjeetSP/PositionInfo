using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class EmployeeEmailList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmpCode { get; set; }
        public string OfficialEmail1 { get; set; }
        public string OfficialEmail2 { get; set; }
        public bool? IsActive { get; set; }
    }
}
