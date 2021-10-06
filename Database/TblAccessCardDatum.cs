﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblAccessCardDatum
    {
        public int Id { get; set; }
        public DateTime? Time { get; set; }
        public int? CardNo { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Dept { get; set; }
        public string Source { get; set; }
        public string Note { get; set; }
    }
}
