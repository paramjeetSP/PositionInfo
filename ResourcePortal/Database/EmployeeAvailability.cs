using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class EmployeeAvailability
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public bool? PartialAvailable { get; set; }
        public DateTime? ExpPartialDateAvailability { get; set; }
        public bool? MarkToBench { get; set; }
        public string CurrentProjName { get; set; }
        public string Skillset { get; set; }
    }
}
