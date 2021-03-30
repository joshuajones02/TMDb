using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("rated")]
        public virtual MediaRating Rated { get; set; }
    }
}