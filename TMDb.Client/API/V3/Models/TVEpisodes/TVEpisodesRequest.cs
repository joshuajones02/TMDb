using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.API.V3.Models.TVSeasons;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("")]
    public abstract class TVEpisodesRequest : TVSeasonsRequest
    {
        [JsonIgnore]
        [Required]
        [StringFormatParameter("episode_number")]
        public virtual int EpisodeNumber { get; set; }
    }
}