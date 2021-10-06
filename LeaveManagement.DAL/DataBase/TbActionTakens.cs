using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TbActionTakens
    {
        public int Id { get; set; }
        public int ActionTakenBy { get; set; }
        public int? NotificationId { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }

        public Employee ActionTakenByNavigation { get; set; }
        public TbEmailQueue Notification { get; set; }
    }
}
