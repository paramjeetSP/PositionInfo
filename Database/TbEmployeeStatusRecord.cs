using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
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

        public virtual TbEmployeeStatusEvent EventRecordNavigation { get; set; }
        public virtual TblEDesignation FkdesignationNavigation { get; set; }
        public virtual TblEEmpType FkempTypeNavigation { get; set; }
        public virtual Employee FkemployeeNavigation { get; set; }
        public virtual TblEEmploymentStatus FkemploymentStatusNavigation { get; set; }
        public virtual TblEGrade FkgradeNavigation { get; set; }
    }
}
