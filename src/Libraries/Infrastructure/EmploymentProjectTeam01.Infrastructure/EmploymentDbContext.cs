using Microsoft.EntityFrameworkCore;

namespace EmploymentProjectTeam01.Infrastructure;

public class EmploymentDbContext : DbContext
{
    public EmploymentDbContext(DbContextOptions<EmploymentDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmploymentDbContext).Assembly);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
