using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class DesignationHistory
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? DesignationId { get; set; }
        public int? Grade { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TblEDesignation Designation { get; set; }
        public virtual TblEGrade GradeNavigation { get; set; }
    }
}
