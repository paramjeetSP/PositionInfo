using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblEBloodGroup
    {
        public TblEBloodGroup()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
