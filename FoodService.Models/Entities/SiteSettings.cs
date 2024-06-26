﻿namespace FoodService.Models.Entities
{
    /// <summary>
    /// Represents the site settings for the food service application.
    /// </summary>
    public class SiteSettings
    {
        /// <summary>
        /// Gets or sets the ID of the SiteSettings.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the primary color used in the site's theme.
        /// </summary>
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Gets or sets the secondary color used in the site's theme.
        /// </summary>
        public string SecondaryColor { get; set; }

        /// <summary>
        /// Gets or sets the background color used in the site's theme.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the icon of the service as a byte array.
        /// </summary>
        public byte[]? Icon { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the settings were last updated.
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the dark color used in the site's theme.
        /// </summary>
        public string DarkColor { get; set; }

        /// <summary>
        /// Gets or sets the tertiary color used in the site's theme.
        /// </summary>
        public string TertiaryColor { get; set; }

        /// <summary>
        /// Gets or sets the green color used in the site's theme.
        /// </summary>
        public string GreenColor { get; set; }

        /// <summary>
        /// Gets or sets the success color used in the site's theme.
        /// </summary>
        public string SuccessColor { get; set; }

        /// <summary>
        /// Gets or sets the danger color used in the site's theme.
        /// </summary>
        public string DangerColor { get; set; }
    }
}
