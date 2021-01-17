using Newtonsoft.Json;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("favorite")]
        public virtual bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public virtual bool Watchlist { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonConverter(typeof(RatedBoolUnionConverter))]
        [JsonProperty("rated")]
        public virtual RatedUnion Rated { get; set; }
    }

    public class Rated
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }

    public struct RatedUnion
    {
        public bool? Bool;
        public Rated Rated;

        public static implicit operator RatedUnion(bool Bool) =>
            new RatedUnion { Bool = Bool };

        public static implicit operator RatedUnion(Rated Rated) =>
            new RatedUnion { Rated = Rated };
    }
}