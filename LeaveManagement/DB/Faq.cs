using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? FkFaqCategory { get; set; }
        public DateTime? ViewedOn { get; set; }
        public int? ViewCounter { get; set; }

        public FaqCategory FkFaqCategoryNavigation { get; set; }
    }
}
