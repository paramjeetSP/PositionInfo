using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblECertification
    {
        public TblECertification()
        {
            EmpCertification = new HashSet<EmpCertification>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<EmpCertification> EmpCertification { get; set; }
    }
}
