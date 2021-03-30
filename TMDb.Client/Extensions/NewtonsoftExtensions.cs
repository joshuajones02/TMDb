using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;

namespace TMDb.Client
{
    internal static class NewtonsoftExtensions
    {
        internal static readonly JsonSerializerSettings _defaultSettings;

        static NewtonsoftExtensions() =>
            _defaultSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new EnumDescriptionConverter(),
                    new StringEnumConverter()
                }
            };

        private static string JsonObjectWrapper(this string array) =>
            $"{{\"results\":{array}}}";

        internal static string ToJson(this object @object, JsonSerializerSettings settings = null) =>
            JsonConvert.SerializeObject(@object, settings ?? _defaultSettings);

        internal static T ToObject<T>(this string json, JsonSerializerSettings settings = null, bool wrapCollectionInResultObject = false)
        {
            if (wrapCollectionInResultObject && json.StartsWith("["))
            {
                json = json.JsonObjectWrapper();
            }

            return JsonConvert.DeserializeObject<T>(json, settings ?? _defaultSettings);
        }

        internal static bool TryParseObject<T>(this JsonReader reader, JsonSerializer serializer, out T @object)
        {
            try
            {
                @object = serializer.Deserialize<T>(reader);
                return true;
            }
            catch
            {
                @object = default(T);
                return false;
            }
        }
    }
}