using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using TMDb.Client.Api;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;
using TMDb.Client.Extensions;

namespace TMDb.Client.Builders
{
    public class RequestBuilder : IRequestBuilder
    {
        private readonly IApiParameterSerializer _apiParameterSerializer;

        public RequestBuilder() : this(ApiParameterSerializer.Instance)
        {
        }

        public RequestBuilder(IApiParameterSerializer apiParameterSerializer)
        {
            _apiParameterSerializer = apiParameterSerializer;
        }

        public HttpRequestMessage BuildRequest(Uri baseAddress, RequestBase requestBase, IRestClientConfiguration config)
        {
            var endpoint = requestBase.GetApiEndpoint();
            var parameters = _apiParameterSerializer.SerializeRequestParameters(requestBase);

            var request = new HttpRequestMessage
            {
                Method = endpoint.HttpMethod,
                RequestUri = new UrlBuilder(baseAddress)
                {
                    Path = endpoint.Path,
                    Query = parameters.QueryParameters,
                    Version = parameters.Version,
                    PathParameters = parameters.PathParameters
                }.Uri
            };

            request.Headers.SetRequestHeaders(parameters);

            if (parameters.JsonBody.Any())
            {
                var jsonBody = parameters.JsonBody.ToJson(config.RequestSerializationSettings);
                request.Content = new StringContent(jsonBody, Encoding.UTF8, ContentType.Json);
            }

            return request;
        }
    }
}