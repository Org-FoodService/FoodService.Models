using FoodService.Models.Auth.User;
using System.Text.Json.Serialization;

namespace FoodService.Models.Dto
{
    /// <summary>
    /// Data transfer object for single sign-on (SSO) operation.
    /// </summary>
    public class SsoDto
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the expiration day of the access token.
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Gets or sets the user information.
        /// </summary>
        [JsonIgnore]
        public UserBase User { get; set; }

        /// <summary>
        /// Gets or sets the user roles
        /// </summary>
        public List<string> Roles { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="user">The user information.</param>\
        /// <param name="expiration">The expiration datetime.</param>\
        public SsoDto(string accessToken, UserBase user, DateTime expiration, List<string> roles)
        {
            AccessToken = accessToken;
            User = user;
            Expiration = expiration;
            Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="user">The user information.</param>
        public SsoDto(string accessToken, UserBase user, List<string> roles)
        {
            AccessToken = accessToken;
            User = user;
            Expiration = DateTime.UtcNow.AddHours(3);
            Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="user">The user information.</param>
        public SsoDto(string accessToken, UserBase user)
        {
            AccessToken = accessToken;
            User = user;
            Expiration = DateTime.UtcNow.AddHours(3);
        }
    }
}
