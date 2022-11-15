using DataAccess.Abstraction;
using DataAccess.Entities;

namespace DataAccess.Repositories.Abstractions
{
    public interface IPositionsRepository : IRepository<Position, int>
    {
    }
}