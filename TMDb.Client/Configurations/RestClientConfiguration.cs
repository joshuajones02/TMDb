using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http.Headers;
using TMDb.Client.Constants;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Configurations
{
    public class RestClientConfiguration : IRestClientConfiguration
    {
        public long MaxResponseContentBufferSize { get; protected set; }

        public TimeSpan Timeout { get; protected set; }

        public JsonSerializerSettings RequestSerializationSettings { get; protected set; }
        public JsonSerializerSettings ResponseSerializationSettings { get; protected set; }
        public MediaTypeWithQualityHeaderValue ApplicationJsonHeader { get; protected set; }
        public MediaTypeWithQualityHeaderValue TextJsonHeader { get; protected set; }

        public RestClientConfiguration()
        {
            ApplicationJsonHeader = new MediaTypeWithQualityHeaderValue(ContentType.Json);
            TextJsonHeader = new MediaTypeWithQualityHeaderValue(ContentType.JsonText);
            MaxResponseContentBufferSize = int.MaxValue;
            RequestSerializationSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            ResponseSerializationSettings = new JsonSerializerSettings
            {
                Error = (sender, args) => args.ErrorContext.Handled = true,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter[] 
                { 
                    new EnumDescriptionConverter(),
                    new StringEnumConverter()
                }
            };
            Timeout = TimeSpan.FromSeconds(60);
        }

        private static RestClientConfiguration _instance;

        public static RestClientConfiguration Instance => _instance ??= new RestClientConfiguration();
    }
}