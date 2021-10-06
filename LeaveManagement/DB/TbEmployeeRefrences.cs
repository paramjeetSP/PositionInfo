using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class TbEmployeeRefrences
    {
        public int Id { get; set; }
        public int Fkemployee { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }

        public Employee FkemployeeNavigation { get; set; }
    }
}
