﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblMasterEmployeeBehavioural
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
