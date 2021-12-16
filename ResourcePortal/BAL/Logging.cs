using ResourcePortal.Database;
using ResourcePortal.Interface;
using System;

namespace ResourcePortal.BAL
{
    public class Logging : ILogging
    {
        private Recovered_hrmsnewContext _context;
        public Logging()
        {

        }
        public Logging(Recovered_hrmsnewContext context)
        {
            _context = context;
        }
        public void LogToDb(Exception ex, string controllerName, string Platform)
        {
            TblExceptionLogger tbl = new TblExceptionLogger();
            tbl.ControllerName = controllerName;
            tbl.Platform = Platform;
            tbl.LogTime = DateTime.Now;
            if (ex.InnerException != null)
            {
                tbl.InnerException = ex.InnerException.ToString();
            }
            else
            {
                tbl.InnerException = "NIL";
            }
            tbl.UserId = "NIL";
            tbl.ExceptionMessage = ex.Message.ToString();
            _context.TblExceptionLogger.Add(tbl);
            _context.SaveChanges();
        }
    }
}
