using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models.Proxies.TVSeasons;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesTranslationsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("translations")]
        public virtual IEnumerable<TVSeasonsTranslations> Translations { get; set; }
    }
}