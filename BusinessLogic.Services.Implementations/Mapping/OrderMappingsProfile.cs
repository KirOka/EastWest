using AutoMapper;
using BusinessLogic.Contracts;
using DataAccess.Entities;

namespace BusinessLogic.Services.Implementations.Mapping
{
    /// <summary>
    /// Профиль автомаппера для сущности заказа.
    /// </summary>
    public class OrderMappingsProfile : Profile
    {
        public OrderMappingsProfile()
        {
            CreateMap<Order, OrderDTO>();

            CreateMap<OrderDTO, Order>();
        }
    }
}
