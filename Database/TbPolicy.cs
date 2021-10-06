using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbPolicy
    {
        public int Id { get; set; }
        public int FkpcId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual TblEPolicyCategory Fkpc { get; set; }
    }
}
