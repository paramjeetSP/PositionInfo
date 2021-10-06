using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblDiConsultCharge
    {
        public double? Id { get; set; }
        public double? ConsultFee { get; set; }
        public double? ConsultWithPrescriptionFee { get; set; }
        public double? FkCountryId { get; set; }
    }
}
