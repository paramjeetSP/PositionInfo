using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TbEmployeeStatusEvents
    {
        public TbEmployeeStatusEvents()
        {
            TbEmployeeStatusRecord = new HashSet<TbEmployeeStatusRecord>();
        }

        public int Id { get; set; }
        public string Events { get; set; }

        public ICollection<TbEmployeeStatusRecord> TbEmployeeStatusRecord { get; set; }
    }
}
