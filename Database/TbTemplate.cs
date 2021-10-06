using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbTemplate
    {
        public int Id { get; set; }
        public string TemplatePath { get; set; }
        public int EventId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TbApplicationEvent Event { get; set; }
    }
}
