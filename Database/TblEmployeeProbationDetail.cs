using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEmployeeProbationDetail
    {
        public int Id { get; set; }
        public int? FkEmpId { get; set; }
        public string Reason { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? ActualDoj { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Employee FkEmp { get; set; }
    }
}
