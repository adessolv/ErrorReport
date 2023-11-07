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

        public DbSet<Report> Report { get; set; } = default!;
    }
}
