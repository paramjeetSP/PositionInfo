using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TlEthic
    {
        public TlEthic()
        {
            TlAcceptEthics = new HashSet<TlAcceptEthic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Content { get; set; }

        public virtual ICollection<TlAcceptEthic> TlAcceptEthics { get; set; }
    }
}
