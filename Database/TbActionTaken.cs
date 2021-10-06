using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbActionTaken
    {
        public int Id { get; set; }
        public int ActionTakenBy { get; set; }
        public int? NotificationId { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Employee ActionTakenByNavigation { get; set; }
        public virtual TbEmailQueue Notification { get; set; }
    }
}
