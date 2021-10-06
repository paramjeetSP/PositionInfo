using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class MobileAppUpdateTable
    {
        public int Id { get; set; }
        public string VersionNumber { get; set; }
        public string VersionFileLinkAndroid { get; set; }
        public string VersionFileLinkIos { get; set; }
        public string VersionMessageText { get; set; }
        public string PreviousVersionFileLinkAndroid { get; set; }
        public string PreviousVersionFileLinkIos { get; set; }
    }
}
