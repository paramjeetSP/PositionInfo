using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblERelationship
    {
        public TblERelationship()
        {
            EmpDependents = new HashSet<EmpDependent>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmpDependent> EmpDependents { get; set; }
    }
}
