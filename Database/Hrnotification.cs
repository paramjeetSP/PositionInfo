﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class Hrnotification
    {
        public int Id { get; set; }
        public int? Hrid { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public bool? IsRead { get; set; }
    }
}
