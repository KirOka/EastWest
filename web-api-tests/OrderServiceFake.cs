using BusinessLogic.Contracts;
using BusinessLogic.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_api_tests
{
    internal class OrderServiceFake : IOrderService
    {
        private readonly List<OrderDTO> _orderDTO;

        public OrderServiceFake()
        {
            _orderDTO = new List<OrderDTO>();
            OrderDTO orderDTO = new OrderDTO() {Id=1, Name="Test1", Positions= new List<PositionDTO>() };
            orderDTO.Positions.Add(new PositionDTO() { ProductCode = 456789, Price = 10 });
            orderDTO.Positions.Add(new PositionDTO() { ProductCode = 456258, Price = 12 });
            _orderDTO.Add(orderDTO);
            orderDTO = new OrderDTO() { Id=2, Name = "Test2", Positions = new List<PositionDTO>() };
            orderDTO.Positions.Add(new PositionDTO() { ProductCode = 741789, Price = 55 });
            orderDTO.Positions.Add(new PositionDTO() { ProductCode = 745258, Price = 47 });
            orderDTO.Positions.Add(new PositionDTO() { ProductCode = 745123, Price = 58 });
            _orderDTO.Add(orderDTO);
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО заказа</returns>
        public async Task<OrderDTO> GetById(int id)
        {
            return _orderDTO.Where(a => a.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="orderDTO">ДТО заказа</param>
        /// <returns>идентификатор</returns>
        public async Task<int> Create(OrderDTO orderDTO)
        {
            int newId = _orderDTO.MaxBy(a => a.Id).Id + 1;
            orderDTO.Id = newId;
            return newId;
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="orderDTO">ДТО заказа</param>
        public async Task Update(int id, OrderDTO orderDTO)
        {
            OrderDTO orderDTOForUpdate = _orderDTO.Where(a => a.Id == id).FirstOrDefault();
            if (orderDTOForUpdate != null)
            {
                orderDTOForUpdate.Name = orderDTO.Name;
            }
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task Delete(int id)
        {
            OrderDTO orderDTOForDelete = _orderDTO.Where(a => a.Id == id).FirstOrDefault();
            if (orderDTOForDelete != null)
            {
                _orderDTO.Remove(orderDTOForDelete);
            }
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<OrderDTO>> GetAll()
        {
            return _orderDTO;
        }
    }
}
