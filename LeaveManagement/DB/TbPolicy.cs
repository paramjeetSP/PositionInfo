using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TbPolicy
    {
        public int Id { get; set; }
        public int FkpcId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }

        public TblEPolicyCategory Fkpc { get; set; }
    }
}
