namespace EastWest.Models
{
    /// <summary>
    /// Модель заказа для просмотра
    /// </summary>
    public class OrderViewModel
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
        public List<PositionViewModel> Positions { get; set; } = new List<PositionViewModel>();
    }
}
