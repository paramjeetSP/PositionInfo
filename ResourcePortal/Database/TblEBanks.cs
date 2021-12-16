using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblEBanks
    {
        public TblEBanks()
        {
            TbEmployeeBankAndPfrecord = new HashSet<TbEmployeeBankAndPfrecord>();
        }

        public int Id { get; set; }
        public string BankName { get; set; }
        public bool? IsDeleted { get; set; }

        public ICollection<TbEmployeeBankAndPfrecord> TbEmployeeBankAndPfrecord { get; set; }
    }
}
