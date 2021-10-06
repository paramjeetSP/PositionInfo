using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbDocumentType
    {
        public TbDocumentType()
        {
            EmpDocuments = new HashSet<EmpDocument>();
        }

        public int Id { get; set; }
        public string DocumentName { get; set; }

        public virtual ICollection<EmpDocument> EmpDocuments { get; set; }
    }
}
