using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmployeeAppraisalRecord
    {
        public int Id { get; set; }
        public int Fkemployee { get; set; }
        public int Fkdepartment { get; set; }
        public string AppraisalCycle { get; set; }
        public string AppraisalDueOn { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string Comments { get; set; }

        public virtual TblEDepartment FkdepartmentNavigation { get; set; }
        public virtual Employee FkemployeeNavigation { get; set; }
    }
}
