using AutoMapper;
using BusinessLogic.Contracts;
using DataAccess.Entities;

namespace BusinessLogic.Services.Implementations.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности позиции.
    /// </summary>
    public class PositionMappingsProfile : Profile
    {
        public PositionMappingsProfile()
        {
            CreateMap<Position, PositionDTO>();

            CreateMap<PositionDTO, Position>()
                .ForMember(d => d.Order, map => map.Ignore())
                .ForMember(d => d.OrderId, map => map.Ignore());
        }
    }
}
