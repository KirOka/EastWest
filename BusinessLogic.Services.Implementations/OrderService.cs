using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Services.Abstractions;
using DataAccess.Entities;
using DataAccess.Repositories.Abstractions;
using System.Collections.Generic;
using System.Numerics;

namespace BusinessLogic.Services.Implementations
{
    /// <summary>
    /// Сервис работы с заказами
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrdersRepository _orderRepository;

        public OrderService(
            IMapper mapper,
            IOrdersRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО заказа</returns>
        public async Task<OrderDTO> GetById(int id)
        {
            var order = await _orderRepository.GetAsync(id);
            return _mapper.Map<OrderDTO>(order);
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="orderDTO">ДТО заказа</param>
        /// <returns>идентификатор</returns>
        public async Task<int> Create(OrderDTO orderDTO)
        {
            var entity = _mapper.Map<OrderDTO, Order>(orderDTO);
            var res = await _orderRepository.AddAsync(entity);
            return res.Id;
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="orderDTO">ДТО заказа</param>
        public async Task Update(int id, OrderDTO orderDTO)
        {
            var entity = _mapper.Map<OrderDTO, Order>(orderDTO);
            entity.Id = id;
            _orderRepository.Update(entity);
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<OrderDTO>> GetAll()
        {
            ICollection<Order> entities = await _orderRepository.GetAllAsync();
            return _mapper.Map<ICollection<Order>, ICollection<OrderDTO>>(entities);
        }
    }
}