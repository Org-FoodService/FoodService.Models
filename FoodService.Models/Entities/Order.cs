using FoodService.Models.Auth.User;

namespace FoodService.Models.Entities
{
    /// <summary>
    /// Represents an order placed by a user.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the ID of the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the list of items included in the order.
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Gets or sets the user who placed the order.
        /// </summary>
        public UserBase User { get; set; }
    }

    /// <summary>
    /// Represents an item included in an order.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the ID of the order item.
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Gets or sets the product associated with this order item.
        /// </summary>
        public Product? Product { get; set; }
    }
}
