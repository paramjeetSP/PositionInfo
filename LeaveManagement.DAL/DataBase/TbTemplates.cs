using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
