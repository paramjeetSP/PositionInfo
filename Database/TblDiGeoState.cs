using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblDiGeoState
    {
        public double StateId { get; set; }
        public double? FkCountryId { get; set; }
        public string StateName { get; set; }
    }
}
