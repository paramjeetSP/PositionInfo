using System;
using System.Collections.Generic;

namespace ResourcePortal.Database
{
    public partial class TlEthics
    {
        public TlEthics()
        {
            TlAcceptEthics = new HashSet<TlAcceptEthics>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Content { get; set; }

        public ICollection<TlAcceptEthics> TlAcceptEthics { get; set; }
    }
}
