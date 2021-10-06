using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TlAcceptEthic
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public DateTime? AcceptDate { get; set; }
        public bool? IsAgree { get; set; }
        public int? FkEthics { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TlEthic FkEthicsNavigation { get; set; }
    }
}
