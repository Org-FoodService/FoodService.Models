namespace FoodService.Models.Responses
{
    /// <summary>
    /// Represents a common response with generic data.
    /// </summary>
    /// <typeparam name="T">Type of the data.</typeparam>
    public class ResponseCommon<T> : ResponseError
    {

        /// <summary>
        /// Gets the data associated with the response.
        /// </summary>
        public T Data { get; private set; }

        public ResponseCommon(int statusCode, string message, T data, string? error = null, bool success = false) : base(statusCode, success, message, error)
        {
            Data = data;
        }

        /// <summary>
        /// Creates a successful response with the provided data.
        /// </summary>
        /// <param name="data">The data to include in the response.</param>
        /// <param name="message">Optional message for the response.</param>
        /// <returns>A successful response object.</returns>
        public static ResponseCommon<T> Success(T data, string message = "Success")
        {
            return new ResponseCommon<T>(200, message, data, success: true);
        }

        /// <summary>
        /// Creates a failed response with the provided error message.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="statusCode">Optional status code for the response. Default is 500 (Internal Server Error).</param>
        /// <param name="error">Optional detailed error information.</param>
        /// <returns>A failed response object.</returns>
        public static ResponseCommon<T> Failure(string message, int statusCode = 500, string? error = null)
        {
            return new ResponseCommon<T>(statusCode, message, default!, error);
        }
    }
}
