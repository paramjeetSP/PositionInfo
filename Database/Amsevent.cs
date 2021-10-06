using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class Amsevent
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string SentTo { get; set; }
        public bool? IsActive { get; set; }
    }
}
