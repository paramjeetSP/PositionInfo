using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmployeeBankAndPfrecord
    {
        public int Id { get; set; }
        public int? Fkemployee { get; set; }
        public int? Fkbank { get; set; }
        public string Branch { get; set; }
        public string Isfccode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string PaymentType { get; set; }
        public string PayableAt { get; set; }
        public string Name { get; set; }
        public bool? IsPfscheme { get; set; }
        public DateTime? PfjoinDate { get; set; }
        public string Pfscheme { get; set; }
        public string Pfnumber { get; set; }
        public bool? IsEpfexcessContribution { get; set; }
        public bool? IsEpsexcessContribution { get; set; }
        public bool? IsEsischeme { get; set; }
        public string Esinumber { get; set; }
        public string FamilyPfnumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblEBank FkbankNavigation { get; set; }
        public virtual Employee FkemployeeNavigation { get; set; }
    }
}
