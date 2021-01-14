using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Models.Proxies.TVSeasons;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesRequest : TVSeasonsRequest
    {
        [JsonIgnore]
        [Required]
        [StringFormatParameter("episode_number")]
        public virtual int? EpisodeNumber { get; set; }
    }
}