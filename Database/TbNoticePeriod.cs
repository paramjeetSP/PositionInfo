using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbNoticePeriod
    {
        public int Id { get; set; }
        public int FkDesignation { get; set; }
        public int NoticePeriod { get; set; }

        public virtual TblEDesignation FkDesignationNavigation { get; set; }
    }
}
