using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Interface
{
    public interface ILogging
    {
        void LogToDb(Exception ex, string controllerName, string Platform);
    }
}
