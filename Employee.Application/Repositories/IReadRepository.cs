using FiftyOne.Foundation.Mobile.Detection.Entities;

namespace Employee.Application.Repositories;

public interface IReadRepository<T>:IRepository<T> where T:BaseEntity, new()
{
    IQueryable<T> GetAll(bool isTracking = false);
    Task<T> GetById( Guid id,bool isTracking = false);
    T GetByCondition();
}
