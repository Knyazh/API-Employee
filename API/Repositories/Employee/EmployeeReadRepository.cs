using Employee.Application.Repositories.Employee;
using API.Contexts;

namespace API.Repositories.Employee;

public class EmployeeReadRepository : ReadRepository<Entities.Employee>, IEmployeeReadRepository
{
    public EmployeeReadRepository(EmployeeDbContext context) : base(context)
    {
    }
}
