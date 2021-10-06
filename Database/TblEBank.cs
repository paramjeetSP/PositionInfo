using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblEBank
    {
        public TblEBank()
        {
            TbEmployeeBankAndPfrecords = new HashSet<TbEmployeeBankAndPfrecord>();
        }

        public int Id { get; set; }
        public string BankName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<TbEmployeeBankAndPfrecord> TbEmployeeBankAndPfrecords { get; set; }
    }
}
