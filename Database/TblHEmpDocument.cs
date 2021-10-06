using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblHEmpDocument
    {
        public int? Id { get; set; }
        public int? FkDocumentType { get; set; }
        public int? FkEmployeeId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
