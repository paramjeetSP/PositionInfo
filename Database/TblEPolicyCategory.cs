using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEPolicyCategory
    {
        public TblEPolicyCategory()
        {
            TbPolicies = new HashSet<TbPolicy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<TbPolicy> TbPolicies { get; set; }
    }
}
