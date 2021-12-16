using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class DetailedLeaveStatus
    {
        public int Id { get; set; }
        public int LeavestatusId { get; set; }
        public string EmpId { get; set; }
        public int? FkLeaveType { get; set; }
        public string Department { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string LeaveReason { get; set; }
        public string FirstLineManagerId { get; set; }
        public int? FirstLineManagerStatus { get; set; }
        public string FirstLineMangerComment { get; set; }
        public string SecondLineManagerId { get; set; }
        public int? SecondLineManagerStatus { get; set; }
        public string SecondLineManagerComment { get; set; }
        public string HrId { get; set; }
        public string HrComment { get; set; }
        public int? HrStatus { get; set; }
        public int? EmpLeaveStatus { get; set; }
        public DateTime? LeaveAppliedDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string AdminId { get; set; }
        public string AdminComment { get; set; }
        public DateTime? Fldecisiondate { get; set; }
        public DateTime? Sldecisiondate { get; set; }
        public DateTime? Hrrdecisiondate { get; set; }
        public bool IsHalfDay { get; set; }
        public bool IsProbationLeave { get; set; }
        public bool IsLwp { get; set; }
        public decimal Elc { get; set; }
        public bool? IsElcflag { get; set; }

        public TblELeaveType FkLeaveTypeNavigation { get; set; }
    }
}
