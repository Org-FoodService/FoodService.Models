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
        /// Gets or sets the user roles.
        /// </summary>
        public List<string> Roles { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class with default values.
        /// </summary>
        [JsonConstructor]
        public SsoDto() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class.
        /// </summary>
        public SsoDto(string accessToken, DateTime expiration, List<string> roles)
        {
            AccessToken = accessToken;
            Expiration = expiration;
            Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SsoDto"/> class.
        /// </summary>
        public SsoDto(string accessToken, DateTime expiration, List<string> roles, UserBase user)
        {
            AccessToken = accessToken;
            Expiration = expiration;
            Roles = roles;
            User = user;
        }
    }
}
