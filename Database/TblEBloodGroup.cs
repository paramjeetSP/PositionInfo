using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEBloodGroup
    {
        public TblEBloodGroup()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
