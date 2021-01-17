using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.TV;
using TMDb.Client.API.V3.Models.TVSeasons;

namespace TMDb.Client.API.V3.Models.TVEpisodes
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