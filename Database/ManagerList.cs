using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class ManagerList
    {
        public int Id { get; set; }
        public int? DeptId { get; set; }
        public int? ManagerId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? SubManager { get; set; }
    }
}
