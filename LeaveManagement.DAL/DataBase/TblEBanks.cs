using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
