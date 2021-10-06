using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblAllEmployeesLeaveDetails
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? DeptId { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        public string Grade { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string ConfirmationStatus { get; set; }
        public string _16 { get; set; }
        public string _17 { get; set; }
        public string _18 { get; set; }
        public string _19 { get; set; }
        public string _20 { get; set; }
        public string _21 { get; set; }
        public string _22 { get; set; }
        public string _23 { get; set; }
        public string _24 { get; set; }
        public string _25 { get; set; }
        public string _26 { get; set; }
        public string _27 { get; set; }
        public string _28 { get; set; }
        public string _29 { get; set; }
        public string _30 { get; set; }
        public string _31 { get; set; }
        public string _1 { get; set; }
        public string _2 { get; set; }
        public string _3 { get; set; }
        public string _4 { get; set; }
        public string _5 { get; set; }
        public string _6 { get; set; }
        public string _7 { get; set; }
        public string _8 { get; set; }
        public string _9 { get; set; }
        public string _10 { get; set; }
        public string _11 { get; set; }
        public string _12 { get; set; }
        public string _13 { get; set; }
        public string _14 { get; set; }
        public string _15 { get; set; }
        public decimal? LeaveBalanceCl { get; set; }
        public decimal? LeaveBalanceSl { get; set; }
        public decimal? LeaveBalancePl { get; set; }
        public decimal? LeaveBalanceTl { get; set; }
        public decimal? LeaveTakenCl { get; set; }
        public decimal? LeaveTakenSl { get; set; }
        public decimal? LeaveTakenPl { get; set; }
        public decimal? LeaveTakenTl { get; set; }
        public decimal? LeaveBalancefornexttenureCl { get; set; }
        public decimal? LeaveBalancefornexttenureSl { get; set; }
        public decimal? LeaveBalancefornexttenurePl { get; set; }
        public decimal? LeaveBalancefornexttenureTl { get; set; }
        public decimal? Lwpleave { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal? PayableDays { get; set; }
    }
}
