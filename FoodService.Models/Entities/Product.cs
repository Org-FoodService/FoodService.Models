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
        private static IStringLocalizer _localizer;

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

        /// <summary>
        /// Sets the string localizer for the Product class.
        /// </summary>
        /// <param name="localizer">The string localizer.</param>
        public static void SetLocalizer(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        /// <summary>
        /// Gets the localized name of the product based on the specified culture.
        /// </summary>
        /// <param name="culture">The culture to use for localization.</param>
        /// <returns>The localized name of the product.</returns>
        public string GetLocalizedName(CultureInfo culture)
        {
            var originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            var localizedName = _localizer?[$"{nameof(Product)}_{Id}_Name"] ?? base.Name;
            Thread.CurrentThread.CurrentCulture = originalCulture;
            return localizedName;
        }

        /// <summary>
        /// Gets the localized description of the product based on the specified culture.
        /// </summary>
        /// <param name="culture">The culture to use for localization.</param>
        /// <returns>The localized description of the product.</returns>
        public string GetLocalizedDescription(CultureInfo culture)
        {
            var originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            var localizedDescription = _localizer?[$"{nameof(Product)}_{Id}_Description"] ?? base.Description;
            Thread.CurrentThread.CurrentCulture = originalCulture;
            return localizedDescription;
        }
    }
}