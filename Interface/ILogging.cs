using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PositionInfo.Interface
{
    public interface ILogging
    {
        void LogToDb(Exception ex, string controllerName, string Platform);
    }
}
