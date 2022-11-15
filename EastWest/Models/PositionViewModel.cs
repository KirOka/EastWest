namespace EastWest.Models
{
    /// <summary>
    /// Модель позиции для просмотра
    /// </summary>
    public class PositionViewModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

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
