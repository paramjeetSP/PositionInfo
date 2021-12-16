using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class AbsenteesCount
    {
        public int Id { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string EmailBody { get; set; }
        public bool? Status { get; set; }
    }
}
