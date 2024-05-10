namespace FoodService.Models.Responses
{
    public class ResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="isSuccess"></param>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public ResponseError(int statusCode, bool isSuccess, string message, string? error)
        {
            StatusCode = statusCode;
            IsSuccess = isSuccess;
            Message = message;
            Error = error;
        }

        /// <summary>
        /// Gets the status code of the response.
        /// </summary>
        public int StatusCode { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the response is successful.
        /// </summary>
        public bool IsSuccess { get; private set; }

        /// <summary>
        /// Gets the message associated with the response.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the error message associated with the response, if any.
        /// </summary>
        public string? Error { get; private set; }

    }
}
