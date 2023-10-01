using API.Contexts;
using Employee.Application.Repositories.Employee;

namespace API.Repositories.Employee;

public class EmployeeWriteRepository : WriteRepository<Employee>, IEmployeeWriteRepository
{
    public EmployeeWriteRepository(EmployeeDbContext context) : base(context)
    {
    }
}
