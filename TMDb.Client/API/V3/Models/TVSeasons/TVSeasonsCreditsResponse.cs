using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.TV;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("cast")]
        public virtual IEnumerable<TVSeasonsCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<TVSeasonsCreditsCrew> Crew { get; set; }
    }

    public class TVSeasonsCreditsCast : TVSeasonsCreditsCrew
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }

    public class TVSeasonsCreditsCrew : TVEpisodesGuestStar
    {
        [JsonProperty("job")]
        public virtual string Job { get; set; }

        [JsonProperty("department")]
        public virtual string Department { get; set; }
    }
}