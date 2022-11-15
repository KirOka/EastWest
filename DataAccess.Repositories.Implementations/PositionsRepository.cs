using DataAccess.Entities;
using DataAccess.EntityFramework;
using DataAccess.Implementation;
using DataAccess.Repositories.Abstractions;

namespace DataAccess.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий работы с позициями
    /// </summary>
    public class PositionsRepository : Repository<Position, int>, IPositionsRepository
    {
        public PositionsRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
