using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblETechnicalskill
    {
        public TblETechnicalskill()
        {
            EmpTechnicalSkills = new HashSet<EmpTechnicalSkill>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmpTechnicalSkill> EmpTechnicalSkills { get; set; }
    }
}
