using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TbNoticePeriod
    {
        public int Id { get; set; }
        public int FkDesignation { get; set; }
        public int NoticePeriod { get; set; }

        public TblEDesignation FkDesignationNavigation { get; set; }
    }
}
