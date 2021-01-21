using System;
using System.Collections.Generic;
using System.Net.Http;
using TMDb.Client.Configurations;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public interface IRequestBuilder
    {
        HttpRequestMessage BuildRequest(Uri baseAddress, ApiEndpoint endpoint, List<ApiParameter> parameters, IRestClientConfiguration config);
    }
}