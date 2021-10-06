using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TbTemplates
    {
        public int Id { get; set; }
        public string TemplatePath { get; set; }
        public int EventId { get; set; }
        public bool IsDeleted { get; set; }

        public TbApplicationEvents Event { get; set; }
    }
}
