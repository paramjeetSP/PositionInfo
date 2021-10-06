using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class EmpExperience
    {
        public int Id { get; set; }
        public int? FkEmployee { get; set; }
        public string Employer { get; set; }
        public string JobTitle { get; set; }
        public string CompanyAddress { get; set; }
        public string NatureofDuties { get; set; }
        public string LeavingReason { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
