using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieWatchProvidersResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("results")]
        public WatchProviderList Results { get; set; }
    }
}