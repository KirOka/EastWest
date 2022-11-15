using AutoMapper;
using BusinessLogic.Contracts;
using EastWest.Models;

namespace EastWest.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности заказа.
    /// </summary>
    public class OrderMappingsProfile : Profile
    {
        public OrderMappingsProfile()
        {
            CreateMap<OrderDTO, OrderModel>();

            CreateMap<OrderModel, OrderDTO>()
                .ForMember(d => d.Id, map => map.Ignore());
        }
    }
}
