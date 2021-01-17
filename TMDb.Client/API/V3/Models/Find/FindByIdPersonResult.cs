using Newtonsoft.Json;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.Find
{
    public class FindByIdPersonResult
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonConverter(typeof(MovieTVUnionConverter))]
        [JsonProperty("original_language")]
        public virtual FindByIdMovieTVUnion KnownFor { get; set; }
    }
}