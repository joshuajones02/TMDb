using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.People;

namespace TMDb.Client.Entities.Media
{
    public class Episode : EpisodeMinified
    {
        [JsonProperty("crew")]
        public virtual IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public virtual IEnumerable<TVEpisodesGuestStar> GuestStars { get; set; }
    }
}