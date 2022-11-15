using AutoMapper;
using BusinessLogic.Contracts;
using EastWest.Models;

namespace EastWest.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности просмотра заказа.
    /// </summary>
    public class OrderViewMappingsProfile : Profile
    {
        public OrderViewMappingsProfile()
        {
            CreateMap<OrderDTO, OrderViewModel>();

            CreateMap<OrderViewModel, OrderDTO>();
        }
    }
}
