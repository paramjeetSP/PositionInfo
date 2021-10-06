using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblDiGeoStates
    {
        public double StateId { get; set; }
        public double? FkCountryId { get; set; }
        public string StateName { get; set; }
    }
}
