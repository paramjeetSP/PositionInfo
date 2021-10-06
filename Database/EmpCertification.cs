using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class EmpCertification
    {
        public int Id { get; set; }
        public int? FkEmployee { get; set; }
        public int? FkCertification { get; set; }
        public string Institution { get; set; }
        public int? PassingYear { get; set; }
        public decimal? PercentSecured { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblECertification FkCertificationNavigation { get; set; }
    }
}
