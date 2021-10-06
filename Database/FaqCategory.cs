using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class FaqCategory
    {
        public FaqCategory()
        {
            Faqs = new HashSet<Faq>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Faq> Faqs { get; set; }
    }
}
