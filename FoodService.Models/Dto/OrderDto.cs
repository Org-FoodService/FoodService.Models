using FoodService.Models.Entities;

namespace FoodService.Models.Dto
{
    public class OrderDto
    {
        /// <summary>
        /// Gets or sets the list of items included in the order.
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }
    }
}
