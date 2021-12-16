using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TbEmployeeExitRecord
    {
        public int Id { get; set; }
        public int? Fkemployee { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        public int? LeavingReason { get; set; }
        public string ReasonDetails { get; set; }
        public string Feedback { get; set; }
        public DateTime? FinalSettlementDate { get; set; }
        public DateTime? RelieveDate { get; set; }
        public DateTime? ExitInterviewDate { get; set; }
        public bool? IsNoticeRequired { get; set; }
        public bool? IsNoticeServed { get; set; }
        public int? ShortFallInNotice { get; set; }
        public bool? IsDeceased { get; set; }
        public DateTime? DemiseDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsRehired { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsReleavingMail { get; set; }

        public Employee FkemployeeNavigation { get; set; }
        public TblEExitStatus LeavingReasonNavigation { get; set; }
    }
}
