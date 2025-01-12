using System;
using System.Collections.Generic;
using Fitbit.Models;

namespace Fitbit.Api.Portable
{
    public class FitbitRateLimitException : FitbitException
    {
        /// <summary>
        /// The DateTime, in UTC, to retry after from when the exception is created.
        /// </summary>
        public DateTime RetryAfter { get; }

        public FitbitRateLimitException(int retryAfterSeconds, GenericError error)
            : base($"Rate limit exceeded. Try again in {retryAfterSeconds} seconds. See exception for details.", new List<ApiError>() { new ApiError()
            {
                Message = error.message
            } })
        {
            RetryAfter = DateTime.UtcNow.AddSeconds(retryAfterSeconds);
        }
    }
}