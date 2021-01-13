using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual  int Id { get; set; }

        [JsonProperty("results")]
        public virtual  Result[] Results { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public virtual  int Id { get; set; }

        [JsonProperty("episode_number")]
        public virtual  int EpisodeNumber { get; set; }

        [JsonProperty("rated")]
        public virtual RatedUnion Rated { get; set; }
    }

    public class RatedClass
    {
        [JsonProperty("value")]
        public virtual  int Value { get; set; }
    }

    public struct RatedUnion
    {
        public bool? Bool;
        public RatedClass RatedClass;

        public static implicit operator RatedUnion(bool Bool) => new RatedUnion { Bool = Bool };
        public static implicit operator RatedUnion(RatedClass RatedClass) => new RatedUnion { RatedClass = RatedClass };
    }

    internal class RatedUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(RatedUnion) || t == typeof(RatedUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new RatedUnion { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RatedClass>(reader);
                    return new RatedUnion { RatedClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type RatedUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RatedUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.RatedClass != null)
            {
                serializer.Serialize(writer, value.RatedClass);
                return;
            }
            throw new Exception("Cannot marshal type RatedUnion");
        }

        public static readonly RatedUnionConverter Singleton = new RatedUnionConverter();
    }
}