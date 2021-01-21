using System;
using System.Net.Http;

namespace TMDb.Client.Validators
{
    public interface IStatusCodeValidator
    {
        void ValidateStatusCode(HttpResponseMessage response, Uri requestUri, int[] expectedStatusCodes);
    }
}