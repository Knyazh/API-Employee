using FiftyOne.Foundation.Mobile.Detection.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Application.Repositories;

public interface IRepository<T> where T : BaseEntity, new()
{
    DbSet<T> Table { get; }
}
