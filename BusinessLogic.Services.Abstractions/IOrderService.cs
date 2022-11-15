using BusinessLogic.Contracts;

namespace BusinessLogic.Services.Abstractions
{
    /// <summary>
    /// Cервис работы с заказами (интерфейс)
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns></returns>
        Task<ICollection<OrderDTO>> GetAll();

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО заказа</returns>
        Task<OrderDTO> GetById(int id);

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="orderDTO">ДТО заказа</para
        Task<int> Create(OrderDTO orderDTO);

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="orderDTO">ДТО заказа</param>
        Task Update(int id, OrderDTO orderDTO);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        Task Delete(int id);
    }
}