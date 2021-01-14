using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models.Proxies.TVSeasons;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cast")]
        public IEnumerable<TVSeasonsCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public IEnumerable<TVSeasonsCreditsCrew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public IEnumerable<TVEpisodesGuestStar> GuestStars { get; set; }
    }
}