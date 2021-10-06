using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TblExceptionLogger
    {
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ControllerName { get; set; }
        public string ExceptionStackTrace { get; set; }
        public DateTime? LogTime { get; set; }
        public string UserId { get; set; }
        public string Platform { get; set; }
        public string InnerException { get; set; }
    }
}
