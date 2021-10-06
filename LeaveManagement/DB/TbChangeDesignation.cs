using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TbChangeDesignation
    {
        public int Id { get; set; }
        public int FkemployeeId { get; set; }
        public int FkoldDesignation { get; set; }
        public int FknewDesignation { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ChangeDate { get; set; }
        public int? FkoldGrade { get; set; }
        public int? FknewGrade { get; set; }
        public string Experience { get; set; }

        public TblEDesignation FkoldDesignationNavigation { get; set; }
    }
}
