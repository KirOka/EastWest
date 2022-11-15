using AutoMapper;
using BusinessLogic.Contracts;
using EastWest.Models;

namespace EastWest.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности просмотра позиции.
    /// </summary>
    public class PositionViewMappingsProfile : Profile
    {
        public PositionViewMappingsProfile()
        {
            CreateMap<PositionDTO, PositionViewModel>();

            CreateMap<PositionViewModel, PositionDTO>();
        }
    }
}
