
using FiftyOne.Foundation.Mobile.Detection.Entities;

namespace Employee.Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    void Delete(Guid id);
    Task SaveChangeAsync();
}
