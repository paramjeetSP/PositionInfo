using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblEmployeeProbationDetails
    {
        public int Id { get; set; }
        public int? FkEmpId { get; set; }
        public string Reason { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? ActualDoj { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

        public Employee CreatedByNavigation { get; set; }
        public Employee FkEmp { get; set; }
    }
}
