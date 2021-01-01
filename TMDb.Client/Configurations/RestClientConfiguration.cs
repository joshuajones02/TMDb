using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;

namespace TMDb.Client.Configurations
{
    public class RestClientConfiguration
    {
        public HttpClientHandler Handler { get; }
        public JsonSerializerSettings RequestSerializationSettings { get; }
        public JsonSerializerSettings ResponseSerializationSettings { get; }
        public MediaTypeWithQualityHeaderValue ApplicationJsonHeader { get; }
        public MediaTypeWithQualityHeaderValue TextJsonHeader { get; }

        public RestClientConfiguration()
        {
            ApplicationJsonHeader         = new MediaTypeWithQualityHeaderValue("application/json");
            TextJsonHeader                = new MediaTypeWithQualityHeaderValue("text/json");
            Handler                       = new HttpClientHandler { SslProtocols = SslProtocols.Tls12 };
            RequestSerializationSettings  = new JsonSerializerSettings 
            {
                NullValueHandling       = NullValueHandling.Ignore,
                ReferenceLoopHandling   = ReferenceLoopHandling.Ignore
            };
            ResponseSerializationSettings = new JsonSerializerSettings
            {
                Error = (sender, args) => args.ErrorContext.Handled = true,
                ReferenceLoopHandling   = ReferenceLoopHandling.Ignore,
                ContractResolver        = new CamelCasePropertyNamesContractResolver(),
                Converters              = new JsonConverter[] { new StringEnumConverter() }
            };
        }

        private static RestClientConfiguration _instance;
        public static RestClientConfiguration Instance =>
            _instance = _instance ?? new RestClientConfiguration();
    }
}