using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TblECalendarHoliday
    {
        public int Id { get; set; }
        public string OccasionName { get; set; }
        public DateTime? OccasionDate { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsPublished { get; set; }
    }
}
