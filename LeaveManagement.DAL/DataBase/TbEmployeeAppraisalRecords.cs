using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TbEmployeeAppraisalRecords
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

        public TblEDepartment FkdepartmentNavigation { get; set; }
        public Employee FkemployeeNavigation { get; set; }
    }
}
