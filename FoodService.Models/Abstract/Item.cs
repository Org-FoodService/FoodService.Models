using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodService.Models.Abstract
{
    /// <summary>
    /// Abstract class representing an item.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short description of the product.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the item.
        /// </summary>
        [MaxLength(16), Column(TypeName = "Binary")]
        public byte[]? Image { get; set; }
    }
}
