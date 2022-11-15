using DataAccess.Abstraction;
using DataAccess.Entities;

namespace DataAccess.Repositories.Abstractions
{
    public interface IOrdersRepository : IRepository<Order, int>
    {
    }
}
