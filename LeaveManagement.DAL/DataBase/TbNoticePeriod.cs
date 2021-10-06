using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TbNoticePeriod
    {
        public int Id { get; set; }
        public int FkDesignation { get; set; }
        public int NoticePeriod { get; set; }

        public TblEDesignation FkDesignationNavigation { get; set; }
    }
}
