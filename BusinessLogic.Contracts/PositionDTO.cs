namespace BusinessLogic.Contracts
{
    /// <summary>
    /// ДТО позиции
    /// </summary>
    public class PositionDTO
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
