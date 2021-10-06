using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
