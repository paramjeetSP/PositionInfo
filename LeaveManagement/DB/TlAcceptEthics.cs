using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TlAcceptEthics
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public DateTime? AcceptDate { get; set; }
        public bool? IsAgree { get; set; }
        public int? FkEthics { get; set; }
        public bool? IsDeleted { get; set; }

        public TlEthics FkEthicsNavigation { get; set; }
    }
}
