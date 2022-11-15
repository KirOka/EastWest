namespace EastWest.Models
{
    /// <summary>
    /// Модель позиции
    /// </summary>
    public class PositionModel
    {
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
