using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class MasterGoalCategory
    {
        public int Id { get; set; }
        public string GoalName { get; set; }
        public bool? IsActive { get; set; }
    }
}
