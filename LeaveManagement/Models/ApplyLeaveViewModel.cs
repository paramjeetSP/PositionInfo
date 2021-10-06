using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class ApplyLeaveViewModel
    {
        public int ID { get; set; }
        public string Emp_Id { get; set; }
        public int LeaveType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveReason { get; set; }
        public bool HalfDay { get; set; }
        public bool IsLeaveWithoutPay { get; set; }
        public decimal Elc { get; set; }
    }
    public class LeaveAppliedCount
    {
        public int Empid { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public string userid { get; set; }
    }    

}
