using System;
using System.Collections.Generic;

namespace LeaveManagement.Database
{
    public partial class TbEmailQueue
    {
        public TbEmailQueue()
        {
            TbActionTakens = new HashSet<TbActionTakens>();
            TbEmailFailureRecords = new HashSet<TbEmailFailureRecords>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int EventId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? EmailSentAt { get; set; }
        public bool? IsEmailSent { get; set; }
        public bool? IsRead { get; set; }
        public DateTime PendingDate { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }

        public Employee Employee { get; set; }
        public TbApplicationEvents Event { get; set; }
        public ICollection<TbActionTakens> TbActionTakens { get; set; }
        public ICollection<TbEmailFailureRecords> TbEmailFailureRecords { get; set; }
    }
}
