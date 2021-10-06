using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmailQueue
    {
        public TbEmailQueue()
        {
            TbActionTakens = new HashSet<TbActionTaken>();
            TbEmailFailureRecords = new HashSet<TbEmailFailureRecord>();
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

        public virtual Employee Employee { get; set; }
        public virtual TbApplicationEvent Event { get; set; }
        public virtual ICollection<TbActionTaken> TbActionTakens { get; set; }
        public virtual ICollection<TbEmailFailureRecord> TbEmailFailureRecords { get; set; }
    }
}
