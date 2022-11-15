using DataAccess.Abstraction;

namespace DataAccess.Entities
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : IEntity<int>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование заказчика
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Позиции
        /// </summary>
        public virtual List<Position> Positions { get; set; } = new();
    }
}