using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblHEmployeeRole
    {
        public int? Id { get; set; }
        public int? FkRole { get; set; }
        public int? FkEmployee { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
