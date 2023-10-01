using API.Configuration;
using Microsoft.EntityFrameworkCore;

namespace API.Contexts;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Employee> Employees { get; set; } = null!;
}
