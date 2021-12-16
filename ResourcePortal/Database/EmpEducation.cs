using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class EmpEducation
    {
        public int Id { get; set; }
        public int? FkEmployee { get; set; }
        public string DegreeCertification { get; set; }
        public string Specialization { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public decimal? PercentSecured { get; set; }
        public string Institution { get; set; }
        public string University { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
