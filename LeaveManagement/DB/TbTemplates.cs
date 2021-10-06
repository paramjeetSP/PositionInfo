using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
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
