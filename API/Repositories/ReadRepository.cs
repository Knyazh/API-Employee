
using API.Contexts;
using API.Entities;
using Employee.Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{

    private readonly EmployeeDbContext _context;

    public ReadRepository(EmployeeDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool isTracking = false)
    {
        var query = Table.AsQueryable();
        if (!isTracking)
        {
            query = query.AsNoTracking();
        }
        return query;
    }

    public T GetByCondition()
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetById(Guid id, bool isTracking = false)
    {
        var query = Table.AsQueryable();
        if (!isTracking)
        {
            query = Table.AsNoTracking();
        }
        return await query.FirstOrDefaultAsync(p => p.Id == id);

    }
}
