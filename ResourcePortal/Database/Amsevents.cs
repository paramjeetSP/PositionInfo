using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class Amsevents
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string SentTo { get; set; }
        public bool? IsActive { get; set; }
    }
}
