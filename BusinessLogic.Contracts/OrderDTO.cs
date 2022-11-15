namespace BusinessLogic.Contracts
{
    /// <summary>
    /// ДТО заказа
    /// </summary>
    public class OrderDTO
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
        /// Уроки
        /// </summary>
        public List<PositionDTO> Positions { get; set; } = new List<PositionDTO>();
    }
}