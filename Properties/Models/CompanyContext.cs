using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CompanyApi.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; } = null!;
    }
}