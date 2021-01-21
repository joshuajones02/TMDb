using System.Collections.Generic;
using TMDb.Client.API;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public interface IRequestBuilder
    {
        ApiEndpoint GetApiEndpoint(RequestBase request);
        List<ApiParameter> GetApiParameters(RequestBase request);
    }
}