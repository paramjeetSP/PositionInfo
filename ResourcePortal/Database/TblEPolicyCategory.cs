using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblEPolicyCategory
    {
        public TblEPolicyCategory()
        {
            TbPolicy = new HashSet<TbPolicy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public TblEPolicyCategory IdNavigation { get; set; }
        public TblEPolicyCategory InverseIdNavigation { get; set; }
        public ICollection<TbPolicy> TbPolicy { get; set; }
    }
}
