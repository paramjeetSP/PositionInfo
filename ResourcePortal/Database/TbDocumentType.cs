using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TbDocumentType
    {
        public TbDocumentType()
        {
            EmpDocument = new HashSet<EmpDocument>();
        }

        public int Id { get; set; }
        public string DocumentName { get; set; }

        public ICollection<EmpDocument> EmpDocument { get; set; }
    }
}
