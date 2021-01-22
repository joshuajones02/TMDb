using System;
using System.Collections.Generic;
using System.Net.Http;
using TMDb.Client.Api;
using TMDb.Client.Configurations;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public interface IRequestBuilder
    {
        HttpRequestMessage BuildRequest(Uri baseAddress, RequestBase request, IRestClientConfiguration config);
    }
}