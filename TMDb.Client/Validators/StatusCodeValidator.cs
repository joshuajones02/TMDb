using System;
using System.Linq;
using System.Net.Http;

namespace TMDb.Client.Validators
{
    public class StatusCodeValidator : IStatusCodeValidator
    {
        public void ValidateStatusCode(HttpResponseMessage response, Uri requestUri, int[] expectedStatusCodes)
        {
            int statusCode = (int)response.StatusCode;

            if (expectedStatusCodes.Contains(statusCode) == false)
            {
                var message = $"(StatusCode {statusCode}) ";

                switch (statusCode)
                {
                    case 404:
                        throw new HttpRequestException(message + $"Could not locate resource at {requestUri.Host}/{requestUri.AbsolutePath}");

                    default:
                        message = message + $"Unexpected status code was returned. Expected: {string.Join(",", expectedStatusCodes)}";
                        throw new HttpRequestException(message);
                }
            }
        }
    }
}