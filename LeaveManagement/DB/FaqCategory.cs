using System;
using System.Collections.Generic;

namespace LeaveManagement.DB
{
    public partial class FaqCategory
    {
        public FaqCategory()
        {
            Faq = new HashSet<Faq>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public ICollection<Faq> Faq { get; set; }
    }
}
