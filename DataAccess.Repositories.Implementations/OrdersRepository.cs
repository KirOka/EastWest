using DataAccess.Entities;
using DataAccess.EntityFramework;
using DataAccess.Implementation;
using DataAccess.Repositories.Abstractions;

namespace DataAccess.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий работы с Заказами
    /// </summary>
    public class OrdersRepository : Repository<Order, int>, IOrdersRepository
    {
        public OrdersRepository(ApplicationContext context) : base(context)
        {
        }
    }
}