using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblERelationship
    {
        public TblERelationship()
        {
            EmpDependent = new HashSet<EmpDependent>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<EmpDependent> EmpDependent { get; set; }
    }
}
