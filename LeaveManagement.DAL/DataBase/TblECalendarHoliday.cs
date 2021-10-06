using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
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
