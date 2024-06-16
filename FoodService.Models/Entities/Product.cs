using FoodService.Models.Abstract;
using FoodService.Models.Enum;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace FoodService.Models.Entities
{
    /// <summary>
    /// Represents a product entity.
    /// </summary>
    public class Product : Item
    {
        /// <summary>
        /// Gets or sets the ID of the Product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the type of the product.
        /// </summary>
        public ProductTypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets the brand of the product.
        /// </summary>
        public string? Brand { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the list of product ingredients associated with this product.
        /// </summary>
        public List<ProductIngredient>? ProductIngredients { get; set; }
    }
}