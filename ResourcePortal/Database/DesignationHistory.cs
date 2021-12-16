using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class DesignationHistory
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? DesignationId { get; set; }
        public int? Grade { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public TblEDesignation Designation { get; set; }
        public TblEGrade GradeNavigation { get; set; }
    }
}
