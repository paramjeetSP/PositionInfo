using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TblETechnicalskills
    {
        public TblETechnicalskills()
        {
            EmpTechnicalSkill = new HashSet<EmpTechnicalSkill>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<EmpTechnicalSkill> EmpTechnicalSkill { get; set; }
    }
}
