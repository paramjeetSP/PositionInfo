﻿using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class AbsenteesCount
    {
        public int Id { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string EmailBody { get; set; }
        public bool? Status { get; set; }
    }
}
