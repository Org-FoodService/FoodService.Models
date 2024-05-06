namespace FoodService.Nuget.Models.Auth.User
{
    /// <summary>
    /// Represents an application user.
    /// </summary>
    public class ClientUser : UserBase
    {

        /// <summary>
        /// Gets or sets the list of Orders .
        /// </summary>
        public List<Order>? Orders { get; set; }
    }
}
