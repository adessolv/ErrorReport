using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErrorReport.Model;

namespace ErrorReport.Data
{
    public class ErrorReportContext : DbContext
    {
        public ErrorReportContext (DbContextOptions<ErrorReportContext> options)
            : base(options)
        {
        }

        public DbSet<ErrorReport.Model.Report> Report { get; set; } = default!;
    }
}
