using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmployeeStatusEvent
    {
        public TbEmployeeStatusEvent()
        {
            TbEmployeeStatusRecords = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Events { get; set; }

        public virtual ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecords { get; set; }
    }
}
