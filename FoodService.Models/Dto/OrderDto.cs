using FoodService.Models.Entities;

namespace FoodService.Models.Dto
{
    public class OrderDto
    {
        /// <summary>
        /// Gets or sets the list of items included in the order.
        /// </summary>
        public List<OrderItemDto> OrderItems { get; set; }
    }
    public class OrderItemDto
    {
        /// <summary>
        /// Gets or sets the quantity of the product in the order item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets any additional comments for the order item.
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the ID of the product associated with this order item.
        /// </summary>
        public int ProductId { get; set; }
    }
}
