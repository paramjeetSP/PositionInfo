using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TbEmployeeStatusRecord
    {
        public int Id { get; set; }
        public int Fkemployee { get; set; }
        public int? Fkgrade { get; set; }
        public int? Fkdesignation { get; set; }
        public int? FkempType { get; set; }
        public int? Fkdepartment { get; set; }
        public int? FkemploymentStatus { get; set; }
        public string ExitStatus { get; set; }
        public int? EventRecord { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsDeleted { get; set; }

        public TbEmployeeStatusEvents EventRecordNavigation { get; set; }
        public TblEDesignation FkdesignationNavigation { get; set; }
        public TblEEmpType FkempTypeNavigation { get; set; }
        public Employee FkemployeeNavigation { get; set; }
        public TblEEmploymentStatus FkemploymentStatusNavigation { get; set; }
        public TblEGrade FkgradeNavigation { get; set; }
    }
}
