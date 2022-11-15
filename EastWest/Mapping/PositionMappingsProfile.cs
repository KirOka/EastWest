using AutoMapper;
using BusinessLogic.Contracts;
using EastWest.Models;

namespace EastWest.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности позиции.
    /// </summary>
    public class PositionMappingsProfile : Profile
    {
        public PositionMappingsProfile()
        {
            CreateMap<PositionDTO, PositionModel>();

            CreateMap<PositionModel, PositionDTO>()
                .ForMember(d => d.Id, map => map.Ignore());
        }
    }
}
