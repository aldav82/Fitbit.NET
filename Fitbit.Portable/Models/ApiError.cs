using Newtonsoft.Json;

namespace Fitbit.Models
{
    public class GenericError
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("message")]
        public string message { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }
    public class ApiError
    {
        /// <summary>
        /// The value of the error being raised - https://dev.fitbit.com/docs/oauth2/#authorization-errors
        /// </summary>
        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        /// <summary>
        /// Added into the model for future reference; currently only used on a couple of errors and no 
        /// data other than "n/a" is returned according to the documentation - https://dev.fitbit.com/docs/oauth2/#api-request-errors
        /// </summary>
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// Response message to provide additional information about the error.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Added into the model for future reference; currently all errors return success as false.
        /// </summary>
        [JsonProperty("success")]
        public bool Success => false;
    }
}