﻿using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class AppraisalCycle
    {
        public int Id { get; set; }
        public int? JoinMonth1 { get; set; }
        public int? JoinMonth2 { get; set; }
        public int? JoinMonth3 { get; set; }
        public int? NextAppraisalMonth { get; set; }
    }
}