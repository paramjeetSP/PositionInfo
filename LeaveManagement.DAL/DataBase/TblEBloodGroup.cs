using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class TblEBloodGroup
    {
        public TblEBloodGroup()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
