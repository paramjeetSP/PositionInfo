﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblHEmpTechnicalSkill
    {
        public int? Id { get; set; }
        public int? FkEmployee { get; set; }
        public int? FkTechnicalSkill { get; set; }
        public string TotalExp { get; set; }
        public int? ExpertiseLevel { get; set; }
        public DateTime? LastUsed { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
