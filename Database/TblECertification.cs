using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblECertification
    {
        public TblECertification()
        {
            EmpCertifications = new HashSet<EmpCertification>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmpCertification> EmpCertifications { get; set; }
    }
}
