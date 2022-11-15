using DataAccess.Abstraction;

namespace DataAccess.Entities
{
    /// <summary>
    /// Позиция заказа
    /// </summary>
    public class Position : IEntity<int>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заказ
        /// </summary>
        public virtual Order? Order { get; set; }

        /// <summary>
        /// Id курса
        /// </summary>
        public int? OrderId { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        public int ProductCode { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
    }
}
