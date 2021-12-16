using System;

namespace ResourcePortal.Interface
{
    public interface ILogging
    {
        void LogToDb(Exception ex, string controllerName, string Platform);
    }
}
