using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class EmpDependent
    {
        public int Id { get; set; }
        public int? FkEmployee { get; set; }
        public string DependentName { get; set; }
        public DateTime? Dob { get; set; }
        public string DependentContactNo { get; set; }
        public string DependentAddress { get; set; }
        public bool? IsNominee { get; set; }
        public bool? IsPrimary { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? FkRelationship { get; set; }

        public TblERelationship FkRelationshipNavigation { get; set; }
    }
}
