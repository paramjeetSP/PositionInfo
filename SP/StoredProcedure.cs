using Microsoft.EntityFrameworkCore;
using PositionInfo.Database;
using PositionInfo.Models.SpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PositionInfo.SP
{
    public class StoredProcedure : Recovered_hrmsnewContext
    {
        public StoredProcedure(DbContextOptions<Recovered_hrmsnewContext> options)
            : base(options)
        {
        }
        public virtual DbSet<DepartmentList> DepartmentList { get; set; }
    }
}
