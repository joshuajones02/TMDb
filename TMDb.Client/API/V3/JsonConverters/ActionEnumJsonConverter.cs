using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.API.V3.JsonConverters
{
    public class ActionEnumJsonConverter : JsonConverter
    {
        private static ActionEnumJsonConverter _instance;
        public static ActionEnumJsonConverter Instance =>
            _instance = _instance ?? new ActionEnumJsonConverter();

        public override bool CanConvert(Type t) =>
            t == typeof(Models.TV.Action) || t == typeof(Models.TV.Action?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "added":
                    return Models.TV.Action.Added;
                case "deleted":
                    return Models.TV.Action.Deleted;
                case "updated":
                    return Models.TV.Action.Updated;
            }

            throw new Exception("Cannot unmarshal type Action");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Models.TV.Action)untypedValue;
            switch (value)
            {
                case Models.TV.Action.Added:
                    serializer.Serialize(writer, "added");
                    return;
                case Models.TV.Action.Deleted:
                    serializer.Serialize(writer, "deleted");
                    return;
                case Models.TV.Action.Updated:
                    serializer.Serialize(writer, "updated");
                    return;
            }

            throw new Exception("Cannot marshal type Action");
        }
    }
}
