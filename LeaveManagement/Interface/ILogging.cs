using System;

namespace LeaveManagement.Interface
{
    public interface ILogging
    {
        void LogToDb(Exception ex, string controllerName, string Platform);
    }
}
