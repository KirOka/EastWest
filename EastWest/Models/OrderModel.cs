namespace EastWest.Models
{
    public class OrderModel
    {
        /// <summary>
        /// Наименование заказчика
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Уроки
        /// </summary>
        public List<PositionModel> Positions { get; set; } = new List<PositionModel>();
    }
}
