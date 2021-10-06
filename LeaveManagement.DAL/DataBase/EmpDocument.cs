using System;
using System.Collections.Generic;

namespace LeaveManagement.DAL.DataBase
{
    public partial class EmpDocument
    {
        public int Id { get; set; }
        public int? FkDocumentType { get; set; }
        public int FkEmployeeId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public DateTime? SubDate { get; set; }
        public bool? IsDelete { get; set; }

        public TbDocumentType FkDocumentTypeNavigation { get; set; }
    }
}
