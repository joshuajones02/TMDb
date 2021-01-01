using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TMDb.Client.JsonConverters
{
    public class EnumDescriptionConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override bool CanConvert(Type objectType) =>
            typeof(Type).IsAssignableFrom(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
            throw new NotSupportedException();

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var description = value.GetType()
                                  .GetMember(value.ToString())
                                  .FirstOrDefault()
                                  .GetCustomAttribute<DescriptionAttribute>();

                serializer.Serialize(writer, description);
            }
        }
    }
}