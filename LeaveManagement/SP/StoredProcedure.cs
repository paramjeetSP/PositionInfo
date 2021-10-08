using LeaveManagement.Database;
using LeaveManagement.Models.SpModels;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.SP
{
    public class StoredProcedure : Recovered_hrmsnewContext
    {
        public StoredProcedure(DbContextOptions<Recovered_hrmsnewContext> options)
            : base(options)
        {
        }
        public virtual DbSet<SingleEmployee> Emp_GetAllEmployeeProfile { get; set; }
        public virtual DbSet<TotalLeaveByDepartment> HRMS_GetTotalDepartment { get; set; }
    }
}
